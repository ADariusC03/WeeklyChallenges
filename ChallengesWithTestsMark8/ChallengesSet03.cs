using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            return Array.Exists(vals, elements => elements == false);
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers != null)
            {
                return numbers.Sum() % 2 == 0 ? false : true;
            }
            else
                return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool upper = password.Any(Character => Char.IsUpper(Character));
            bool lower = password.Any(character => Char.IsLower(character));
            bool number = password.Any(character => Char.IsDigit(character));
            return upper && lower && number;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val.First();
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
            return nums.Last() - nums.First();
        }

        public int[] GetOddsBelow100()
        {
            return Enumerable.Range(1, 100).Where(x => x % 2 != 0).ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
