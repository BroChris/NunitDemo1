using System;
using System.Reflection;
using System.Runtime.Intrinsics.X86;

namespace NunitDemo
{
    public class Calculator
    {
        public int Addition(int firstNumuber, int SecondNumber)
        {
            return firstNumuber + SecondNumber;
           
        }

        public int Subtraction(int firstNumuber, int SecondNumber)
        {
            if (firstNumuber < SecondNumber)
            {
                throw new ArgumentException($"First Number {firstNumuber} is Lesser than the Second Number{SecondNumber}");
            }
            return firstNumuber - SecondNumber;
        }

    }
}
