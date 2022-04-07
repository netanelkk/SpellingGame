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
     משחק הזיכרון של מילים ותמונות
    שש מילים ושש תמונות, יש למצוא את כל הזוגות

    שומר לכל ריבוע את המילה או שם קובץ התמונה בתור תגית לזיהוי
     */
    public partial class MemoryGame : Form
    {
        const int ROUNDS = 3;
        Button firstClicked, secondClicked; // שומר את הריבוע הראשון והשני שנלחצו
        GameInterface GI;
        List<WordImageData> Tiles; // רשימה של אובייקט מילים, כל אינדקס מציין ריבוע
        string[] cheers; // מערך עם מילות עידוד
        Dictionary<int, int> triesCount = new Dictionary<int, int>(); // ספריה ששומרת מספר נסיונות שגויים לכל מילה בצורה של
                                                                     // WordId-TriesCount

        public MemoryGame()
        {
            InitializeComponent();
            GI = new GameInterface(WelcomePage.GetMail());
            Tiles = new List<WordImageData>();
            triesCount = new Dictionary<int, int>();
            GI.Rounds = 6*ROUNDS; // שש מילים שונות לכל סיבוב כפול מספר סיבובים
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

            cheers = new string[] { "Great!", "Awesome!", "Super!", "Well Done!","Good Job!" };
            if(GI.Loaded)
            {
                loadTiles();
            }
        }


        // אירוע לחיצה על ריבוע
        private void TileClick(object sender, EventArgs e)
        {
            if (firstClicked != null && secondClicked != null)  // אם שני ריבועים כבר חשופים
                return;

            Button ClickedTile = sender as Button;
            if (firstClicked == null)  // אם ריבוע ראשון לא נבחר עדיין
            {
                firstClicked = ClickedTile;
                ButtonClickEvent(firstClicked);  // מפעיל אירוע לחיצה על ריבוע
                return;
            }
            secondClicked = ClickedTile;
            ButtonClickEvent(secondClicked);

            if (IsPair(firstClicked.Tag.ToString(),secondClicked.Tag.ToString()))  // בודק לפי התגית שלהם אם מדובר על זוג
            {
                int wordId = FindByTag(firstClicked.Tag.ToString()).Number;  // מספר מזהה של המילה
                GI.TriesCount = triesCount[wordId];  // משיכת מספר נסיונות לאותה מילה
                GI.CorrectAnswer(wordId);  // עדכון קובץ משתמש על מילה נכונה
                Random random = new Random();
                cheers = cheers.OrderBy(rx => random.Next()).ToArray();
                cheer.Text = cheers[0];  // עידוד אקראי

                firstClicked.BackColor = Color.PaleGreen;
                secondClicked.BackColor = Color.PaleGreen;

                firstClicked = null;
                secondClicked = null;
            }
            else
            {
                int wordId = FindByTag(firstClicked.Tag.ToString()).Number; // מספר מזהה של המילה
                triesCount[wordId]++;  // מגדיל את מספר הנסיונות
                GI.WrongAnswer(wordId); // עדכון קובץ משתמש על מילה שגויה
                timer1.Start(); // מפעיל טיימר שדואג לסגור את הריבועים שנפתחו
            }


            CheckForWinner(); // בדיקה האם הלוח נפתר
        }


        // בדיקה האם מילה ותמונה מתאימים לאובייקט מילה תקין
        private bool IsPair(string a, string b)
        {
            foreach(WordImageData word in Tiles)
            {
                if((word.WordValue.Equals(a)&&word.Image.Equals(b)) ||
                    (word.WordValue.Equals(b) && word.Image.Equals(a)))
                {
                    return true;
                }
            }
            return false;
        }

        // מחזיר אובייקט מילה לפי תגית
        private WordImageData FindByTag(string tag)
        {
            foreach (WordImageData word in Tiles)
            {
                if ((word.WordValue.Equals(tag) || word.Image.Equals(tag)))
                {
                    return word;
                }
            }
            return null;
        }

        // אירוע לחיצה על ריבוע. מוצא את המילה ברשימה, מוסיף תיאור לתגית ומציג את התמונה או הטקסט
        private void ButtonClickEvent(Button b)
        {
            int x = tableLayoutPanel1.GetCellPosition(b).Column;
            int y = tableLayoutPanel1.GetCellPosition(b).Row;
            WordImageData currentTile = Tiles[x + 4 * y]; // מציאת המילה בתור לפי המיקום שנלחץ
            b.Enabled = false;
            if (currentTile.Image!="") // האם מדובר בתמונה
            {
               
                b.Tag = currentTile.Image;
                Image loadimage = Image.FromFile("DIMAGES/"+currentTile.Image);
                b.BackgroundImage = new Bitmap(loadimage);
            }
            else // אחרת מדובר במילה
            {
                b.Tag = currentTile.WordValue;
                b.Text = currentTile.WordValue;
            }
        }

        // בודק האם הלוח נפתר ע"י בדיקה שכל הריבועים נצבעו
        private void CheckForWinner()
        {
            Button tile;
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                tile = tableLayoutPanel1.Controls[i] as Button;
                if (tile != null && tile.BackColor != Color.PaleGreen)
                    return;
            }
            GI.Index++;
            if (GI.Index<ROUNDS) // מעבר לסבב הבא, אחרת סיום משחק
            {
                Tiles.Clear();
                triesCount.Clear();
                loadTiles(); // טעינת נתונים לריבועים
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

        }

        // החזרת הלוח לקדמותו לאחר בחירה שגויה של 2 ריבועים
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            firstClicked.BackgroundImage = null;
            firstClicked.Text = "";

            secondClicked.BackgroundImage = null;
            secondClicked.Text = "";

            firstClicked.Enabled = true;
            secondClicked.Enabled = true;

            firstClicked = null;
            secondClicked = null;
        }

        // טעינת הריבועים
        private void loadTiles()
        {
            int addition = 6 * GI.Index;

            for (int i = 0; i < tableLayoutPanel1.Controls.Count/2; i++)
            {
                WordImageData nowword = GI.Wid[i+ addition]; 
                Tiles.Add(new WordImageData(nowword.Number, nowword.WordValue, nowword.Image,nowword.Voice,nowword.Letters)); // הוספת תמונה של המילה
                Tiles.Add(new WordImageData(nowword.Number, nowword.WordValue, "", nowword.Voice, nowword.Letters)); // הוספת המילה עצמה. הערך של התמונה ריק על מנת לזהות שמדובר במילה
                if(!triesCount.ContainsKey(nowword.Number)) // בדיקה שאין מילה בספרית הספירת נסיונות והוספה במידת הצורך
                    triesCount.Add(nowword.Number, 1);
            }
             Tiles = Tiles.OrderBy(x => Guid.NewGuid()).ToList(); // ערבוב של הריבועים

            // איפוס כל הריבועים מחדש
            Button tile;
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                tile = tableLayoutPanel1.Controls[i] as Button;
                tile.Enabled = true;
                tile.Text = "";
                tile.BackgroundImage = null;
                tile.BackColor = Color.SeaGreen;

            }
        }
    }
}
