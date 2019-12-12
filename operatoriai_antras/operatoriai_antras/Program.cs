using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operatoriai_antras
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 15;
            Console.WriteLine("Pries keitima: a = {0}, b = {1}", a, b);
            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("po keitimo: a = {0}, b = {1}", a,b);
            Console.ReadLine();
        }
    }
}
