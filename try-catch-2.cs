class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Birinci sayıyı giriniz: ");
            int sayi_1 = Convert.ToInt32(Console.ReadLine());
 
            Console.Write("İkinci sayıyı giriniz: ");
            int sayi_2 = Convert.ToInt32(Console.ReadLine());
 
            double sonuc = sayi_1 / sayi_2;
            Console.WriteLine("Birinci sayının ikinci sayıya bölümü:{0}", sonuc);
        }
        
         catch (DivideByZeroException exception)
        {
            // sayi_2 değişkenine sıfır değeri atandığında bu catch bloğu çalışacak.
            Console.WriteLine("Bir sayıyı sıfıra bölemezsiniz. Hata Mesajı:{0}", exception.Message);
        }
        catch (FormatException exception)
        {
            // Sayı yerine harf veya karakter girildiğinde bu catch bloğu çalışacak.
            Console.WriteLine("Lütfen sadece sayı giriniz. Hata Mesajı:{0}", exception.Message);
        }
       
        catch (Exception exception)
        {
            // Farklı bir hata oluştuğunda bu catch bloğu çalışacak.
            Console.WriteLine("Beklenmedik bir hata oluştu. Hata Mesajı:{0}", exception.Message);
        }
        
        
       finally
        {
            /* Finally  yazılmayabilir. Kullanım amacı ise şudur: Catch blokları eğer try bloğu tarafından tetiklenirse çalışır.
            Finally bloğu ise try'a bağlı olmadan her halükarda çalışır.*/
        }
    }
}
