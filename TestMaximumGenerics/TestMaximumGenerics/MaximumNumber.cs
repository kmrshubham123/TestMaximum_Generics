﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TestMaximumGenerics
{
    public class MaximumNumber
    {
        /// <summary>
        /// UC1:-Method to Test the Maximum number using Interger
        /// </summary>
        /// <param int="firstValue"></param>
        /// <param int="secondValue"></param>
        /// <param int="thirdValue"></param>
        /// <returns></returns>
        public  int FindMaximumNumber(int firstValue, int secondValue, int thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && (firstValue.CompareTo(thirdValue) > 0) ||
                firstValue.CompareTo(secondValue) >= 0 && (firstValue.CompareTo(thirdValue) > 0) ||
                firstValue.CompareTo(secondValue) > 0 && (firstValue.CompareTo(thirdValue) >= 0))
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && (secondValue.CompareTo(thirdValue) > 0) ||
                secondValue.CompareTo(firstValue) >= 0 && (secondValue.CompareTo(thirdValue) > 0) ||
                secondValue.CompareTo(firstValue) > 0 && (secondValue.CompareTo(thirdValue) >= 0))
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && (thirdValue.CompareTo(secondValue) > 0) ||
                thirdValue.CompareTo(firstValue) >= 0 && (thirdValue.CompareTo(secondValue) > 0) ||
                thirdValue.CompareTo(firstValue) > 0 && (thirdValue.CompareTo(secondValue) >= 0))
            {
                return thirdValue;
            }
            return firstValue;
        }//End of  int FindMaximumNumber
        /// <summary>
        /// UC2:-Method to Test the Maximum number using Floats
        /// </summary>
        /// <param double="firstValue"></param>
        /// <param double="secondValue"></param>
        /// <param double="thirdValue"></param>
        /// <returns></returns>
        public double FindMaximumFloatNumber(double firstValue, double secondValue, double thirdValue)
        {
            if (firstValue.CompareTo(secondValue) > 0 && (firstValue.CompareTo(thirdValue) > 0) ||
                firstValue.CompareTo(secondValue) >= 0 && (firstValue.CompareTo(thirdValue) > 0) ||
                firstValue.CompareTo(secondValue) > 0 && (firstValue.CompareTo(thirdValue) >= 0))
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && (secondValue.CompareTo(thirdValue) > 0) ||
                secondValue.CompareTo(firstValue) >= 0 && (secondValue.CompareTo(thirdValue) > 0) ||
                secondValue.CompareTo(firstValue) > 0 && (secondValue.CompareTo(thirdValue) >= 0))
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && (thirdValue.CompareTo(secondValue) > 0) ||
                thirdValue.CompareTo(firstValue) >= 0 && (thirdValue.CompareTo(secondValue) > 0) ||
                thirdValue.CompareTo(firstValue) > 0 && (thirdValue.CompareTo(secondValue) >= 0))
            {
                return thirdValue;
            }
            return firstValue;
        }//End of double FindMaximumFloatNumber
        /// <summary>
        /// Method to Test the Longest Word using string
        /// </summary>
        /// <param string="firstString"></param>
        /// <param string="secondString"></param>
        /// <param string="thirdString"></param>
        /// <returns></returns>
        public string FindLongestString(string firstString, string secondString, string thirdString)
        {
            if (firstString.CompareTo(secondString) > 0 && (firstString.CompareTo(thirdString) > 0) ||
                firstString.CompareTo(secondString) >= 0 && (firstString.CompareTo(thirdString) > 0) ||
                firstString.CompareTo(secondString) > 0 && (firstString.CompareTo(thirdString) >= 0))
            {
                return firstString;
            }
            if (secondString.CompareTo(firstString) > 0 && (secondString.CompareTo(thirdString) > 0) ||
                secondString.CompareTo(firstString) >= 0 && (secondString.CompareTo(thirdString) > 0) ||
                secondString.CompareTo(firstString) > 0 && (secondString.CompareTo(thirdString) >= 0))
            {
                return secondString;
            }
            if (thirdString.CompareTo(firstString) > 0 && (thirdString.CompareTo(secondString) > 0) ||
                thirdString.CompareTo(firstString) >= 0 && (thirdString.CompareTo(secondString) > 0) ||
                thirdString.CompareTo(firstString) > 0 && (thirdString.CompareTo(secondString) >= 0))
            {
                return thirdString;
            }
            return firstString;
        }//End of string FindLongestString

    }
}
