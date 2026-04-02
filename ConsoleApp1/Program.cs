using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // print ke console dengan tanpa satu baris 
            Console.Write($"Belajar dari nol");
            // print ke console dengan nambah satu baris
            Console.WriteLine($" Belajar C# pemula ");

            Console.WriteLine(3 + 3);

            // Type Data
            int number = 1;
            double doubled = 2.1D;
            char chara ='a';
            string name = "irawan";
            bool status = false;

            Console.WriteLine($"ini number = {number}, ini double = {doubled}, ini char = {chara}, ini string : {name}, ini status = {status}");

            // Konstanta = ada variabel yang tidak dapat diubah
            const int konstanta = 1;
            /**
             * const int konstanta = 1;
             * konstanta = 2; // error
             */
            Console.WriteLine($"ini konstanta : {konstanta}");

            /**
             * Declare many Variable
             * 
             */
            int x =5, y =10 , z=50;
            Console.WriteLine($"int {x} , {y} , {z}");

            int h, i, j;
            h = i = j = 10;
            Console.WriteLine(h+i+j);
        }
    }
}
