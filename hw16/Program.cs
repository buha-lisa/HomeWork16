
namespace hw16
{
    internal class Program
    {
        public delegate bool Predicate<in T>(T x);
        public delegate void Action();
        public delegate T Func<in T1, in T2, out T>(T1 x, T2 y);
        public delegate List<int> MyDelegate(int[] array);
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Choose number of task(1-3): ");
                int.TryParse(Console.ReadLine(), out int task);
                if (task == 0) break;

                switch (task)
                {
                    case 1:
                        var first = new Task1();
                        var rnd = new Random();
                        int[] ints = new int[10];
                        for (int i = 0; i < ints.Length; i++)
                        {
                            ints[i] = rnd.Next(-10, 20);
                        }
                        Console.WriteLine("Array:");
                        foreach (var i in ints)
                        {
                            Console.Write(i + " ");
                        }
                        MyDelegate del = first.PairNumInArray;
                        Console.WriteLine("\nPair: ");
                        PrintNumbers(del(ints));

                        del = first.UnPairNumInArray;
                        Console.WriteLine("Unpair: ");
                        PrintNumbers(del(ints));

                        del = first.PrimeNumInArray;
                        Console.WriteLine("Prime: ");
                        PrintNumbers(del(ints));

                        del = first.FibonacciNumInArray;
                        Console.WriteLine("Fibonacci: ");
                        PrintNumbers(del(ints));
                        break;
                    case 2:
                        var second = new Task2();

                        Action time = second.CurrentTime;
                        time();
                        Console.WriteLine();

                        time = second.CurrentDate;
                        time();
                        Console.WriteLine();

                        time = second.CurrentDayOfWeek;
                        time();
                        Console.WriteLine();

                        Func<double, double, double> square = second.TriangleSquare;
                        Console.WriteLine($"Square: {square(5.5, 10.0)}");

                        square = second.RectangleSquare;
                        Console.WriteLine($"Square: {square(6.0, 7.0)}");

                        break;
                    case 3:
                        var myCard = new CreditCard()
                        {
                            NumberOfCard = "1234 5678 9012 3456",
                            PIP = "Din Winchester",
                            Complite = new DateOnly(2025, 12, 31),
                            PineCode = 1234,
                            CreditLimit = 5000.00,
                            AmountOfMoney = 1500.00
                        };

                        myCard.ShowInfo();
                        break;
                }
            }
        }
        static void PrintNumbers(List<int> numbers)
        {
            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
    }
}
