using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpellingGame
{

    /*
     מחלקת עזר למשחקים ולתרגול איות
    מכיל תכונות משותפות בין האירועים:
    rounds - מספר סיבובים
    datafiles - נתיב לקובץ מידע שמכיל את כל המילים
    index - מספר הסיבוב הנוכחי
    myplayer - השחקן, שמכיל מילים שהצליח ולא הצליח
    triescount - סופר כמות כשלונות למילה הנוכחית
    iw - משתנה למחלקת עזר לעבודה מול קבצי המידע
    dr - שומר את תוצאת החלון הקופץ
    loaded - שומר האם טעינת המילים הצליחה. מתחיל מאמת, וכל חריגה משנה לשקר עד לסיום תהליך משיכת המילים
     */
    class GlobalInterface
    {
        int rounds;
        string datafiles;
        int index;
        Player myplayer;
        int triescount;
        public ImportWords iw;
        DialogResult dr;
        bool loaded;

        public int Rounds { get { return rounds; } set { rounds = value; } }
        public string Datafiles { get { return datafiles; } set { datafiles = value; } }
        public int Index { get { return index; } set { index = value; } }
        public Player Myplayer { get { return myplayer; } set { myplayer = value; } }
        public string Email { get { return myplayer.Email; } set { myplayer.Email = value; } }
        public int TriesCount { get { return triescount; } set { triescount = value; } }
        public DialogResult Dr { get { return dr; } set { dr = value; } }
        public bool Loaded { get { return loaded; } set { loaded = value;  } }

        public GlobalInterface(string email)
        {
            TriesCount = 1;
            Index = 0;
            Myplayer = new Player(email);
            Loaded = true;
        }

        // מוסיף מילה שהשחקן טעה למאגר שלו בקבצים, ולמאגר שלו בתור אובייקט שחקן
        // כל כשלון מגדיל את מספר הנסיונות
        public void WrongAnswer(int wordId)
        {
            if (!Myplayer.Wrong.Contains(wordId) && !Myplayer.Correct.Contains(wordId))
            {
                Myplayer.Wrong.Add(wordId);
                iw.AddToOutput(false, wordId);
            }
            TriesCount++;
        }

        // בודק האם צדק במילה בפעם הראשונה, אם כן אז מוסיף את המילה למאגר המילים שהצליח ומוחק את המילה מהמאגר שלא הצליח
        public void CorrectAnswer(int wordId)
        {
            if (triescount == 1)
            {
                if (Myplayer.Wrong.Contains(wordId))
                {
                    Myplayer.Wrong.Remove(wordId);
                    iw.RemoveFromOutput(false, wordId);
                }
                if (!Myplayer.Correct.Contains(wordId))
                {
                    Myplayer.Correct.Add(wordId);
                    iw.AddToOutput(true, wordId);
                }
            }
        }



    }
}
