using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals == null)
            {
                return false;
            }

            foreach (var item in vals)

            {
                if (item == false)
                    return true;
            }
            return false;

            // below is the one - liner. 

            //return vals != null && vals.Length !=0 && vals.Contains (false);    

        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            return numbers != null && numbers.Where(x => x % 2 != 0).Sum() % 2 != 0;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            return password.Any(char.IsNumber)
                && password.Any(char.IsUpper)
                && password.Any(char.IsLower);

            //bool IsLetter = false;
            //bool IsDigit = false;
            //bool IsUpper = false;


            //foreach (var letter in password) ;
            //{
            //    if (char.IsLower(letter))
            //    {
            //        IsLetter = true;
            //    }
            //    if (char.IsDigit(letter))
            //    {
            //        IsDigit = true;
            //    }
            //    if (char.IsUpper(letter))
            //    {
            //        IsUpper = true;
            //    }
            //    return IsLetter && IsDigit && IsUpper;
            //}
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val.Last();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return divisor == 0 ? 0 : dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1];
        }

        public int[] GetOddsBelow100()
        {
            int[] odds = {
                1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25,
                27, 29, 31, 33, 35, 37, 39, 41, 43, 45, 47, 49,
                51, 53, 55, 57, 59, 61, 63, 65, 67, 69, 71, 73,
                75, 77, 79, 81, 83, 85, 87, 89, 91, 93, 95, 97, 99
            };
            return odds;

            public void ChangeAllElementsToUppercase(string[] words)
            {
                for (int i = 0; i < words.Length; i++)
                {
                    words[i] = words[i].ToUpper();
                }

            }

        }
    }
}

