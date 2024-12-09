/*
# Name: Drew Wolfe
# email: wolfeaw@mail.uc.edu
# Assignment Title: Assignment Final Project
# Due Date: 12/10/24
# Course: IS 3050
# Semester/Year: Fall 2024
# Brief Description: This class solves a leetcode problem
# Citations: https://leetcode.com/problems/reducing-dishes/ https://chatgpt.com/
# Anything else that's relevant:
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace NeotericNighthawks_FinalProject

{
    public class wolfeaw

    {
        public int MaxSatisfaction(int[] satisfaction)

        {
            Array.Sort(satisfaction);
            Array.Reverse(satisfaction);
            int maxSatisfaction = 0;
            int currentSum = 0;
            int total = 0;


            foreach (int sat in satisfaction)
            {
                total += sat;
                if (total > 0)
                {
                    currentSum += total;
                    maxSatisfaction = currentSum;
                }
                else
                {
                    break;
                }
            }
            return maxSatisfaction;
        }
    }
}