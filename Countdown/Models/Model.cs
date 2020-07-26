using Countdown.ViewModels;
using System;
using System.Collections.Generic;


namespace Countdown.Models
{
    internal class Model
    {
        public const int cMinTarget = 101;
        public const int cMaxTarget = 999;

        public const int cTileCount = 6;
        public const int cLetterCount = 9;

        // letters game model data
        public string[] Letters { get; } = new string[cLetterCount];

        private readonly Random random = new Random();
        // handles word dictionaries
        private readonly WordDictionary wordDictionary = new WordDictionary();

        // solve the letters game
        public List<WordItem> Solve(char[] letters) => wordDictionary.Solve(letters);
        public char GetVowel() => UserSettings.Vowels.GetLetter(random);
        public char GetConsonant() => UserSettings.Consonants.GetLetter(random);
    }
}

