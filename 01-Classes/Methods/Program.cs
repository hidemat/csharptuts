using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void UseParams()
        {
            var calculator = new Calculator();
            System.Console.WriteLine(calculator.Add(1, 2));
            System.Console.WriteLine(calculator.Add(1, 2, 3));
            System.Console.WriteLine(calculator.Add(1, 2, 3, 4));
            System.Console.WriteLine(calculator.Add(1, 2, 3, 4, 5));
        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(40, 60);
                Console.WriteLine("Point is at: {0}, {1}", point.X, point.Y);

                point.Move(new Point(100, 200));
                Console.WriteLine("Point is at: {0}, {1}", point.X, point.Y);

                point.Move(null);
                Console.WriteLine("Point is at: {0}, {1}", point.X, point.Y);

            }
            catch (Exception)
            {
                System.Console.WriteLine("An unexpected error occured");
            }
        }
    }
}
