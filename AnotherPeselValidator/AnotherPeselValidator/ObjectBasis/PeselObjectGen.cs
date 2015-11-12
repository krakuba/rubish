using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using AnotherPeselValidator.Interfaces;

namespace AnotherPeselValidator.ObjectBasis
{
    public class PeselObjectGen
    {
        /*
        public void Generate(long[] arr)
        {
            foreach (int num in arr)
            {
                Pesel p1 = new Pesel(num);
            }
        }
        
        private static string[] lines = File.ReadAllLines(@"c:\pesele.txt");
       
        public static void AddingPeselFromFile(string[] lines)
        {
            foreach (var line in lines)
            {
               Dictionary<int, string> sttDictionary = new Dictionary<int, string>();
                
                 
            }
        }
        */

        public static List<string> PeselList = new List<string>
        {
            {"92101004612" },
            {"28031319252" },
            {"99990909809" },
            {"11111111111111" },
            {"32323232323" },
            {"asd32dasf32434" }
        };
        /*
        List<PeselObj> listPeselObjs = new List<PeselObj>
            {
                new PeselObj(){PeselNum = "92101004612"},
                new PeselObj(){PeselNum = "17122308444"},
                new PeselObj(){PeselNum = "51091309625"},
                new PeselObj(){PeselNum = "77017777712"},
                new PeselObj(){PeselNum = "32322323211"},
                new PeselObj(){PeselNum = "77017777712"},
                new PeselObj(){PeselNum = "777sasas712"},
                new PeselObj(){PeselNum = "44042218957"},
                new PeselObj(){PeselNum = "57072417588"},
                new PeselObj(){PeselNum = "49082810875"}
            };
            */
        public void PeselGenMethod(List<string> PeselList)
        {
            foreach (var p in PeselList)
            {
                //new Pesel(p);
            }
        }


    }
} ;