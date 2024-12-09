/*
# Name: Kengo Ishizuka
# email: ishizuko@mail.uc.edu
# Assignment Title:Final Project
# Due Date: 12/10/2024
# Course: IS 3050
# Semester/Year: Fall 2024
# Brief Description: This project is the final project that emonstrate a mastery of basic C# programming and ASP.Net web sites.
# Citations: https://leetcode.com/problems/candy/description/  https://chatgpt.com/
# Anything else that's relevant:
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeotericNighthawks_FinalProject
{
    public class ishizuko
    {
        /// <summary>
        /// Distribute candies to n children based on their ratings under conditions below
        ///  -Each child must get a at least one candy
        ///  -A child with a higher rating must get more candies than their naighbors
        /// </summary>
        /// <param name="ratings">input the value of ratings for each child</param>
        /// <returns>Caluculation of minimum amount of candies</returns>
        /// 

        /*   Example to store ratings of children

              static void Main(string[] args)
               {
                   int[] ratings = { 1, 0, 2 }; //  Example to display the result
                   Console.WriteLine(MinimumCandies(ratings));
               }
        */
        static int MinimumCandies(int[] ratings)
        {
            int n = ratings.Length;
            if (n == 0) return 0;

            int[] candies = new int[n];
            // Initialize the array to track the number of candies
            for (int i = 0; i < n; i++)
            {
                candies[i] = 1;// Assign at least 1 candy to each child
            }

            // Scan from left to right
            for (int i = 1; i < n; i++)
            {
                if (ratings[i] > ratings[i - 1])
                {
                    candies[i] = candies[i - 1] + 1;
                }
            }

            // Scan from right to left
            for (int i = n - 2; i >= 0; i--)
            {
                if (ratings[i] > ratings[i + 1])
                {
                    candies[i] = Math.Max(candies[i], candies[i + 1] + 1);
                }
            }

            // Caluculate minimum amount of candies
            int totalCandies = 0;
            foreach (int candy in candies)
            {
                totalCandies += candy;
            }

            return totalCandies;
        }
    }
}