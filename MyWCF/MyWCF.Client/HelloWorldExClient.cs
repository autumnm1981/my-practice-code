namespace MyWCF.Client
{
    using System.ServiceModel;
    using System.ServiceModel.Channels;
    using Contract;

    class HelloWorldExClient : ClientBase<IHelloWorldEx>, IHelloWorldEx
    {
        public HelloWorldExClient()
        { }

        public HelloWorldExClient(string endpointName)
            : base(endpointName)
        { }

        public HelloWorldExClient(Binding binding, EndpointAddress remoteAddress)
            : base(binding, remoteAddress)
        { }

        public string SayHelloTo(string name)
        {
            return Channel.SayHelloTo(name);
        }

        public string SayHelloToEx(string[] names)
        {
            return Channel.SayHelloToEx(names);
        }
    }
}
