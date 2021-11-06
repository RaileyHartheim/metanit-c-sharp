using System;

namespace indexers_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary dict = new Dictionary();
            Console.WriteLine(dict["blue"]);
            dict["blue"] = "голубой";
            Console.WriteLine(dict["blue"]);


            Console.ReadKey();

        }
    }

    class Word
    {
        public string Source { get; }
        public string Target { get; set; }

        public Word(string source, string target)
        {
            Source = source;
            Target = target;
        }
    }

    class Dictionary
    {
        Word[] words;

        public Dictionary()
        {
            words = new Word[]
            {
                new Word("red", "красный"),
                new Word("blue", "синий"),
                new Word("green", "зеленый")
            };
        }

        public string this[string source]
        {
            get
            {
                Word word = null;
                foreach (Word w in words)
                {
                    if (w.Source == source)
                    {
                        word = w;
                        break;
                    }
                }
                return word?.Target;
            }
            set
            {
                foreach (var w in words)
                {
                    if (w?.Source == source)
                    {
                        w.Target = value;
                        break;
                    }
                }
            }
        }
    }
}
