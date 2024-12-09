/* 
# Name:Richie James
# email: James2c4@mail.uc.edu
# Assignment Title: Final Project
# Due Date: 12/10/24
# Course: IS 3050
# Semester/Year:Fall 2024
# Brief Description: Interger to word Converter
# Citations: https://leetcode.com/problems/integer-to-english-words/description/
# Anything else that's relevant:
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace NeotericNighthawks_FinalProject
{
    public partial class index : System.Web.UI.Page
    {
        // Arrays for number words
        private static readonly string[] ones = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        private static readonly string[] tens = { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        private static readonly string[] thousands = { "", "thousand", "million", "billion", "trillion", "quadrillion", "quintillion" };

        // Function to convert a number less than 1000 to words
        private static string ConvertHundreds(int num)
        {
            StringBuilder result = new StringBuilder();

            if (num >= 100)
            {
                result.Append(ones[num / 100] + " hundred ");
                num %= 100;
            }

            if (num >= 20)
            {
                result.Append(tens[num / 10] + " ");
                num %= 10;
            }

            if (num > 0)
            {
                result.Append(ones[num] + " ");
            }

            return result.ToString();
        }

        // Main function to convert integer to words
        public static string NumberToWords(long num)
        {
            if (num == 0)
                return "zero";

            StringBuilder words = new StringBuilder();
            int thousandCounter = 0;

            // Process every 3 digits (i.e., every thousand group)
            while (num > 0)
            {
                if (num % 1000 != 0)
                {
                    words.Insert(0, ConvertHundreds((int)(num % 1000)) + thousands[thousandCounter] + " ");
                }
                num /= 1000;
                thousandCounter++;
            }

            // Trim the trailing space
            return words.ToString().Trim();
        }

        // Button click event to convert integer to words
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the input integer from the TextBox
                long num = long.Parse(txtInt.Text);

                // Convert number to words and display the result in the Label
                Wrd.Text = NumberToWords(num);
            }
            catch (FormatException)
            {
                // Handle invalid input
                Wrd.Text = "Please enter a valid integer.";
            }
        }
    }

};