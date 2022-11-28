using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            var count = vals.Length;

            return count % 2 == 0;
        }

        public bool IsNumberEven(int number)// do i have to define the number first? 
        {
            return number % 2 == 0;
        }
        

        public bool IsNumberOdd(int num)// or if number1 % number2 != 0 then true, else, false?
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)// math. add min + max= sum?
        {
            var min = numbers.Min();
            var max = numbers.Max();

            return min + max;
        }

        public int GetLengthOfShortestString(string str1, string str2)// phrase. length ??googled this answer.
        {
            var str1Length = str1.Length;
            var str2Length = str2.Length;

            return str1Length < str2Length ? str1Length : str2Length;
        }
        
        public int Sum(int[] numbers)// simply math.add int + int = sum????
        {
            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }

        public int SumEvens(int[] numbers) // no idea - I googled
        {
            //return numbers
            //    .Where(number => number % 2 == 0)
            //    .Sum();

            var sum = 0;
            foreach (var number in numbers)
            {
                if (number % 2 == 0) 
                {
                    sum += number;
                }
            }

            return sum;
        }

        public bool IsSumOdd(List<int> numbers) // my best guess
        {
            var sum = numbers.Sum();

            return sum % 2 != 0;
        }

        public long CountOfPositiveOddsBelowNumber(long number)// got help from google
        {
            var count = 0;
            for (var i = 0; i < number; i++)
            {
                if (i % 2 != 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
