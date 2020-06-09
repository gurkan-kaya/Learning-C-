using System;

namespace ConsoleApp11
{

    static class Matematik
    {
        public static int Topla(params int[] Sayilar)
        {
            int Toplam = 0;
            for (int i = 0; i < Sayilar.Length; i++)
                Toplam = Toplam + Sayilar[i];

            return Toplam;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine(Matematik.Topla(128, 134, 13, 12, 100, 72));

                /*Bir sınıftaki metotlara o sınıftan oluşturduğumuz nesneler ile erişiriz
                 Ancak static metotlara nesne oluşturmadan sınıf adı ile erişilebilir.*/

                /*Static bir metodun içerisinden static olmayan metotlar ve değişkenler çağrılamaz. 
                 Sadece static metotlar ve değişkenler çağrılabilir.*/

                /*Static bir yapıcı metot tanımlanabilir. Statik olmayan yapıcı metottan farkı ise
                 ilk olarak static yapıcı metodun çağrılmasıdır. Ancak 1. nesneden sonra oluşturulacak
                 tüm nesnelerde sadece static olmayan yapıcı metot çağrılır. Yani static yapıcı metotlar 
                 yalnızca 1 kez çağrılır.*/

                /*Oluşturduğumuz sınıf içerisinde sadece static metotlar ve değişkenler bulunuyorsa 
                 sınıfı static olarak tanımlayabiliriz.Ancak bu bir zorunluluk değildir.*/

                //Static sınıflardan nesne oluşturulamaz. 
                //Static sınıf türünden referanslar oluşturulamaz. 
                //Static sınıfların içinde static olmayan metot yada değişken tanımlanamaz.
                //Static sınıflarda kalıtım yoktur.

            }
    }
}

