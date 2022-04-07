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
     תפריט המשחקים
    בלחיצה על כפתור המשחק, המשחק נפתח
     */
    public partial class GamesMenu : Form
    {
        string email;
        DialogResult dr;

        public GamesMenu()
        {
            InitializeComponent();
            email = WelcomePage.GetMail();
        }

        private void open_ctw_Click(object sender, EventArgs e)
        {

            try
            {
                CompleteTheWordGame opengame = new CompleteTheWordGame();
                dr = opengame.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn't load file: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if(dr==DialogResult.No)
            {
                this.Close();
            }
        }

        private void close_games_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void open_findwords_Click(object sender, EventArgs e)
        {
            try
            {
                FindWordsBeginningWith opengame = new FindWordsBeginningWith();
                dr = opengame.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn't load file: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (dr == DialogResult.No)
            {
                this.Close();
            }
        }

        private void open_memory_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryGame opengame = new MemoryGame();
                dr = opengame.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn't load file: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (dr == DialogResult.No)
            {
                this.Close();
            }
        }

        private void open_typing_Click(object sender, EventArgs e)
        {
            try
            {
                TypingGame opengame = new TypingGame();
                dr = opengame.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Couldn't load file: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (dr == DialogResult.No)
            {
                this.Close();
            }
        }
    }
}
