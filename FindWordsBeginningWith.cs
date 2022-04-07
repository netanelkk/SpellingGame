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
     משחק שמגריל אות ו 5 מילים ותמונות, ועל השחקן לבחור את המילים שמתחילים באות זו
    שיטת הניקוד: כל ניסיון שגוי מוריד 5 נקודות מתשובה נכונה שתבחר
    כלומר:
    עשרים נקודות לכל מילה נכונה בסיבוב כאשר לא נבחרו מילים שגויות
    חמש עשרה נקודות לכל מילה נכונה בסיבוב, כאשר נבחרה מילה אחת שגויה
    וכך הלאה עד אפס נקודות
     */
    public partial class FindWordsBeginningWith : Form
    {
        const int ROUNDS = 3;
        const int MAXSCORE = 20; // ניקוד מקסימלי
        GameInterface GI;
        char currentletter; // האות הנוכחית בסיבוב
        int howmuchletters; // כמה מילים יש לבחור בסיבוב
        int howmuchchoosed; // כמה מילים נבחרו עד כה
        int tick = 5; // חמש שניות לכל סיבוב


        public FindWordsBeginningWith()
        {
            InitializeComponent();
            GI = new GameInterface(WelcomePage.GetMail());
            GI.Rounds = 5*ROUNDS; // חמש מילים לכל סיבוב כפול 3 סיבובים, סה"כ יש למשוך 15 מילים
            GI.Datafiles = WelcomePage.GAME_FILE_NAME;
            timer_clock.Text = tick.ToString();
            try
            {
                GI.LoadData();
            }
            catch (Exception e)
            {
                GI.Loaded = false;
                throw new Exception("Couldn't Load Questions: " + e.Message);
            }


            if (GI.Loaded)
            {
                scorelabel.Text = "0"; 
                loadQuestion();
            }
        }

        // מכין את הסבב ע"י השמה של 3 מילים ו 2 תמונות בממשק, והגרלת האות
        private void loadQuestion()
        {

            // השמה של מילים ותמונות
            option1.Text = GI.Wid[0 + 5 * GI.Index].WordValue;
            option2.Text = GI.Wid[1 + 5 * GI.Index].WordValue;
            option3.Text = GI.Wid[2 + 5 * GI.Index].WordValue;
            Image loadimage = Image.FromFile("DIMAGES/" + GI.Wid[3 + 5 * GI.Index].Image);
            picture1.Image = new Bitmap(loadimage);
            loadimage = Image.FromFile("DIMAGES/" + GI.Wid[4 + 5 * GI.Index].Image);
            picture2.Image = new Bitmap(loadimage);

            // כל הפקדים פעילים
            option1.Enabled = true;
            option2.Enabled = true;
            option3.Enabled = true;
            picture1.Enabled = true;
            picture2.Enabled = true;

            // הגרלת מילה
            Random r = new Random();
            int range = r.Next(0, 5); 
            currentletter = GI.Wid[range + 5 * GI.Index].Letters[0]; // משיכת האות הראשונה של מילה אקראית במאגר
            howmuchletters = 0;
            howmuchchoosed = 0;
            for (int i = 0; i < 5; i++) // בדיקה של כמה מילים השחקן יצטרך לבחור
            {
                if(GI.Wid[i + 5 * GI.Index].Letters[0]==currentletter)
                {
                    howmuchletters++;
                }
            }
            choosen_letter.Text = Char.ToUpper(currentletter).ToString();

            timer.Start(); // התחלת הסיבוב
        }

        // אירוע של לחיצה על אובייקט, בודק האם נכון
        private void choosed(int id)
        {
            int wordId = GI.Wid[id - 1 + 5 * GI.Index].Number; // מספר מזהה של המילה
            if (GI.Wid[id-1 + 5 * GI.Index].Letters[0]==currentletter)
            {
                GI.CorrectAnswer(wordId); // עדכון קובץ המשתמש על בחירה נכונה
                addscore(MAXSCORE - (GI.TriesCount-1) * 5); // חישוב הניקוד
                choosen_letter.BackColor = Color.Green;
                howmuchchoosed++;
                if(howmuchchoosed == howmuchletters) // בודק האם נבחרו כל האופציות
                {
                    next();
                }
            }
            else
            {
                choosen_letter.BackColor = Color.Red;
                GI.WrongAnswer(wordId); // עדכון קובץ המשתמש על בחירה שגויה
            }

        }

        // טיימר שסופר 5 שניות, ולאחר מכן עובר לסיבוב הבא אוטומטית
        private void timer_Tick(object sender, EventArgs e)
        {
            tick--;
            timer_clock.Text = tick.ToString();
            if (tick<=0)
            {
                next();
            }


        }

        // עובר לסיבוב הבא, או לחילופין מסיים את המשחק בתומו
        private void next()
        {
            if (GI.Index + 1 < ROUNDS)
            {
                tick = 5; // חמש שניות
                GI.TriesCount = 1;
                timer_clock.Text = tick.ToString();
                GI.Index++;
                loadQuestion();
            }
            else
            {
                timer.Stop();
                GI.Dr = MessageBox.Show("Good Job!!\nScore: "+scorelabel.Text+"\n\nGo back to playzone?", "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        // הוספת ניקוד
        private void addscore(int s)
        {
            if(s>0)
            scorelabel.Text = (int.Parse(scorelabel.Text) + s).ToString();
        }
        private void option1_Click(object sender, EventArgs e)
        {
            option1.Enabled = false;
            choosed(1);
        }

        private void option2_Click(object sender, EventArgs e)
        {
            option2.Enabled = false;
            choosed(2);
        }

        private void option3_Click(object sender, EventArgs e)
        {
            option3.Enabled = false;
            choosed(3);
        }

        private void picture1_Click(object sender, EventArgs e)
        {
            picture1.Enabled = false;
            choosed(4);
        }

        private void picture2_Click(object sender, EventArgs e)
        {
            picture2.Enabled = false;
            choosed(5);
        }

        private void FindWordsBeginningWith_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop();
        }
    }
}
