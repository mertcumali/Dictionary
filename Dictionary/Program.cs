using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> Plates = new MyDictionary<int, string>();
            Plates.Add(35, "İzmir");
            Plates.Add(34, "İstanbul");
            Plates.Add(06, "Ankara");
            Plates.Add(16, "Bursa");
            Console.WriteLine(Plates.Count);
        }
    }
}
