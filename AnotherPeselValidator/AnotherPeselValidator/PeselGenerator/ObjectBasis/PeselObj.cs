using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using AnotherPeselValidator.ObjectBasis;
using AnotherPeselValidator.PeselGenerator.Interfaces;

namespace AnotherPeselValidator
{
    public class PeselObj : IPeselGenerator
    {
        public string PeselNum; // { get; set; }
        private static Random rnd = new Random();
        private int randomYear = rnd.Next(1, 100);
        private int randomMonth = rnd.Next(1, 13);
        public string DateOfBirth;


        public string GeneratingDateOfBirth()
        {
            //Generating year
            if (randomYear < 10)
            {
                DateOfBirth = "0" + randomYear;
            }
            else
            {
                DateOfBirth = randomYear.ToString();
            }
            //Generating month
            if (randomMonth < 10)
            {
                DateOfBirth = DateOfBirth + "0" + randomYear;
            }
            else
            {
                DateOfBirth = DateOfBirth + randomYear;
            }
            //Generating day
            if (randomMonth % 2 != 0 || randomMonth != 7)
            {
                DateOfBirth = DateOfBirth + rnd.Next(1, 32);
                if (DateOfBirth.Length == 6)
                {
                    return DateOfBirth;
                }
                    return DateOfBirth.Insert(4, "0");
            }
        
            if (randomMonth % 2 == 0 || randomMonth != 2)
            {
                DateOfBirth = DateOfBirth + rnd.Next(1, 30);
                if (DateOfBirth.Length == 6)
                {
                    return DateOfBirth;
                }
                return DateOfBirth.Insert(4, "0");
            }

                DateOfBirth = DateOfBirth + rnd.Next(1, 28);
                if (DateOfBirth.Length == 6)
                {
                    return DateOfBirth;
                }
                return DateOfBirth.Insert(4, "0");

        }

        public string GeneratingPeselNumbers()
        {
            this.GeneratingDateOfBirth();
            return DateOfBirth = DateOfBirth + rnd.Next(9, 100) + rnd.Next(9, 100); /* + rnd.Next(0,
                GetAnyNumber.GetAnyDigitFromPesel(DateOfBirth, 0, 1) +
                3 * GetAnyNumber.GetAnyDigitFromPesel(DateOfBirth, 1, 1) +
                7 * GetAnyNumber.GetAnyDigitFromPesel(DateOfBirth, 2, 1) +
                9 * GetAnyNumber.GetAnyDigitFromPesel(DateOfBirth, 3, 1) +
                GetAnyNumber.GetAnyDigitFromPesel(DateOfBirth, 4, 1) +
                3 * GetAnyNumber.GetAnyDigitFromPesel(DateOfBirth, 5, 1) +
                7 * GetAnyNumber.GetAnyDigitFromPesel(DateOfBirth, 6, 1) +
                9 * GetAnyNumber.GetAnyDigitFromPesel(DateOfBirth, 7, 1) +
                GetAnyNumber.GetAnyDigitFromPesel(DateOfBirth, 8, 1) +
                3 * GetAnyNumber.GetAnyDigitFromPesel(DateOfBirth, 9, 1) % 10
                );  */

        }
    }
}
