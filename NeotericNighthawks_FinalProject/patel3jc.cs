/*
# Name: Jaanvi Patel
# email: patel3jc@mail.uc.edu
# Assignment Title: Final Project
# Due Date: 12/10/24
# Course: IS 3050
# Semester/Year: Fall 2024
# Brief Description: Solves leetcode problem #3374
# Citations: https://leetcode.com/problems/first-letter-capitalization-ii/description/
https://gemini.google.com/app
# Anything else that's relevant: n/a
*/
using System;
using System.Linq;

namespace NeotericNighthawks_FinalProject
{
    /// <summary>
    /// Contains logic to solve the First Letter Capitalization II problem.
    /// </summary>
    public class patel3jc
    {
        /// <summary>
        /// Capitalizes the first letter of each word in the input string.
        /// Words with fewer than 3 characters will be converted to lowercase.
        /// </summary>
        /// <param name="input">The input string containing words.</param>
        /// <returns>The processed string with appropriate capitalization applied.</returns>
        public string FirstLetterCapitalization(string input)
        {
            // Check for null or empty input
            if (string.IsNullOrWhiteSpace(input)) return input;

            // Split the input into words
            var words = input.Split(' ');

            // Process each word based on the rules
            var processedWords = words.Select(word =>
            {
                if (word.Length == 0) return word; // Handle empty words
                if (word.Length <= 2)
                {
                    // Convert words with length 2 or less to lowercase
                    return word.ToLower();
                }
                else
                {
                    // Capitalize the first letter and convert the rest to lowercase
                    return char.ToUpper(word[0]) + word.Substring(1).ToLower();
                }
            });

            // Join the words back into a single string with spaces
            return string.Join(" ", processedWords);
        }
    }
}
