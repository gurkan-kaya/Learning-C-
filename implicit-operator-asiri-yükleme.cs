    class Program
    {
        static void Main(string[] args)
        {

            MyClass mc = new MyClass();

            mc.number = 100;

            int a = mc;

            Console.WriteLine(a);

        }

    }

    class MyClass
    {
        public int number;

        public static implicit operator int(MyClass m)
        {
            return m.number;
        }

    }
}
