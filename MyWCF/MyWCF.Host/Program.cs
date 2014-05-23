namespace MyWCF.Host
{
    using System;
    using System.ServiceModel;
    using Service;
    using Hosting;

    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost<CalculatorService> calcHost = null;
            ServiceHost<HelloWorldService> helloHost = null;
            try
            {
                calcHost = new ServiceHost<CalculatorService>();
                calcHost.Opened += delegate
                {
                    Console.WriteLine("CalculaorService已经启动.");
                };

                calcHost.Open();

                helloHost = new ServiceHost<HelloWorldService>();
                helloHost.Opened += delegate
                {
                    Console.WriteLine("HelloWorldService已经启动.");
                };

                helloHost.Open();

                Console.WriteLine("按任意键终止服务！");
                Console.Read();
            }
            finally
            {
                if (calcHost != null)
                    calcHost.Close();

                if (helloHost != null)
                    helloHost.Close();
            }
        }
    }
}
