using System.Collections.Generic;
using System.Linq;

namespace SINValidator.Extensions
{
    public static class IntExtension
    {
        public static IEnumerable<int> ToDigitEnumerable(this int number)
        {
            IList<int> digits = new List<int>();

            while (number > 0)
            {
                digits.Add(number % 10);
                number = number / 10;
            }

            //digits are currently backwards, reverse the order
            return digits.Reverse();
        }
    }
}
