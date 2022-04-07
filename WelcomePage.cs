using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpellingGame
{
    /*
     מסך פתיחה של התוכנה
    מברך את השחקן, וממתין לקבלת מייל על מנת להיכנס
    במידה והשחקן קיים במאגר, מקבל ברכת ברוך השב
    במידה ולא, מקבל ברכת ברוך הבא שחקן חדש

     */
    public partial class WelcomePage : Form
    {
        public static string Mail;
        public static string PLAYERS_FILE = "DATA/Players.txt"; // נתיב לקובץ רשימת השחקנים  

        // קבועים של קבצים ותיקיות
        public readonly static string OUTPUT_PATH = "OUTPUT/";
        public readonly static string CORRECT_FILE = "_Correct.txt";
        public readonly static string WRONG_FILE = "_Wrong.txt";
        public readonly static string CORRECT_SPELLING_FILE = "_CorrectSPELLING.txt";
        public readonly static string WRONG_SPELLING_FILE = "_WrongSPELLING.txt";
        public readonly static string GAME_FILE_NAME = "DATA/wordImageData.txt";
        public readonly static string SPELL_FILE_NAME = "DATA/SpellWords.txt";


        List<Player> players;         // רשימת שחקנים
        Player myplayer;         // השחקן שלי 

        public WelcomePage()
        {
            InitializeComponent();
            players = new List<Player>();
            LoadPlayers();
        }

        public static string GetMail()
        {
            return Mail;
        }

        // מושך מהקובץ של השחקנים את כל השחקנים לרשימה
        private void LoadPlayers()
        {
            using (StreamReader sr = new StreamReader(PLAYERS_FILE))
            {
                string str = null;
                while ((str = sr.ReadLine()) != null)
                {
                    players.Add(new Player(str));
                }
            }
        }

        // מוסיף שחקן חדש לקובץ השחקנים
        private void AddPlayer(Player p)
        {
            File.AppendAllText(PLAYERS_FILE, p.Email + '\n');
        }

        // בעת לחיצה כניסה לתוכנה בודק תקינות המייל, ומקפיץ ברכה על המסך, ומעביר למסך הראשי
        private void Enter_Game_Click(object sender, EventArgs e)
        {
            if (email.Text.Contains("@") && !email.Text.Contains(" ") && email.Text.LastIndexOf(".") > email.Text.IndexOf("@"))
            {
                Mail = email.Text;
                myplayer = new Player(email.Text);
                if (players.Contains(myplayer))
                {
                    MessageBox.Show("Welcome Back!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    AddPlayer(myplayer);
                    MessageBox.Show("Welcome new player!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                    
                MenuPage menupage = new MenuPage();
                this.Hide();
                menupage.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Invalid Email Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
