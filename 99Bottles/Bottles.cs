namespace _99Bottles
{
    using System.Runtime.InteropServices.WindowsRuntime;

    public class Bottles
    {
        public string Verse(int verseNumber)
        {
            if (verseNumber == 0)
            {
                return "No more bottles of beer on the wall, " +
                           "no more bottles of beer.\n" +
                           "Go to the store and buy some more, " +
                           "99 bottles of beer on the wall.\n";
            }

            var plural = verseNumber > 1 ? "s" : "";
            var nextPlural = verseNumber - 1 != 1 ? "s" : "";
            var nextVerseNumber = verseNumber == 1 ? "no more" : $"{verseNumber - 1}";
            var oneOrIt = verseNumber == 1 ? "it" : "one";

            return $"{verseNumber} bottle{plural} of beer on the wall, " +
                   $"{verseNumber} bottle{plural} of beer.\n" +
                   $"Take {oneOrIt} down and pass it around, " +
                   $"{nextVerseNumber} bottle{nextPlural} of beer on the wall.\n";
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
            throw new System.NotImplementedException();
        }
    }
}