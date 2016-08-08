namespace _99Bottles
{
    public class Bottles
    {
        public string Verse(int verseNumber)
        {
            var plural = verseNumber > 1 ? "s" : "";
            var nextPlural = verseNumber - 1 > 1 ? "s" : "";
            return $"{verseNumber} bottle{plural} of beer on the wall, " +
                   $"{verseNumber} bottle{plural} of beer.\n" +
                   "Take one down and pass it around, " +
                   $"{verseNumber - 1} bottle{nextPlural} of beer on the wall.\n";
        }

        public string Verses(int starting, int ending)
        {
            throw new System.NotImplementedException();
        }

        public string Song()
        {
            throw new System.NotImplementedException();
        }
    }
}