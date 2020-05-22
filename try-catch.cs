    class Program
    {
        static void Main(string[] args)
        {
            //    try
            //    {
            //        Olası hataların bulunduğu komutlar yazıılır

            //    }
            //    catch 
            //    {
            //      try içerisinde hata alınırsa catch çalışır.

            //    }




            try
            {
                Console.WriteLine("Lütfen bir sayı giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(sayi + " girdiniz.");
            }

            catch
            {

                Console.WriteLine("Hata! Lütfen sayı giriniz.");

            }
        }
    
    }
