/*
# Name: Neoteric Nighthawks
# email:
# Assignment Title: Assignment Final Project
# Due Date: 12/10/24
# Course: IS 3050
# Semester/Year: Fall 2024
# Brief Description: This project is our final project which solves leetcode problems
# Citations: https://chatgpt.com/
# Anything else that's relevant: n/a
*/
using System;
using System.Collections.Generic;
using System.Web.UI;

namespace NeotericNighthawks_FinalProject
{
    public partial class index : Page
    {
        private readonly Dictionary<string, (string Description, string TestCase, Func<string> Solve)> _problems =
            new Dictionary<string, (string, string, Func<string>)>
            {
                {
                    "Max Satisfaction",
                    (
                        "Calculate the maximum satisfaction from a list of satisfaction levels.",
                        "Input: [-1, -8, 0, 5, -9]",
                        new Func<string>(() =>
                        {
                            var solver = new wolfeaw(); // Replace with actual implementation
                            int result = solver.MaxSatisfaction(new[] { -1, -8, 0, 5, -9 });
                            return $"Output: {result}";
                        })
                    )
                },
                {
                    "Minimum Candies",
                    (
                        "Distribute candies to children based on their ratings under the given conditions.",
                        "Input: [1, 0, 2]",
                        new Func<string>(() =>
                        {
                            int[] ratings = { 1, 0, 2 };
                            var result = (int)typeof(ishizuko).GetMethod("MinimumCandies", System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.NonPublic)
                                .Invoke(null, new object[] { ratings });
                            return $"Output: {result}";
                        })
                    )
                },
                {
                    "First Letter Capitalization",
                    (
                        "Capitalize the first letter of each word in a string. Words with fewer than 3 characters are lowercase.",
                        "Input: 'hello world a is b'",
                        new Func<string>(() =>
                        {
                            var solver = new patel3jc(); // Replace with actual implementation
                            string result = solver.FirstLetterCapitalization("hello world a is b");
                            return $"Output: {result}";
                        })
                    )
                },
                {
                    "Integer to Word Converter",
                    (
                        "Convert an integer to its word representation.",
                        "Input: 123",
                        new Func<string>(() => "Enter a number above to get the word form.")
                    )
                }
            };

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlProblems.Items.Clear();
                foreach (var problem in _problems.Keys)
                {
                    ddlProblems.Items.Add(problem);
                }
            }
        }

        protected void ddlProblems_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Show or hide the integer input row based on the selected problem
            if (ddlProblems.SelectedItem != null)
            {
                rowIntegerInput.Visible = ddlProblems.SelectedItem.Text == "Integer to Word Converter";
            }
        }

        protected void btnSolve_Click(object sender, EventArgs e)
        {
            string selectedProblem = ddlProblems.SelectedItem?.Text;

            if (selectedProblem == "Integer to Word Converter")
            {
                try
                {
                    long num = long.Parse(txtInt.Text);
                    litSolution.Text = LocalNumberToWords(num); // Use local version of NumberToWords
                }
                catch (FormatException)
                {
                    litSolution.Text = "Please enter a valid integer.";
                }
            }
            else if (selectedProblem != null)
            {
                var problemDetails = _problems[selectedProblem];
                litDescription.Text = problemDetails.Description;
                litTestCase.Text = problemDetails.TestCase;
                litSolution.Text = problemDetails.Solve.Invoke();
            }
        }

        private string LocalNumberToWords(long num)
        {
            if (num == 0) return "zero";

            string[] ones = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] tens = { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            string[] thousands = { "", "thousand", "million", "billion" };

            var result = string.Empty;
            var thousandIndex = 0;

            while (num > 0)
            {
                var chunk = num % 1000;
                if (chunk > 0)
                {
                    result = $"{ConvertChunk((int)chunk, ones, tens)} {thousands[thousandIndex]} {result}".Trim();
                }
                num /= 1000;
                thousandIndex++;
            }

            return result.Trim();
        }

        private string ConvertChunk(int num, string[] ones, string[] tens)
        {
            var result = string.Empty;

            if (num >= 100)
            {
                result += $"{ones[num / 100]} hundred ";
                num %= 100;
            }

            if (num >= 20)
            {
                result += $"{tens[num / 10]} ";
                num %= 10;
            }

            if (num > 0)
            {
                result += ones[num];
            }

            return result.Trim();
        }
    }
}
