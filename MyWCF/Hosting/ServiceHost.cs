namespace Hosting
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.ServiceModel;

    public class ServiceHost<T> : ServiceHost
    {
        public ServiceHost()
            : base(typeof(T))
        { }

        public ServiceHost(params string[] baseAddresses)
            : base(typeof(T), baseAddresses.Select((address) => new Uri(address)).ToArray())
        { }

        public ServiceHost(params Uri[] baseAddresses)
            : base(typeof(T), baseAddresses)
        { }

        public ServiceHost(T singleton, params string[] baseAddresses)
            : base(singleton, baseAddresses.Select((address) => new Uri(address)).ToArray())
        { }

        public ServiceHost(T singleton)
            : base(singleton)
        { }

        public ServiceHost(T singleton, params Uri[] baseAddresses)
            : base(singleton, baseAddresses)
        { }
    }
}
