namespace MyWCF.Client
{
    using System.ServiceModel;
    using System.ServiceModel.Channels;
    using Contract;

    class HelloWorldClient : ClientBase<IHelloWorld>, IHelloWorld
    {
        public HelloWorldClient()
        { }

        public HelloWorldClient(string endpointName)
            : base(endpointName)
        { }

        public HelloWorldClient(Binding binding, EndpointAddress remoteAddress)
            : base(binding, remoteAddress)
        { }

        public string SayHelloTo(string name)
        {
            return Channel.SayHelloTo(name);
        }
    }
}
