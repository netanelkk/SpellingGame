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
    public partial class AddWord : Form
    {
        /*
         טופס שמאפשר הוספת מילה לאחד המאגרים
        בהתחלה יש לבחור האם להוסיף מילה לאיות או מילה למשחק
        לאחר מכן במילים לאיות יש לרשום את המילה, להוסיף קובץ סאונד מהמחשב, ולרשום 3 אופציות שגויות
        במילים למשחק יש לרשום את המילה ולהוסיף תמונה וקובץ סאונד מהמחשב
        בסיום הפעולה תקפוץ הודעת אישור והמסך ייסגר
         */

        string gameaudio; // מכיל את הנתיב לקובץ סאונד
        string gameimage; // כנ"ל לתמונה
        public AddWord()
        {
            InitializeComponent();

        }

        // לחיצה על בחירת סאונד למילת איות
        private void spellaudio_Click(object sender, EventArgs e)
        {
            audioSelect(spell_audio);
        }

        // לחיצה על בחירת סאונד למילת משחק
        private void game_audio_Click(object sender, EventArgs e)
        {
            audioSelect(game_audio);
        }

        // מקבל הפניה לכפתור, מאפשר בחירת קובץ, ושומר את הנתיב למשתנה שהגדרנו
        private void audioSelect(Button b)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Wav file | *.wav";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                gameaudio = ofd.FileName;
                b.Text = Path.GetFileName(gameaudio);
            }
        }

        // בלחיצה על בחירת תמונה מאפשר לבחור את התמונה מהמחשב, ושומר את הנתיב במשתנה שהגדרנו
        private void game_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                gameimage = ofd.FileName;
                picture_preview.Load(gameimage);
            }
        }

        // אירוע לחיצה על שמירת מילת משחק. בודק תקינות, ובמידה ותקין שולח את הנתונים למחלקת העזר וממשיך לפונקצית "הצלחה"
        // במידה והמילה כבר קיימת במאגר נזרקת חריגה
        private void save_game_Click(object sender, EventArgs e)
        {
            if(game_word.Text.Length==0 || !game_word.Text.All(Char.IsLetter) || gameimage == null || gameaudio == null)
            {
                MessageBox.Show("Please fill the whole form correctly", "Add word to game", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                bool success = true;
                try
                {
                    WordRepository.AddToGame(game_word.Text, gameimage, gameaudio);
                } catch(Exception exc)
                {
                    MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    success = false;
                }
                if(success)
                {
                    Success();
                }
            }
        }

        // כנ"ל
        private void save_spell_Click(object sender, EventArgs e)
        {
            if (spell_word.Text.Length == 0 || !spell_word.Text.All(Char.IsLetter) || gameaudio == null || 
                txt_wrong1.Text.Length == 0 || !txt_wrong1.Text.All(Char.IsLetter) ||
                txt_wrong2.Text.Length == 0 || !txt_wrong2.Text.All(Char.IsLetter) ||
                txt_wrong3.Text.Length == 0 || !txt_wrong3.Text.All(Char.IsLetter))
            {
                MessageBox.Show("Please fill the whole form correctly", "Add word to spell", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                bool success = true;
                try
                {
                    WordRepository.AddToSpell(spell_word.Text, gameaudio, txt_wrong1.Text, txt_wrong2.Text, txt_wrong3.Text);
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    success = false;
                }
                if (success)
                {
                    Success();
                }
            }
        }

        // מראה הודעת הצלחה וסוגר את הטופס
        private void Success()
        {
            DialogResult dr = MessageBox.Show("Added Successfuly", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if(dr == DialogResult.OK)
            {
                this.Close();
            }
        }

        // אירוע לחיצה על הוספת מילה לאיות
        // מציג את הטופס הרצוי, ומושך בעזרת מחלקת עזר מילים שנוספו בעבר
        private void show_spelling_Click(object sender, EventArgs e)
        {
            spellbox.Visible = true;
            show_games.Enabled = false;
            show_spelling.Enabled = false;
            try
            {
                WordRepository.ReadFromFile((int)type.spell);
            }catch(Exception ex)
            {
                MessageBox.Show("Error with data file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        // כנ"ל
        private void show_games_Click(object sender, EventArgs e)
        {
            gamebox.Visible = true;
            show_games.Enabled = false;
            show_spelling.Enabled = false;
            try
            {
                WordRepository.ReadFromFile((int)type.game);
            } catch(Exception ex)
            {
                MessageBox.Show("Error with data file: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        // סגירת טופס
        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // מחיקת כל המידע במחלקה
        private void AddWord_FormClosed(object sender, FormClosedEventArgs e)
        {
            WordRepository.destroy();
        }
    }
}
