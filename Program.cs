using System;

namespace EnglishRussianDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary dictionary = new Dictionary();

            dictionary.AddWord(new Word("Family","Семья"));
            dictionary.AddWord(new Word("Love", "Любовь"));
            dictionary.AddWord(new Word("Children", "Дети"));

            Console.WriteLine(dictionary["Family"]);
        }
    }
}
