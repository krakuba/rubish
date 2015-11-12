using Microsoft.VisualStudio.TestTools.UnitTesting;
using Generics;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Tests
{
    [TestClass()]
    public class TestGenericTests
    {
        [TestMethod()]
        public void TestTest()
        {

             var obiekty = new Dictionary<int, string>
            {
                {1, "opel"},
                {2, "opel"},
                {3, "audi"},
                {4, "prosche"},
            };

            foreach (var item in obiekty)
            {
                Factory.CreateInstanceCarDelegate(item.Value);
                Debug.WriteLine("Stworzono obiekt: " + item.Value);

                
            }
        }
    }
}