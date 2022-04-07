using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Media;


namespace SpellingGame
{

    /*
     דף של תרגול האיות
     משתמש במחלקה
    SpellInterface

     */
    public partial class SpellingPage : Form
    {

        SoundPlayer sp;
        string[] options; // מערך עזר לשמירת האפשרויות השונות למילה
        SpellInterface SI;


        public SpellingPage()
        {
            InitializeComponent();
            SI = new SpellInterface(WelcomePage.GetMail());
            SI.Rounds = 5;
            SI.Datafiles = WelcomePage.SPELL_FILE_NAME;
            sp = new SoundPlayer();
            try
            {
                SI.LoadData(); // מושכים 5 שאלות מהקובץ לפי האלגוריתם של המחלקה
            }
            catch (Exception e)
            {
                SI.Loaded = false;
                throw new Exception("Couldn't Load Questions: "+e.Message);

            }
            
            if(SI.Loaded)
            {
                smiley.Image = Properties.Resources.smile;
                cheer.Text = "CHOOSE THE RIGHT WORD";
                loadQuestion();
            }

        }


        // פונקציה שמושכת את המילה הבאה בתור, מסדרת באקראי ומציבה על הכפתורים, ומנגנת את הסאונד
        private void loadQuestion()
        {
            WordWSpelling w = SI.Wws[SI.Index];
            options = new string[4];
            options[0] = w.WordValue;
            options[1] = w.Wrong1;
            options[2] = w.Wrong2;
            options[3] = w.Wrong3;

            Random random = new Random();
            options = options.OrderBy(x => random.Next()).ToArray();

            option1.Text = options[0];
            option2.Text = options[1];
            option3.Text = options[2];
            option4.Text = options[3];

            play();
        }

        // מקבלת את האינדקס של הכפתור שנלחץ ובודקת האם זו התשובה הנכונה
        private void answerChoose(int id)
        {
            int wordId = SI.Wws[SI.Index].Number; // המספר זיהוי של המילה
            if (options[id - 1].Equals(SI.Wws[SI.Index].WordValue)) // האם המילה שנבחרה היא נכונה
            {
                SI.CorrectAnswer(wordId); // מפעילים פונקציה ששומרת במידת הצורך את המילה במאגר השחקן בתור תשובה נכונה
                smiley.Image = Properties.Resources.big_smile; 
                cheer.Text = "YOU RIGHT!"; // שינוי טקסט עידוד

                if (SI.Index+1 < SI.Rounds) // בדיקה האם המשחק נגמר
                {
                    SI.TriesCount = 1; // איפוס מספר נסיונות לשאלה
                    SI.Index++; // שאלה הבאה
                    loadQuestion(); // טעינת שאלה הבאה
                }
                else
                {
                    SI.Dr = MessageBox.Show("Good Job!!\n", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    if (SI.Dr == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }
            else
            {
                SI.WrongAnswer(wordId); // מפעילים פונקציה ששומרת במידת הצורך את המילה במאגר השחקן בתור תשובה לא נכונה
                cheer.Text = "TRY AGAIN";
                smiley.Image = Properties.Resources.sad;
            }
        }

        // ניגון הסאונד
        private void play()
        {
            sp.SoundLocation = "VOICE/"+ SI.Wws[SI.Index].Voice;
            sp.Play();
        }

        // השמעה חוזרת
        private void playAgain_Click(object sender, EventArgs e)
        {
            play();
        }

        private void option1_Click(object sender, EventArgs e)
        {
            answerChoose(1);
        }

        private void option2_Click(object sender, EventArgs e)
        {
            answerChoose(2);
        }

        private void option3_Click(object sender, EventArgs e)
        {
            answerChoose(3);
        }

        private void option4_Click(object sender, EventArgs e)
        {
            answerChoose(4);
        }
    }
}
