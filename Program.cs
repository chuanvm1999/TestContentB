using System;
using System.Text.RegularExpressions;

// Program to check if a given string is a palindrome
public class Program
{
    /// <summary>
    /// Checks if a given string is a palindrome.
    /// </summary>
    /// <param name="str">The input string to evaluate.</param>
    /// <returns>True if the string is a palindrome, otherwise False.</returns>
    public static bool IsPalindrome(string str)
    {
        // Remove non-alphanumeric characters and convert the string to lowercase.
        str = new string(str.ToLower().Where(char.IsLetterOrDigit).ToArray());

        // Base case: A string with zero or one character is always a palindrome.
        return str.Length <= 1
            ? true
            : str[0] != str[str.Length - 1] // Compare the first and last characters.
                ? false
                : IsPalindrome(str.Substring(1, str.Length - 2)); // Recursively evaluate the substring.
    }
}
