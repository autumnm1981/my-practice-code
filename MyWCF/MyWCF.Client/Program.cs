namespace MyWCF.Client
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            using (CalculatorClient calcClient = new CalculatorClient())
            {
                Console.WriteLine("x + y = {2} when x = {0} and y = {1}", 1, 2, calcClient.Add(1, 2));
                Console.WriteLine("x - y = {2} when x = {0} and y = {1}", 1, 2, calcClient.Subtract(1, 2));
                Console.WriteLine("x * y = {2} when x = {0} and y = {1}", 1, 2, calcClient.Multiply(1, 2));
                Console.WriteLine("x / y = {2} when x = {0} and y = {1}", 1, 2, calcClient.Divide(1, 2));
            }

            using (HelloWorldClient helloClient = new HelloWorldClient())
            {
                Console.WriteLine("What's your name?");
                string name = Console.ReadLine();
                Console.WriteLine(helloClient.SayHelloTo(name));
            }

            using (HelloWorldExClient helloExClient = new HelloWorldExClient())
            {
                Console.WriteLine("What's your name?");
                string name = Console.ReadLine();
                Console.WriteLine(helloExClient.SayHelloTo(name));
                Console.WriteLine(helloExClient.SayHelloToEx(new string[] { name, name, name }));
            }

            Console.WriteLine("按任意键退出！");
            Console.Read();
        }
    }
}
