using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnotherPeselValidator.ObjectBasis.Tests
{
    [TestClass]
    public class TestClass3ForGenerator
    {
        [TestMethod]
        public void TestForGenerator()
        {
            List<PeselObj> p1List = new List<PeselObj>
            { 
            new PeselObj(),
            new PeselObj(),
            new PeselObj(),
            new PeselObj(),
            new PeselObj(),
            };

            foreach (var pe in p1List)
            {

                Debug.WriteLine(pe.GeneratingRestOfPeselNumbers());
            }
        }

         
    }
}