using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellingGame
{
    /*
     מחלקת עזר למשחקים, שיורשת את העקרונות של המחלקת עזר הכללית
    GlobalInterface

    במחלקה זו נשתמש במשתנה בשם
    wid
    שהוא רשימה של מילים למשחק

    רעיון כללי של המחלקה הוא לאפשר למשוך כמות מילים רצויה למשחק לפי מילים שלא הוצגו בעבר, ומילים שהשחקן לא הצליח

    נשתמש במחלקת עזר
    ImportWords
    אשר מושכת את המספרי מילים לפי הפרמטרים, ולאחר מכן נמיר אותם לרשימה של מילים למשחק
     */
    class GameInterface : GlobalInterface
    {

        List<WordImageData> wid;

        public List<WordImageData> Wid { get { return wid; } set { wid = value; } }
        public GameInterface(string email):base(email)
        {
            Wid = new List<WordImageData>();
        }

        public void LoadData()
        {
            iw = new ImportWords(Rounds, Datafiles, Myplayer, false); 
            List<int> words = iw.import(); // מושך רשימה של מספרי המילים
            if (words == null)
            {
                throw new Exception("No Question Was Found");
            }
            List<WordImageData> TempWID = iw.GetWIDList(); // מושך את כל המילים מהקובץ נתונים
            int k = 0; // משתנה עזר המצביע לאיזה אינדקס לגשת. שימושי כאשר יש פחות מילים ממה שצריך
            for (int i = 0; i < Rounds; i++)
            {
                k = i;
                if (i >= words.Count)
                {
                    k = i % words.Count;
                }
                Wid.Add(TempWID[words[k] - 1]); // מוסיפים לרשימת מילים למשחק את המילה, לפי אינדקס מ
                                                // words
            }
            Wid = wid.OrderBy(x => Guid.NewGuid()).ToList();  // מסדרים אקראית את הרשימה המוכנה
        }


    }
}
