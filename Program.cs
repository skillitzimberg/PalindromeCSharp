using System;

namespace Palindromes {

    class Program
    {
      public static void Main()
      {
        Console.WriteLine("Enter a word or phrase and I'll check to see if it's a palindrome.");
        string enteredString = Console.ReadLine();

        PalindromeChecker isPalindrome = new PalindromeChecker(enteredString);
        bool result = isPalindrome.IsPalindrome();
        Console.WriteLine(result);
      }
    }
}
