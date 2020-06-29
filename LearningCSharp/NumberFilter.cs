using System;
using System.Collections.Generic;

namespace LearningCSharp
{
    // create a class that extends System.MulticastDelegate
    // that can refer to any method that takes an int and return a bool
    public delegate bool FilterMethod(int num);

    public class NumberFilter
    {
        public List<int> FilterOutEvens(List<int> numbers)
        {
            // return Filter(numbers, isOdd);
            // C# 1.0 Create an instance of the delegate manually
            //var op = new FilterMethod(isOdd);
            //return Filter(numbers, op);
            // C# 2.20 Anonymous Method
            //return Filter(numbers, delegate (int x)
            //{
            //    return x % 2 != 0;
            //});
            // C# 3.0 Lambdas
            return Filter(numbers, n => n % 2 != 0);
        }

        public List<int> FilterOutOdds(List<int> numbers)
        {

            return Filter(numbers, isEven);
        }
        public List<int> Filter(List<int> numbers, FilterMethod op)
        {
            var result = new List<int>();
            foreach (var num in numbers)
            {
                if (op.Invoke(num))
                {
                    result.Add(num);
                }
            }
            return result;
        }

        private bool isOdd(int num)
        {
            return num % 2 != 0;
        }

        private bool isEven(int num)
        {
            return num % 2 == 0;
        }
    }
}