using System;

namespace ConsoleApp11
{

    class A
    {
        public virtual void Ornek()
        {
            Console.WriteLine("Örnek Metot Çağrıldı");
        }
    }

    class B : A
    {
        public override void Ornek()
        {
            Console.WriteLine("Ezilmiş Örnek Metot Çağrıldı");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            A a = new A();
            a.Ornek();

            B b = new B();
            b.Ornek();
            //Biz metotu ezmeseydik b.Ornek(); de a.Ornek(); gibi "Örnek Metot Çağrıldı" yazdıracaktı.

        }
    }


}
