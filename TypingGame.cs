using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpellingGame
{

    /*
     משחק הקלדה של אותיות נופלות
    בכל סבב נופלות אותיות של מילה ויש להקיש אותם במקלדת עד אשר נוצרת מילה
    ולאחר מכן יש לרשום את המילה שנוצרה
    על כל אות שהוקלדה נכון מקבלים חמש נקודות, וכל אות שהוקלדה לא נכון יורדות חמש נקודות
    להתחלת משחק יש ללחוץ על התחל משחק
     */
    public partial class TypingGame : Form
    {
        int score; // ניקוד
        GameInterface GI;
        int letterindex; // האינדקס של האות הבאה במילה
        bool allowtyping; // לאפשר או לא לאפשר לקבל קלט מהמקלדת
        public TypingGame()
        {
            InitializeComponent();
            GI = new GameInterface(WelcomePage.GetMail());
            GI.Rounds = 3;
            GI.Datafiles = WelcomePage.GAME_FILE_NAME;
            try
            {
                GI.LoadData();
            }
            catch (Exception e)
            {
                GI.Loaded = false;
                throw new Exception("Couldn't Load Questions: " + e.Message);
            }

            score = 0;
        }

        // התחלת משחק חדש בלחיצה
        private void start_game_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        // פונקציה להתחלת משחק, מאפס פרמטרים מגריל את האות הבאה ומאפשר קלט מהמקלדת
        private void StartGame()
        {
            letterindex = 0;
            txt_word.Text = "";
            SwitchesOn(true);
            NewLetter();
            GameTimer.Start();
        }

        // הדלקה/כיבוי של מתגים לפי המצב (הקלדת אות או רישום המילה)
        private void SwitchesOn(bool on)
        {
            gamePanel.Visible = on;
            check_btn.Enabled = !on;
            txt_word.Enabled = !on;
            allowtyping = on;
            lblCharcter.Visible = on;
        }

        //  מביא את האות הבאה בתור במילה, בסיום מאפשר לרשום אותה
        private void NewLetter()
        {
            if(letterindex<GI.Wid[GI.Index].WordValue.Length)         // האם נשארו עוד אותיות למילה
            {
                // מצב אות נופלת
                lblCharcter.Location = GetNewPoint();
                lblCharcter.Text = GI.Wid[GI.Index].Letters[letterindex].ToString();
                letterindex++;
            }
            else
            {
                // מצב הקלדת מילה בתיבת טקסט
                GameTimer.Stop();
                SwitchesOn(false);
                txt_word.Focus();
            }

        }

        // פונקציה שמזיזה את האות על המסך
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            lblCharcter.Top += 5;
            if (lblCharcter.Top >= gamePanel.Height)
            {
                lblCharcter.Location = GetNewPoint();
            }
        }

        // מקבל נקודה אקראית על הפאנל להתחלת הנפילה
        private Point GetNewPoint()
        {
            Random xlocation = new Random();
            int x = xlocation.Next(0, gamePanel.Width - lblCharcter.Width);
            return new Point(x, 0);
        }

        // אירוע לחיצה על אות במקלדת
        // בודק האם האות שהוקלדה נכונה או לא
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(allowtyping)
            {
                char userPressKey = e.KeyChar;
                if (lblCharcter.Text == userPressKey.ToString())
                {
                    score += 5;
                    lblScore.Text = score.ToString();
                    NewLetter();
                }
                else
                {
                    if(score>0)
                    score -= 5;
                    lblScore.Text = score.ToString();
                }
            }

        }

        // אירוע לחיצה על כפתור שבודק שהמילה שהשחקן הקליד נכונה
        private void check_btn_Click(object sender, EventArgs e)
        {
            if(txt_word.Text.Equals(GI.Wid[GI.Index].WordValue))         // בודק האם המילה בשורת טקסט תואמת למילה הנוכחית
            {
                GI.CorrectAnswer(GI.Wid[GI.Index].Number);         // מעדכן את קובץ השחקן שהמילה נכונה
                GI.TriesCount = 1;
                MessageBox.Show("WELL DONE!");
                GI.Index++;         // אינדקס של המילה הבאה
                if (GI.Index < GI.Rounds)         // בודק האם יש עוד סבבים או סיום משחק
                {
                    StartGame();
                }
                else
                {
                    GI.Dr = MessageBox.Show("Good Job!!\nScore: "+score.ToString()+"\nGo back to playzone?", "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (GI.Dr == DialogResult.Yes)
                    {
                        this.Close();
                    }
                    else
                    {
                        this.DialogResult = DialogResult.No;
                        this.Close();

                    }
                }

            }
            else
            {
                GI.WrongAnswer(GI.Wid[GI.Index].Number); // מעדכן את קובץ השחקן שהמילה לא נכונה
                MessageBox.Show("You typed the word wrong, try again.");

            }
        }
    }
}
