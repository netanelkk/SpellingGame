using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellingGame
{
    /*
     מחלקת שחקן השומרת את כל המידע על השחקן הנוכחי
    email - כתובת המייל של השחקן (משמש גם כמפתח זיהוי שלו)
    wrong, correct - רשימה של מספרי מילים שהשחקן הצליח או לא הצליח
    אם מדובר באיות, יכיל מילים הרלוונטיות לאיות
    אם מדובר במשחק, יכיל מילים הרלוונטיות למשחק

     */
    class Player : IEquatable<Player>
    {
        string email;
        List<int> wrong;
        List<int> correct;
        public string Email { get { return email; } set { email = value; } }
        public List<int> Wrong { get { return wrong; } set { wrong = value; } }
        public List<int> Correct { get { return correct; } set { correct = value; } }

        public Player(string email)
        {
            Email = email;
            Wrong = new List<int>();
            Correct = new List<int>();
        }

        // מחזיר את שם המשתמש מכתובת המייל
        public string username()
        {
            return Email.Split('@')[0];
        }

        // מחזיר את נתיב המילים שלא הצליח
        // יש לציין האם מדובר במילים לאיות או למשחק
        public string GetMyWrongPath(bool spelling)
        {
            if(spelling)
                return WelcomePage.OUTPUT_PATH + username() + WelcomePage.WRONG_SPELLING_FILE; 
            return WelcomePage.OUTPUT_PATH + username() + WelcomePage.WRONG_FILE;
        }

        // כנ"ל רק למילים שהצליח
        public string GetMyCorrectPath(bool spelling)
        {
            if (spelling)
                return WelcomePage.OUTPUT_PATH + username() + WelcomePage.CORRECT_SPELLING_FILE;
            return WelcomePage.OUTPUT_PATH + username() + WelcomePage.CORRECT_FILE;
        }

        // משווה בין 2 אובייקטים של שחקן לפי כתובת המייל
        public bool Equals(Player other)
        {
            if(Email.Equals(other.Email))
                return true;
            return false;
          
        }


        // מנקה את כל היסטורית המילים של השחקן, של איות או של משחקים
        public void CleanAllWords(bool spelling)
        {
            if(spelling)
            {
                File.WriteAllText(WelcomePage.OUTPUT_PATH + username() + WelcomePage.CORRECT_SPELLING_FILE, "");
                File.WriteAllText(WelcomePage.OUTPUT_PATH + username() + WelcomePage.WRONG_SPELLING_FILE, "");
            }
            else
            {
                File.WriteAllText(WelcomePage.OUTPUT_PATH + username() + WelcomePage.CORRECT_FILE, "");
                File.WriteAllText(WelcomePage.OUTPUT_PATH + username() + WelcomePage.WRONG_FILE, "");
            }
            Wrong.Clear();
            Correct.Clear();
        }


        // משמיד את כל הנתונים על השחקן
        // מוחק את קבצי המידע שלו, ומוחק אותו ממאגר השחקנים
        public void Destroy()
        {
            File.Delete(WelcomePage.OUTPUT_PATH + username() + WelcomePage.CORRECT_SPELLING_FILE);
            File.Delete(WelcomePage.OUTPUT_PATH + username() + WelcomePage.WRONG_SPELLING_FILE);
            File.Delete(WelcomePage.OUTPUT_PATH + username() + WelcomePage.CORRECT_FILE);
            File.Delete(WelcomePage.OUTPUT_PATH + username() + WelcomePage.WRONG_FILE);


            string[] lines = File.ReadAllLines(WelcomePage.PLAYERS_FILE);
            File.WriteAllText(WelcomePage.PLAYERS_FILE, "");
            for (int i = 0; i < lines.Length; i++)
            {
                if (!lines[i].Equals(Email))
                {
                    File.AppendAllText(WelcomePage.PLAYERS_FILE, lines[i] + "\n");
                }
            }

        }
    }
}
