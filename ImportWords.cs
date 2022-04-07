using System;
using System.Collections.Generic;
using System.IO;

namespace SpellingGame
{
    /*
     מחלקת עזר לעבודה עם המילים השמורות בקבצים, והמילים השמורות בקבצי המשתמש
    file - נתיב של הקובץ מידע המכיל את כל המילים
    player - מכיל את פרטי השחקן, דרכו ניתן לגשת למילים שהצליח ולא הצליח
    numofwords - כמה מילים יש צורך למשוך
    correctpath - נתיב של הקובץ של המילים שהשחקן הצליח
    wrongpath - כנ"ל, רק מילים שלא הצליח
     */
    class ImportWords
    {
        string file;
        Player player;
        int numofwords;
        string correctpath;
        string wrongpath;
        bool spelling;

        public ImportWords(int numofwords, string file, Player player,bool spelling)
        {
            this.player = player;
            this.numofwords = numofwords;
            this.file = file;
            this.spelling = spelling;
            correctpath = player.GetMyCorrectPath(spelling);
            wrongpath = player.GetMyWrongPath(spelling);
        }


        // פונקציה למשיכת מילים והחזרה רשימה של אינדקסים של המילים
        // סדר העדיפות: מילים שלא הצליח, לאחר מכן מילים חדשות, ולבסוף מילים שהשחקן כבר הצליח

        public List<int> import()
        {
            List<int> wordnumbers = new List<int>();
            ImportCorrectAndWrong(wordnumbers);  // מייבא לקובץ משתמש נתונים על מילים שהצליח ולא הצליח
                                                 // לאחר מכן מכניס לרשימה את המילים שלא הצליח
            if (wordnumbers.Count == numofwords)  // אם הגענו לכמות מילים הרצויה רק מהמילים שלא הצליח, הרשימה מוכנה
                return wordnumbers;

            ImportWordsFromFile(wordnumbers);  // נייבא מילים חדשות שהמשתמש עוד לא ניסה
            if (wordnumbers.Count == numofwords) // אם הגענו לכמות מילים הרצויה , הרשימה מוכנה
                return wordnumbers;

            int needtoadd = numofwords - wordnumbers.Count; // סופר כמה מילים עוד חסרות, והשאר יש להוסיף מרשימת המילים שהצליח

            if(needtoadd == numofwords) // אם השחקן הצליח בכל המילים, אז נמחוק את ההיסטוריה שלו על מנת לנסות את המילים מחדש
            {
                player.CleanAllWords(spelling);
                ImportWordsFromFile(wordnumbers);
                needtoadd = numofwords - wordnumbers.Count;
            }

            for (int i = 0; i < needtoadd; i++)
            {
                if(i < player.Correct.Count) 
                wordnumbers.Add(player.Correct[i]);
            }

            return wordnumbers; 
        }


        // מייבא לקובץ משתמש נתונים על מילים שהצליח ולא הצליח
        // לאחר מכן מכניס לרשימה שהתקבלה את המילים שלא הצליח
        private void ImportCorrectAndWrong(List<int> wordnumbers)
        {
            if (File.Exists(correctpath))
            {
                using (StreamReader sr = new StreamReader(correctpath))
                {
                    string str = null;
                    while ((str = sr.ReadLine()) != null)
                    {
                        player.Correct.Add(int.Parse(str));
                    }
                }
            }

            if (File.Exists(wrongpath))
            {
                using (StreamReader sr = new StreamReader(wrongpath))
                {
                    string str = null;
                    while ((str = sr.ReadLine()) != null)
                    {
                        player.Wrong.Add(int.Parse(str));
                        if (wordnumbers.Count < numofwords)
                        {
                            wordnumbers.Add(int.Parse(str));
                        }
                    }
                }
            }
        }


        // נייבא מילים חדשות שהמשתמש עוד לא ניסה לרשימה שהתקבלה
        private void ImportWordsFromFile(List<int> wordnumbers)
        {
            using (StreamReader sr = new StreamReader(file))
            {
                string str = null;
                while ((str = sr.ReadLine()) != null)
                {
                    string[] slice = str.Split(';');
                    int id = int.Parse(slice[0]);
                    if (!player.Correct.Contains(id) && !player.Wrong.Contains(id) && wordnumbers.Count < numofwords)
                    {
                        wordnumbers.Add(id);
                    }
                }
            }
        }

        // מייבא את כל מילות האיות לרשימה ומחזיר אותה
        public List<WordWSpelling> GetWWSList()
        {
            List<WordWSpelling> wws = new List<WordWSpelling>();
            using (StreamReader sr = new StreamReader(file))
            {
                string str = null;
                while ((str = sr.ReadLine()) != null)
                {
                    string[] slice = str.Split(';');
                    wws.Add(new WordWSpelling(int.Parse(slice[0]), slice[1], slice[2], slice[3], slice[4], slice[5]));
                }
            }
            return wws;
        }

        // מייבא את כל מילות המשחק לרשימה ומחזיר אותה
        public List<WordImageData> GetWIDList()
        {
            List<WordImageData> wid = new List<WordImageData>();
            using (StreamReader sr = new StreamReader(file))
            {
                string str = null;
                while ((str = sr.ReadLine()) != null)
                {
                    string[] slice = str.Split(';');
                    List<char> letters = new List<char>();
                    for (int j = 4; j < slice.Length; j++)
                    {
                        letters.Add(char.Parse(slice[j]));
                    }
                    wid.Add(new WordImageData(int.Parse(slice[0]), slice[1], slice[2], slice[3], letters));
                }
            }
            return wid;
        }

        // מכניס אינדקס של מילה למאגר של השחקן
        // מקבלים מספר מילה והאם להכניס לרשימת מילים שהצליח או לרשימת המילים שלא הצליח
        public void AddToOutput(bool correct, int id)
        {
            if(correct)
                File.AppendAllText(correctpath, id.ToString() + '\n');
            else
                File.AppendAllText(wrongpath, id.ToString() + '\n');
        }

        // מוחק אינדקס של מילה מהמאגר של השחקן, ממילים שהצליח או ממילים שלא הצליח
        public void RemoveFromOutput(bool correct, int id)
        {
            string path;
            if (correct)
                path = correctpath;
            else
                path = wrongpath;
            string[] lines = File.ReadAllLines(path);
            File.WriteAllText(path, "");
            for (int i = 0; i < lines.Length; i++)
            {
                if (!lines[i].Equals(id.ToString()))
                {
                    File.AppendAllText(path, lines[i] + "\n");
                }
            }
        }

    }

}
