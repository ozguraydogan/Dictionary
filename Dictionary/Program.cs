using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> cities = new MyDictionary<string, string>();

            cities.Add("34", "İstanbul");
            cities.Add("14", "Bandırma");
            cities.Add("12", "Çanakkale");

            cities.ShowItems();
        }
    }
}
