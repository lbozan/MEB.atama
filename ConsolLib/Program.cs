using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            Run run = new Run();

            run.Listeler();
            Console.ReadLine();
            run.Atama();
            run.AtananListesi();

            Console.ReadLine();
            run.AtamaListKontrol();
            Console.ReadLine();
        }
    }
}
