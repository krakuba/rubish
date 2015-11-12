using System;
using System.Collections.Generic;
using System.Diagnostics;


namespace Generics
{
    public class TestGeneric
    {
        public void Test()
        {
            //GenericsList<string> obiekt = new GenericsList<string>();
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

};
