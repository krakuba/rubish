using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Generics
{
    public static class Factory
    {
        //tutaj jakaś prymitywna fabryka

        public static ICar CreateCar(string name)
        {
            switch (name)
            {
                case "Porsche":
                    return new Porsche();
                case "Opel":
                    return new Opel();
                default:
                    return new Audi();
            }
        }

        //troche lepsza fabryka
         
       private static Dictionary<string, ICar> _carList = new Dictionary<string, ICar>
       {
           {"porsche", new Porsche() },
           {"opel", new Opel() },
           {"audi", new Audi() },


       };

        public static ICar CreateInstanceCar(string text)
        {
            return _carList.ContainsKey(text) ? _carList[text] : null;
        }

        //jeszcze lepsza

        private static Dictionary<string, Func<ICar>> _carListDelegate = new Dictionary<string, Func<ICar>>
       {
           {"porsche", () => new Porsche() },
           {"opel", () => new Opel() },
           {"audi", () => new Audi() },


       };

        public static ICar CreateInstanceCarDelegate (string text)
        {
            return _carListDelegate.ContainsKey(text) ? _carListDelegate[text]() : null;
            // Debug.WriteLine("Stworzono obiekt"+text);
        }

    }
}