using KörHenger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Kor k1 = new Kor();

            k1.SetSugar(15);

            k1.SetKerület();

            k1.SetTerület();

            kiír(k1);


            Kor k2 = new Kor(58);

            k2.SetKerület();

            k2.SetTerület();

            kiír(k2);

            Console.ReadKey();

        }

        private static void kiír(Kor k)

        {

            Console.WriteLine($"A {k.GetSugár()} sugarú kör kerülete: {k.GetKerület()}, területe: {k.GetTerület()}.");

        }


    }
}