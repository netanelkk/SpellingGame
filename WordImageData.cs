using System;
using System.Collections.Generic;

namespace SpellingGame
{
    /*
     מחלקת מילה למשחק
    יורשת את חלק מהתכונות ממחלקת מילה, ובנוסף מכילה:
    letters - רשימה של האותיות של המילה
    image - שם הקובץ של התמונה של המילה
     */
    class WordImageData:Word, IComparable<WordWSpelling>
    {
        List<char> letters;
        string image;

        public List<char> Letters { get { return letters; } set { letters = value; } }
        public string Image { get { return image; } set { image = value; } }
        public WordImageData(int number, string word, string image, string voice, List<char> letters) : base(number, word, voice)
        {
            Image = image;
            Letters = letters;
        }


        // משווה בין זוג מילים, מחזירה 1 אם 2 המילים זהות, אחרת 0
        public int CompareTo(WordWSpelling other)
        {
            if (WordValue.Equals(other.WordValue))
            {
                return 1;
            }

            return 0;
        }
    }
}
