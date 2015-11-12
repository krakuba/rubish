using System.Collections.Generic;

namespace Generics
{
    public class GenericsList<TList> where TList : ChainOfResponsibility
    {
        protected TList[] tablica = new TList[10];


        public void Add(TList item)
        {
            tablica[1] = item;
            item.Handler();
        }

        public TList[] ToList()
        {
            return tablica;
        }

        protected List<TList> p = new List<TList>();
        //hashmapa (słownik key,value):
        protected Dictionary<int, string> slownik = new Dictionary<int, string>
        {
            {1, "assa"},
            {2, "dass"},
            {2, "asda"},
        };
        

    }
}
