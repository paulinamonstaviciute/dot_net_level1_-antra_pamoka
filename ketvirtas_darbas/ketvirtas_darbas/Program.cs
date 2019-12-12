using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ketvirtas_darbas
{
    class Program
    {
        static void Main(string[] args)
        {
            string mokyklosPavadinimas = "CodeAcademy";
            string kursoPavadinimas = ".NET";
            int studentuSkaicius = 8;
            DateTime siandienosData = DateTime.Today;
            Console.WriteLine("Mokyklos pavadinimas: {0}", mokyklosPavadinimas);
            Console.WriteLine("Kurso pavadinimas: {0}", kursoPavadinimas);
            Console.WriteLine("Studentu skaicius: {0}", studentuSkaicius);
            Console.WriteLine("Siandienos data: {0}", siandienosData);
            Console.ReadLine();
        }
    }
}
