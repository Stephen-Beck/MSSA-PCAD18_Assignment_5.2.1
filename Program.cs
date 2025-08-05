/*
Given a string s consisting of words and spaces, return the length of the last word in the string. 
A word is a maximal substring consisting of non-space characters only.

Example 1:
    Input: s = "Hello World"
    Output: 5
    Explanation: The last word is "World" with length 5.

Example 2:
    Input: s = " fly me to the moon "
    Output: 4
    Explanation: The last word is "moon" with length 4. 
*/

namespace Assignment_5._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int testCount = 0;
            string lastWord = "";
            int lastWordLength = 0;

            string s = "Hello World";
            Console.WriteLine($"\nTest {++testCount}: s = \"{s}\"");
            (lastWord, lastWordLength) = LastWordLength(s);
            DisplayResult(lastWord, lastWordLength);

            s = " fly me to the moon ";
            Console.WriteLine($"\nTest {++testCount}: s = \"{s}\"");
            (lastWord, lastWordLength) = LastWordLength(s);
            DisplayResult(lastWord, lastWordLength);

            s = " "; // edge case where a single space is used
            Console.WriteLine($"\nTest {++testCount}: s = \"{s}\"");
            (lastWord, lastWordLength) = LastWordLength(s);
            DisplayResult(lastWord, lastWordLength);

            s = ""; // edge case where an empty string is used
            Console.WriteLine($"\nTest {++testCount}: s = \"{s}\"");
            (lastWord, lastWordLength) = LastWordLength(s);
            DisplayResult(lastWord, lastWordLength);
        }

        static (string, int) LastWordLength(string s)
        {
            // Make sure string has at least one "word"
            if (s.Trim().Length == 0)
                return ("N/A", 0);

            // Get last word of string
            string[] sArray = s.Trim().Split(" ");

            // Return last word and length of last word
            return (sArray[sArray.Length - 1], sArray[sArray.Length - 1].Length);
        }

        static void DisplayResult(string lastWord, int lastWordLength)
        {
            if (lastWordLength == 0) // if there was no word
                Console.WriteLine("There were no non-space characters in the given string!");
            else // if there was a word
                Console.WriteLine($"The last word is \"{lastWord}\" with a length of {lastWordLength}.");
        }
    }
}
