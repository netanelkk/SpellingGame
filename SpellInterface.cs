using System;
using System.Collections.Generic;
using System.Linq;

namespace SpellingGame
{
    /*
     מחלקת עזר לאיות, שיורשת את העקרונות של המחלקת עזר הכללית
    GlobalInterface

    במחלקה זו נשתמש במשתנה בשם
    wws
    שהוא רשימה של מילים לאיות

    נשתמש במחלקת עזר
    ImportWords
    אשר מושכת את המספרי מילים לפי הפרמטרים, ולאחר מכן נמיר אותם לרשימה של מילים למשחק  
     */
    class SpellInterface : GlobalInterface
    {
        List<WordWSpelling> wws;
        public List<WordWSpelling> Wws { get { return wws; } set { wws = value; } }
        public SpellInterface(string email) : base(email)
        {
            Wws = new List<WordWSpelling>();
        }

        public void LoadData()
        {
            iw = new ImportWords(Rounds, Datafiles, Myplayer, true);
            List<int> words = iw.import(); // מושך רשימה של מספרי המילים
            List<WordWSpelling> TempWWS = iw.GetWWSList(); // מושך את כל המילים מהקובץ נתונים
            int k = 0; // משתנה עזר המצביע לאיזה אינדקס לגשת. שימושי כאשר יש פחות מילים ממה שצריך
            for (int i = 0; i < Rounds; i++)
            {
                k = i;
                if(i >= words.Count)
                {
                    k = i % words.Count;
                }
                Wws.Add(TempWWS[words[k] - 1]); // מוסיפים לרשימת מילים למשחק את המילה, לפי אינדקס מ
                                                // words
            }
            Wws = Wws.OrderBy(x => Guid.NewGuid()).ToList(); // מסדרים אקראית את הרשימה המוכנה
        }

    }
}
