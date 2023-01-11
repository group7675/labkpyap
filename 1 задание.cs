using System;

namespace progect
{
    class Ilya
    {

        static void Main(string[] args)
        {

            Console.Write("Вы внесли = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Под процентную ставку = ");
            double b = Convert.ToDouble(Console.ReadLine());
            double c = a + (a * (b / 100));
            Console.WriteLine("Через год вы получите =", c);
            

        }
    }
}
