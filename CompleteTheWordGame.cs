using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpellingGame
{

    /*
     משחק "השלם את המילה"
    יש מילה שחסרה בה אות ו 4 אפשרויות, ויש לבחור את האות הנכונה

     */

    // משתנה עזר לבחירת צבעים
    enum color { wrong,correct,def }; // 0 - שגוי
    // 1 - נכון
    // 2 - ברירת מחדל
    public partial class CompleteTheWordGame : Form
    {
        const int DELAYTIME = 1;     // המתנה של שניה בין שלב לשלב
        SoundPlayer sp;
        char missingletter;     // שומר את האות שחסרה
        List<char> options;     // רשימה של תווים שהן האפשרויות
        string currentword;     // המילה הנוכחית במשחק עם אות חסרה
        Color[] textcolors;      // מערך של הצבעים לפי האירוע
        int ticks; 
        GameInterface GI;

        public CompleteTheWordGame()
        {
            InitializeComponent();
            GI = new GameInterface(WelcomePage.GetMail());
            GI.Rounds = 3;
            GI.Datafiles = WelcomePage.GAME_FILE_NAME;
            sp = new SoundPlayer();
            smiley.Image = Properties.Resources.smile;
            textcolors = new Color[3];     // אתחול מערך צבעים
            textcolors[0] = Color.Tomato;
            textcolors[1] = Color.Chartreuse;
            textcolors[2] = Color.Chocolate;

            try
            {
                GI.LoadData();
            }
            catch (Exception e)
            {
                GI.Loaded = false;
                throw new Exception("Couldn't Load Questions: " + e.Message);
            }

            if(GI.Loaded)
            {
                loadQuestion();
            }

        }


        // טוען את המילה הבאה במשחק.
        private void loadQuestion()
        {
            Image loadimage = Image.FromFile("DIMAGES/"+GI.Wid[GI.Index].Image);
            thepicture.Image = new Bitmap(loadimage);
            currentword = removeLetter();         // מחזיר מילה חדשה עם אות חסרה
            theword.Text = currentword;         
            play();         // משמיע את המילה
            options = createOptions();         // מכין רשימה של אותיות שונות להשלמה
            options = options.OrderBy(x => Guid.NewGuid()).ToList();         // מערבב את הרשימה
            letter1.Text = options[0].ToString();
            letter2.Text = options[1].ToString();
            letter3.Text = options[2].ToString();
            letter4.Text = options[3].ToString();

        }


        // אירוע בעת לחיצה על אות, בודק האם האות משלימה למילה הנכונה
        private void letterChoosed(int id)
        {
            int wordId = GI.Wid[GI.Index].Number;         // המספר מזהה של המילה הנוכחית
            theword.Text = currentword.Replace('_', options[id - 1]);         // מציג את המילה עם האות שנבחרה
            if (options[id - 1]==missingletter)         // אם המילה נכונה
            {
                GI.CorrectAnswer(wordId);         // מעדכן את קובץ נתוני המשתמש
                smiley.Image = Properties.Resources.big_smile;
                theword.BackColor = textcolors[(int)color.correct];         // משנה רקע לטקסט לירוק
                ticks = DELAYTIME;         
                WaitBetweenQuestions.Start();         // ממתינים שניה, ועוברים למילה הבאה
            }
            else
            {
                GI.WrongAnswer(wordId);  // מעדכן את קובץ נתוני המשתמש
                smiley.Image = Properties.Resources.sad;
                theword.BackColor = textcolors[(int)color.wrong];
                ticks = DELAYTIME;
                DisplayWrongWord.Start(); // ממתינים שניה, ומחזירים למילה עם אות חסרה
            }


        }

        // יוצר רשימה של אותיות שונות הכוללות את האות הנכונה
        private List<char> createOptions()
        {
            List<char> options = new List<char>();
            Random r = new Random();
            int asciinum = r.Next(97, 122); // a-z in ASCII
            options.Add(missingletter);
            for(int i = 1; i < 4; i++)
            {
                while(options.Contains((char)asciinum))
                {
                    asciinum = r.Next(97, 122);
                }
                options.Add((char)asciinum);
            }
           return options;
        }

        // מכין מילה חדשה עם אות חסרה בצורה אקראית
        private string removeLetter()
        {
            WordImageData w = GI.Wid[GI.Index]; // מקבל את המילה הנוכחית בצורתה השלמה
            Random r = new Random();
            int skipindex = r.Next(0, w.Letters.Count - 1); // בוחר באיזה אינדקס להוריד את האות
            string newword = "";
            for (int i = 0; i < w.Letters.Count; i++)
            {
                if (i == skipindex)
                {
                    newword += "_";
                    missingletter = w.Letters[i];
                }
                else
                {
                    newword += w.Letters[i];
                }
            }
            return newword;
        }


        // משמיע את האות
        private void play()
        {
            sp.SoundLocation = "VOICE/" + GI.Wid[GI.Index].Voice;
            sp.Play();
        }

        private void letter1_Click(object sender, EventArgs e)
        {
            letterChoosed(1);
        }

        private void letter2_Click(object sender, EventArgs e)
        {
            letterChoosed(2);
        }

        private void letter3_Click(object sender, EventArgs e)
        {
            letterChoosed(3);
        }

        private void letter4_Click(object sender, EventArgs e)
        {
            letterChoosed(4);
        }

        // טיימר שממתין בין מילה למילה במשחק
        private void WaitBetweenQuestions_Tick(object sender, EventArgs e)
        {
            ticks--;
            if(ticks==0)
            {
                if (GI.Index + 1 < GI.Rounds) // בדיקה האם המשחק נגמר
                { 
                    GI.TriesCount = 1; 
                    GI.Index++; // אינדקס של המילה הבאה
                    loadQuestion(); // טעינת המילה לממשק
                }
                else
                {
                    GI.Dr = MessageBox.Show("Good Job!!\nGo back to playzone?", "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                WaitBetweenQuestions.Stop();
            }
        }

        // טיימר שממתין שניה עד שהוא מחליף את המילה השגויה שהמשתמש בחר למילה שבה חסרה האות (לניסיון נוסף)
        private void DisplayWrongWord_Tick(object sender, EventArgs e)
        {
            ticks--;
            if (ticks == 0)
            {
                theword.Text = currentword;
                theword.BackColor = textcolors[(int)color.def];
                DisplayWrongWord.Stop();
            }
        }
    }
}
