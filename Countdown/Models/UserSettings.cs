namespace Countdown.Models
{
    internal static class UserSettings
    {
        public static LetterList Consonants
        {
            get
            {
                return Settings.Default.ConsonantFrequency;
            }
        }

        public static LetterList Vowels//required
        {
            get
            {

                return Settings.Default.VowelFrequency;
            }
        }


    }
}
