using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellingGame
{
    /*
     מחלקת עזר לדף הוספת מילים למאגר
    קוראת את המילים מהמאגר, מוסיפה למאגר, ובודקת האם קיימת מילה כבר
    GameWords - ספריה המכילה זוגות של המילה ואובייקט של המילה
    בחרנו להשתמש בספריה מכיוון שזה מקל על בדיקה של מילים קיימות
    SpellWords - רשימה של מילים לאיות
    WordCounter - סופר כמה מילים נמשכו מהקובץ. השימוש שלו הוא לדעת לתת למילה חדשה מספר מזהה
     */
    enum type { spell, game } // מגדיר משתנה שיעזור להבין האם לעבוד מול מילים לאיות או מילים למשחק
    class WordRepository
    {
        private static string GAME_FILE_NAME = WelcomePage.GAME_FILE_NAME;
        private static string SPELL_FILE_NAME = WelcomePage.SPELL_FILE_NAME;
        private static Dictionary<string, WordImageData> GameWords = new Dictionary<string, WordImageData>();
        private static List<WordWSpelling> SpellWords = new List<WordWSpelling>();
        private static int WordCounter = 0;


        // מקבל כפרמטר על איזה אוסף להסתכל (איות או משחקים)
        // קורא את הנתונים מהאוסף הרצוי לתוך הרשימה/מילון המתאימים
        public static void ReadFromFile(int t)
        {
            string file = SPELL_FILE_NAME;
            if (t==(int)type.game)
            {
                file = GAME_FILE_NAME;
            }
            
            using (StreamReader sr = new StreamReader(file))
            {
                string str = null;
                while ((str = sr.ReadLine()) != null)
                {
                    string[] fieldArr = str.Split(';');
                    if(t==(int)type.game)
                    {
                        ReadToGames(fieldArr);
                    }
                    else
                    {
                        ReadToSpell(fieldArr);
                    }
                    WordCounter++;

                }
            }
        }

        // מקבל כקלט שורה מתוך הקובץ ומוסיף אותה למילון
        private static void ReadToGames(string[] str)
        {
            List<char> letters = new List<char>();
            for (int j = 4; j < str.Length; j++)
            {
                letters.Add(char.Parse(str[j]));
            }
            WordImageData word = new WordImageData(int.Parse(str[0]), str[1], str[2], str[3], letters);
            GameWords.Add(str[1], word);
        }

        // מקבל כקלט שורה מתוך הקובץ ומוסיף אותה לרשימה
        private static void ReadToSpell(string[] str)
        {
            WordWSpelling word = new WordWSpelling(int.Parse(str[0]), str[1], str[2], str[3], str[4], str[5]);
            SpellWords.Add(word);
        }



        // מקבל 3 פרמטרים של מילה למשחק, בונה מהם אובייקט מילה למשחק, בודק האם המילה קיימת
        // אם המילה קיימת, זורקים חריגה
        // אם לא, הופכים את הנתונים לשורת טקסט עם נקודה פסיק מפרידים, מוסיפים את השורה לקובץ המידע
        //  ומעתיקים את קבצי הסאונד והתמונה לתיקיות שלהם
        public static void AddToGame(string wordValue, string image, string voice)
        {
            List<char> letters = wordValue.ToCharArray().ToList<char>();
            WordImageData word = new WordImageData(WordCounter+1, wordValue.ToLower(), Path.GetFileName(image), Path.GetFileName(voice), letters);
            if (Exists(word))
            {
                throw new Exception("Word already exists!");
            }
            string newword = word.Number.ToString() + ';' + word.WordValue + ';' + word.Image + ';' + word.Voice;
            for(int i = 0; i < letters.Count; i++)
            {
                newword += ";" + letters[i].ToString();
            }
            string gamepath = Directory.GetCurrentDirectory();
            File.Copy(voice, gamepath + "/VOICE/" + word.Voice, true);
            File.Copy(image, gamepath + "/DIMAGES/" + word.Image, true);

            File.AppendAllText(GAME_FILE_NAME, newword + '\n');
            WordCounter++;

        }

        // כנ"ל כמו מקודם, רק בגרסא של מילה לאיות
        public static void AddToSpell(string wordValue, string voice, string wrong1, string wrong2, string wrong3)
        {
            WordWSpelling word = new WordWSpelling(WordCounter+1, wordValue.ToLower(), Path.GetFileName(voice), wrong1, wrong2, wrong3);
            if (Exists(word))
            {
                throw new Exception("Word already exists!");
            }
            string newword = word.Number.ToString() + ';' + word.WordValue + ';' + word.Voice + ';' + word.Wrong1 + ';' + word.Wrong2 + ';' + word.Wrong3;
            string gamepath = Directory.GetCurrentDirectory();
            File.Copy(voice, gamepath + "/VOICE/" + word.Voice,true);
            File.AppendAllText(SPELL_FILE_NAME, newword + '\n');
            WordCounter++;
        }


        // בודק האם מילה למשחק כבר קיימת
        public static bool Exists(WordImageData word)
        {
             return GameWords.ContainsKey(word.WordValue);
        }

        // בודק האם מילה לאיות כבר קיימת
        public static bool Exists(WordWSpelling word)
        {
            for(int i = 0; i < SpellWords.Count; i++)
            {
                if(SpellWords[i].CompareTo(word)==1)
                {
                    return true;
                }
            }
            return false;
        }

        // איפוס המשתנים לאחר הוספה
        public static void destroy()
        {
            GameWords.Clear();
            SpellWords.Clear();
            WordCounter = 0;
        }
        
    }
}
