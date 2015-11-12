using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnotherPeselValidator.Interfaces;

namespace AnotherPeselValidator.ObjectBasis
{
    public class PeselCheck
    {

        public bool CheckPesel(Pesel p)
        {
            if (CheckBirthDay(p) && CheckBirthMonth(p) && CheckControlSum(p))
            {
                return true;
            }
            return false;
        }

        public bool CheckBirthDay(Pesel p)
        {
            if (GetAnyNumber.GetBirthDay(p) <= 31)
            {
                return true;
            }
            return false;
        }

        public bool CheckBirthMonth(Pesel p) {
            if (GetAnyNumber.GetBirthMonth(p) <= 12)
            {
                return true;
            }
            if (GetAnyNumber.GetBirthMonth(p) <= 32)
            {
                if (GetAnyNumber.GetBirthYear(p) <= 15)
                {
                    return true;
                }
                return false;
            }
            return false;
        }

        public bool CheckControlSum(Pesel p)
        {
            // a+3b+7c+9d+e+3f+7g+9h+i+3j+k
            /* var controlSum =
                 (GetAnyNumber.GetAnyDigitFromPesel(p, 0, 1) +
                 3*GetAnyNumber.GetAnyDigitFromPesel(p, 1, 1) +
                 7*GetAnyNumber.GetAnyDigitFromPesel(p, 2, 1) +
                 9*GetAnyNumber.GetAnyDigitFromPesel(p, 3, 1) +
                 GetAnyNumber.GetAnyDigitFromPesel(p, 4, 1) +
                 3*GetAnyNumber.GetAnyDigitFromPesel(p, 5, 1) +
                 7*GetAnyNumber.GetAnyDigitFromPesel(p, 6, 1) +
                 9*GetAnyNumber.GetAnyDigitFromPesel(p, 7, 1) +
                 GetAnyNumber.GetAnyDigitFromPesel(p, 8, 1) +
                 3*GetAnyNumber.GetAnyDigitFromPesel(p, 9, 1) +
                 GetAnyNumber.GetAnyDigitFromPesel(p, 10, 1)); */

            if (
                (GetAnyNumber.GetAnyDigitFromPesel(p, 0, 1) +
                 3 * GetAnyNumber.GetAnyDigitFromPesel(p, 1, 1) +
                 7 * GetAnyNumber.GetAnyDigitFromPesel(p, 2, 1) +
                 9 * GetAnyNumber.GetAnyDigitFromPesel(p, 3, 1) +
                 GetAnyNumber.GetAnyDigitFromPesel(p, 4, 1) +
                 3 * GetAnyNumber.GetAnyDigitFromPesel(p, 5, 1) +
                 7 * GetAnyNumber.GetAnyDigitFromPesel(p, 6, 1) +
                 9 * GetAnyNumber.GetAnyDigitFromPesel(p, 7, 1) +
                 GetAnyNumber.GetAnyDigitFromPesel(p, 8, 1) +
                 3 * GetAnyNumber.GetAnyDigitFromPesel(p, 9, 1) +
                 GetAnyNumber.GetAnyDigitFromPesel(p, 10, 1))
                 % 10 == 0
                )
            {
                return true;
            }
            return false;
        }

    }
}