namespace MyWCF.Service
{
    using Contract;

    public class HelloWorldService : IHelloWorldEx
    {
        public string SayHelloTo(string name)
        {
            return string.Format("Hello {0}!", name);
        }

        public string SayHelloToEx(string[] names)
        {
            return string.Format("Hello {0}!", string.Join(",", names));
        }
    }
}
