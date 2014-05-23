namespace MyWCF.Contract
{
    using System.ServiceModel;

    [ServiceContract(Name = "HelloWorldExService", Namespace = "MyWCF")]
    public interface IHelloWorldEx : IHelloWorld
    {
        [OperationContract]
        string SayHelloToEx(string[] names);
    }
}
