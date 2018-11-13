using System;
using System.Text.RegularExpressions;

namespace Palindromes {

    public class PalindromeChecker
    {
        private string EnteredString;

        public PalindromeChecker(string enteredString)
        {
            EnteredString = enteredString;
        }

        public bool IsPalindrome()
        {
            string enteredStringLowerCase = EnteredString.ToLower();
            string regex = @"[^a-zA-Z]";
            string replaceWith = "";

            string enteredStringNoSpaces = Regex.Replace(EnteredString, regex, replaceWith);

            Console.WriteLine(enteredStringNoSpaces);

            string enteredStringReversed = "";

            for (int index = enteredStringNoSpaces.Length; index > 0; index--)
            {
                enteredStringReversed += enteredStringNoSpaces[index-1];
            }

            if (enteredStringNoSpaces == enteredStringReversed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
