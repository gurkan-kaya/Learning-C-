using System;

namespace AbstractClass
{
/*
A delegate is a reference type variable that holds the reference to a method.
*/
    class Program
    {
        delegate void islemler(int a1, int a2);

       static void Topla(int a1, int a2)
        {
            Console.WriteLine(a1 + a2);
        }
        static void Cikar(int a1, int a2)
        {
            Console.WriteLine(a1 - a2);
        }
        static void Carp(int a1, int a2)
        {
            Console.WriteLine(a1 * a2);
        }
        static void Bol(int a1, int a2)
        {
            Console.WriteLine(a1 / a2);
        }
        static void Main(string[] args)
        {

            islemler islem = new islemler(Topla);
            islem += Cikar;
            islem += Carp;
            islem += Bol;
            islem(15, 5);

        }
    }
}


