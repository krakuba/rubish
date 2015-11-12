using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnotherPeselValidator.ObjectBasis;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AnotherPeselValidator.ObjectBasis.Tests
{
    [TestClass()]
    public class PeselTests2
    {
        [TestMethod()]
        public void PeselTestTwo()
        {
            List<Pesel> listPeselObjs = new List<Pesel>
            {
                new Pesel(){PeselNumber = "92101004612"},
                new Pesel(){PeselNumber = "17122308444"},
                new Pesel(){PeselNumber = "51091309625"},
                new Pesel(){PeselNumber = "77017777712"},
                new Pesel(){PeselNumber = "32322323211"},
                new Pesel(){PeselNumber = "77017777712"},
                new Pesel(){PeselNumber = "77017777712"},
                new Pesel(){PeselNumber = "44042218957"},
                new Pesel(){PeselNumber = "57072417588"},
                new Pesel(){PeselNumber = "49082810875"}
            };

            PeselObjectGen p1Gen = new PeselObjectGen();

            PeselCheck peselCheck = new PeselCheck();

            foreach (var p in listPeselObjs)
            {
                peselCheck.CheckPesel(p);
                if (peselCheck.CheckPesel(p))
                {
                    Debug.WriteLine("Pesel o numerze" + p.PeselNumber + "jest prawidłowy ~~~~~~~" + peselCheck.CheckPesel(p));
                }
                else
                {
                    Debug.WriteLine("Pesel o numerze" + p.PeselNumber + "jest niepoprawny ~~~~~~" + peselCheck.CheckPesel(p));
                }
            }
            }

        }
    }
