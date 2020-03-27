using System;
namespace ConsoleApp7
{
    class Program
    {

        static void Main(string[] args)
        {
           LHarfi harf = new LHarfi();
            while(true)
            {
               harf.Goster();
                ConsoleKeyInfo tus = Console.ReadKey();
                if (tus.Key == ConsoleKey.A)
                    harf.X--;
                if (tus.Key == ConsoleKey.D)
                    harf.X++;
                if (tus.Key == ConsoleKey.W)
                    harf.Y--;
                if (tus.Key == ConsoleKey.S)
                    harf.Y++;
                

                
            }
         
        }
       
    }
     class LHarfi
    { 
          public int X,Y;
          private int yukseklik;
          private int genislik;
        public LHarfi()
        {
            Y = 10; 
            X = 25;
            yukseklik =15;
            genislik =20;
        }
       
        public void Goster()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;

            for (int i = 0; i < yukseklik; i++)
            {
                Console.SetCursorPosition(X, Y + i);
                Console.Write(" ");

            }
            for (int i = 0; i < genislik; i++)
            {
                Console.SetCursorPosition(X + i,Y+yukseklik);
                Console.Write(" ");
            }
            
            Console.ResetColor();

        }

        

    }
 
}

