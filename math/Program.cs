using System;



namespace math
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, sum,diff,mul,div;
            Console.WriteLine("enter first number");
            a = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("enter second number");
            b = Convert.ToInt64(Console.ReadLine());
            sum = a + b;
            diff = a - b;
            mul = a * b;
            div = a / b;
            Console.WriteLine("the sum is={0}",sum);
            Console.WriteLine("the diff is={0}", diff);
            Console.WriteLine("the mul is={0}", mul);
            Console.WriteLine("the div is={0}", div);
            Console.ReadKey();
        }
    }
}
