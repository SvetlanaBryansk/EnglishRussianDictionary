namespace EnglishRussianDictionary
{
    class Word
    {
        public string Origin { get; set; }

        public string Translate { get; set; }

        public Word(string origin, string translate)
        {
            Origin = origin;
            Translate = translate;
        }
    }
}

