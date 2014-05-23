namespace MyWCF.WebRefClient
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Contract;
    using Contract2;

    class Program
    {
        static void Main(string[] args)
        {
            using (CalculatorServiceClient calcClient = new CalculatorServiceClient())
            {
                Console.WriteLine("x + y = {2} when x = {0} and y = {1}", 1, 2, calcClient.Add(1, 2));
                Console.WriteLine("x - y = {2} when x = {0} and y = {1}", 1, 2, calcClient.Subtract(1, 2));
                Console.WriteLine("x * y = {2} when x = {0} and y = {1}", 1, 2, calcClient.Multiply(1, 2));
                Console.WriteLine("x / y = {2} when x = {0} and y = {1}", 1, 2, calcClient.Divide(1, 2));
            }

            using (HelloWorldServiceClient helloClient = new HelloWorldServiceClient())
            {
                Console.WriteLine("What's your name?");
                string name = Console.ReadLine();
                Console.WriteLine(helloClient.SayHelloTo(name));
            }

            using (HelloWorldExServiceClient helloExClient = new HelloWorldExServiceClient())
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
