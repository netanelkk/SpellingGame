using System;
using System.Collections.Generic;
using System.Linq;

namespace SpellingGame
{

    /*
     מחלקת מילה, המכינה מאפיינים משותפים למילים לאיות ומילים למשחק
    number - מספר מזהה של המילה
    wordvalue - המילה
    voice - שם הקובץ של הסאונד של המילה
     */
    class Word
    {
        int number;
        string wordvalue;
        string voice;
        public int Number { get { return number; } set { number = value; } }
        public string WordValue { get { return wordvalue; } set { wordvalue = value; } }
        public string Voice { get { return voice; } set { voice = value; } }
        public Word(int number, string word, string voice)
        {
            Number = number;
            WordValue = word;
            Voice = voice;
        }
    }
}
