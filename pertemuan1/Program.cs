using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace pertemuan1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "aplikasi calculator";

            Console.WriteLine("pilih menu kalkulator :/n");

            Console.WriteLine("1.penambahan");
            Console.WriteLine("2.pengurangan");
            Console.WriteLine("3.perkalian");
            Console.WriteLine("4.pembagian");

            Console.WriteLine("input nomer menu [1 - 4] : ");
            int menu = int.Parse(Console.ReadLine());


            

            if (menu == 1)
            {
                Console.Write("inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("inputkan nilai b =");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("hasil penambahan" + a + " + " + b + " =  " + penambahan(a, b));
            }
            else if (menu == 2)
            {
                Console.Write("inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("inputkan nilai b =");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("hasil pengurangan {0} - {1} = {2}", a, b, pengurangan(a, b));
            }
            else if (menu == 3)
            {
                Console.Write("inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("inputkan nilai b =");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("hasil perkalian {0} * {1} = {2}", a, b, perkalian(a, b));
            }
            else if (menu == 4)
            {
                Console.Write("inputkan nilai a = ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("inputkan nilai b =");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("hasil pembagian {0} / {1} = {2}", a, b, pembagian(a, b));
            }
            else
            {
                Console.WriteLine("\nmaaf pilihan anda tidak tersedia");
            }

                Console.WriteLine("\ntekan sembarang key untuk keluar");
                Console.ReadKey();
           


        }
        static int penambahan(int a, int b)
        {
            return a + b;
        }
        static int pengurangan (int a,int b)
        {
            return a - b;
        }
        static int perkalian (int a,int b)
        {
            return a * b;
        }
        static int pembagian (int a,int b)
        {
            return a / b;        
        }

    }
    

}
