namespace MyWCF.Contract
{
    using System.ServiceModel;

    [ServiceContract(Name = "HelloWorldService", Namespace = "MyWCF")]
    public interface IHelloWorld
    {
        [OperationContract]
        string SayHelloTo(string name);
    }
}
