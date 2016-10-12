namespace _99Bottles
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.InteropServices;

    public interface IVerse
    {
        string Text { get; }
    }

    public class CommonVerse : IVerse
    {
        private readonly int _numVerse;

        public CommonVerse(int numVerse)
        {
            _numVerse = numVerse;
        }

        public string Text => $"{_numVerse} bottles of beer on the wall, " +
                              $"{_numVerse} bottles of beer.\n" +
                              "Take one down and pass it around, " +
                              $"{_numVerse - 1} bottles of beer on the wall.\n";
    }

    public class VerseTwo : IVerse
    {
        public string Text => $"2 bottles of beer on the wall, " +
                              $"2 bottles of beer.\n" +
                              "Take one down and pass it around, " +
                              $"1 bottle of beer on the wall.\n";
    }

    public class VerseOne : IVerse
    {
        public string Text => "1 bottle of beer on the wall, " +
                              "1 bottle of beer.\n" +
                              "Take it down and pass it around, " +
                              $"no more bottles of beer on the wall.\n";
    }

    public class VerseZero : IVerse
    {
        public string Text => "No more bottles of beer on the wall, " +
                              "no more bottles of beer.\n" +
                              "Go to the store and buy some more, " +
                              "99 bottles of beer on the wall.\n";
    }



    public class Bottles
    {
        private List<IVerse> verses;
         
        public Bottles()
        {
            verses = new List<IVerse> {new VerseZero(), new VerseOne(), new VerseTwo()};

            for (var i = 3; i <= 99; i++)
            {
                verses.Add(new CommonVerse(i));
            }
        }

        public string Verse(int verseNumber)
        {
            return verses.ElementAt(verseNumber).Text;
        }

        public string Verses(int starting, int ending)
        {
            var verses = new string[starting - ending + 1];

            for (var i = starting; i >= ending; i--)
            {
                verses[starting - i] = Verse(i);
            }

            return string.Join("\n", verses);
        }

        public string Song()
        {
            return Verses(99, 0);
        }
    }
}