
using System;
using System.Collections.Generic;

namespace Assignment
{
    public class StudentSolution
    {
        #region Lecture

        // LCT01: Recursive Factorial
        public int LCT01_RecursiveFactorial(int n)
        {
            return Factorial(n);
        }

        private int Factorial(int n)
        {
            // Base case
            if (n <= 1) return 1;

            // Recursive case
            return n * Factorial(n - 1);
        }

        // LCT02: Recursive Fibonacci
        public int LCT02_RecursiveFibonacci(int n)
        {
            return Fibonacci(n);
        }

        private int Fibonacci(int n)
        {
            // Base case
            if (n <= 1) return n;

            // Recursive case
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        // LCT03: Recursive Sum Of One To N
        public int LCT03_RecursiveSumOfOneToN(int n)
        {
            return SumOfOneToN(n);
        }

        private int SumOfOneToN(int n)
        {
            // Base case
            if (n <= 0) return 0;

            // Recursive case
            return n + SumOfOneToN(n - 1);
        }

        // LCT04: Recursive Sum Of Numbers
        public int LCT04_RecursiveSumOfNumbers(int[] numbers)
        {
            if (numbers == null) return 0;

            return SumOfNumbers(numbers, 0);
        }

        private int SumOfNumbers(int[] numbers, int index)
        {
            // Base case
            if (index >= numbers.Length) return 0;

            // Recursive case
            return numbers[index] + SumOfNumbers(numbers, index + 1);
        }

        #endregion

        #region Assignment

        // ASN01: Recursive Power
        public int ASN01_RecursivePower(int baseNum, int exponent)
        {
            return Power(baseNum, exponent);
        }

        private int Power(int baseNum, int exponent)
        {
            // Base case
            if (exponent == 0) return 1;

            // Negative exponent is not supported by integer result
            if (exponent < 0) return 0;

            // Recursive case
            return baseNum * Power(baseNum, exponent - 1);
        }

        // ASN02: Is Palindrome
        public bool ASN02_IsPalindrome(string str)
        {
            if (str == null) return false;

            return IsPalindrome(str, 0, str.Length - 1);
        }

        private bool IsPalindrome(string str, int start, int end)
        {
            // Base case
            if (start >= end) return true;

            // Check characters
            if (str[start] != str[end]) return false;

            // Recursive case
            return IsPalindrome(str, start + 1, end - 1);
        }

        // ASN03: Recursive GCD
        public int ASN03_RecursiveGCD(int a, int b)
        {
            return GCD(Math.Abs(a), Math.Abs(b));
        }

        private int GCD(int a, int b)
        {
            // Base case
            if (b == 0) return a;

            // Recursive case
            return GCD(b, a % b);
        }

        // ASN04: Recursive Binary Search
        public int ASN04_RecursiveBinarySearch(int[] arr, int target)
        {
            if (arr == null || arr.Length == 0) return -1;

            return BinarySearch(arr, target, 0, arr.Length - 1);
        }

        private int BinarySearch(int[] arr, int target, int low, int high)
        {
            // Base case: Not found
            if (low > high) return -1;

            // Find middle
            int mid = low + (high - low) / 2;

            // Found target
            if (arr[mid] == target) return mid;

            // Search left
            if (target < arr[mid])
            {
                return BinarySearch(arr, target, low, mid - 1);
            }

            // Search right
            return BinarySearch(arr, target, mid + 1, high);
        }

        #endregion
    }
}
