using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpellingGame
{
    /*
     מחלקת מילה לאיות, היורשת את חלק מהתכונות ממחלקת מילה
    wrong - רשימה שמכילה את הוריאציות של המילה
     */
    class WordWSpelling : Word, IComparable<WordWSpelling>
    {
        List<string> wrong;

        public string Wrong1 { get { return wrong[0]; } set { wrong[0] = value; } }
        public string Wrong2{ get { return wrong[1]; } set { wrong[1] = value; } }
        public string Wrong3 { get { return wrong[2]; } set { wrong[2] = value; } }

        public WordWSpelling(int number, string word, string voice,string wrong1,string wrong2,string wrong3) : base(number,word,voice)
        {
            wrong = new List<string>();
            wrong.Add(wrong1);
            wrong.Add(wrong2);
            wrong.Add(wrong3);
        }

        // משווה בין 2 מילים, מילה נחשבת זהה אם המילה והוריאציות שלה זהות
        public int CompareTo(WordWSpelling other)
        {
            if (WordValue.Equals(other.WordValue) &&
                wrong.Contains(other.Wrong1) &&
                wrong.Contains(other.Wrong2) &&
                wrong.Contains(other.Wrong3))
            {
                return 1;
            }

            return 0;
        }


    }
}
