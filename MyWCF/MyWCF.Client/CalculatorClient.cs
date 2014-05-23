namespace MyWCF.Client
{
    using System.ServiceModel;
    using System.ServiceModel.Channels;
    using Contract;

    class CalculatorClient : ClientBase<ICalculator>, ICalculator
    {
        public CalculatorClient()
        { }

        public CalculatorClient(string endpointName)
            : base(endpointName)
        { }

        public CalculatorClient(Binding binding, EndpointAddress remoteAddress)
            : base(binding, remoteAddress)
        { }

        public double Add(double x, double y)
        {
            return Channel.Add(x, y);
        }

        public double Subtract(double x, double y)
        {
            return Channel.Subtract(x, y);
        }

        public double Multiply(double x, double y)
        {
            return Channel.Multiply(x, y);
        }

        public double Divide(double x, double y)
        {
            return Channel.Divide(x, y);
        }
    }
}
