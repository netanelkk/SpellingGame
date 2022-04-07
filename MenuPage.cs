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
     המסך הראשי של המשחק
    נותן אופציה לבחור האם לאיית, לשחק, להוסיף מילה או לצאת

     */
    public partial class MenuPage : Form
    {
        string email;
        public MenuPage()
        {
            InitializeComponent();
            email = WelcomePage.GetMail();
        }


        // מעבר לדף תרגול איות
        private void LearnSpelling_Click(object sender, EventArgs e)
        {
            try
            {
                SpellingPage spellingpage = new SpellingPage();
                spellingpage.ShowDialog();
            } catch(Exception ex)
            {
                MessageBox.Show("Couldn't load file: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        // מעבר לדף משחקים
        private void PlayGames_Click(object sender, EventArgs e)
        {
           GamesMenu menupage = new GamesMenu();
           menupage.ShowDialog();
        }

        // מעבר לדף הוספת תוכן
        private void AddContent_Click(object sender, EventArgs e)
        {
            AddWord menupage = new AddWord();
            menupage.ShowDialog();
        }

        private void quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseAlert();
        }

        // בודק האם המשתמש רוצה למחוק את המידע שלו
        private void CloseAlert()
        {
            DialogResult dr = MessageBox.Show("Do You Want To Clean Your History?", "Quit Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Player x = new Player(email);
                x.Destroy();
            }
            this.Close();
        }
    }
}
