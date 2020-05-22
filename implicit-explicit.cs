class Program
    {
        static void Main(string[] args)
        {
            //Explicit Tür Dönüşümü
            int number = 254;
            byte number2;
            number2 = (byte) number;
            Console.WriteLine(number2);

            //Implicit Tür Dönüşümü
            byte number3 = 15;
            int number4;
            number4 = number3;
            Console.WriteLine(number4);
            //int türü byte'ı kapsadığı için bu dönüşüm örtülü olarak yapılır.

        }

    }
