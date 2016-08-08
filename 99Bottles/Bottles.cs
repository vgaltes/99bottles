namespace _99Bottles
{
    public class Bottles
    {
        public string Verse(int verseNumber)
        {
            return $"{verseNumber} bottles of beer on the wall, " +
                   $"{verseNumber} bottles of beer.\n" +
                   "Take one down and pass it around, " +
                   $"{verseNumber - 1} bottle of beer on the wall.\n";
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