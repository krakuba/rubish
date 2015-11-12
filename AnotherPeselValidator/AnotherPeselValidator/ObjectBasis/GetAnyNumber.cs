using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnotherPeselValidator.Interfaces;


namespace AnotherPeselValidator.ObjectBasis
{
    public class GetAnyNumber
    {
        /*public static int DayOfBirth;
        public static int MonthOfBirth;
        public static int YearOfBirth;*/

        public static int GetBirthDay(Pesel p)
        {
            var peselString = p.PeselNumber.ToString();
            return Convert.ToInt32(peselString.Substring(4, 2));

        }

        public static int GetBirthMonth(Pesel p)
        {
            var peselString = p.PeselNumber.ToString();
            return Convert.ToInt32(peselString.Substring(2, 2));

        }

        public static int GetBirthYear(Pesel p)
        {
            var peselString = p.PeselNumber.ToString();
            return Convert.ToInt32(peselString.Substring(0, 2));

        }

        public static int GetAnyDigitFromPesel(Pesel p, int startingIndex, int lenghtIndex)
        {
            var peselString = p.PeselNumber.ToString();
            return Convert.ToInt32(peselString.Substring(startingIndex, lenghtIndex));
        }

        public static int GetAnyDigitFromPesel(string p, int startingIndex, int lenghtIndex)
        {
            return Convert.ToInt32(p.Substring(startingIndex, lenghtIndex));
        }
    }
}