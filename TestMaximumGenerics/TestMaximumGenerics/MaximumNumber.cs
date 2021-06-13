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

    }
}
