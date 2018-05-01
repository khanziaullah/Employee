using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Web;
using Unity;

namespace Employee.Services
{
    public class UnityServiceHostFactory : ServiceHostFactory
    {
        public IUnityContainer Container
        {
            get;
            set;
        }

        public UnityServiceHostFactory()
            : this(Global.container)
        {
        }

        public UnityServiceHostFactory(IUnityContainer container)
        {
            Container = container;
        }

        protected override ServiceHost CreateServiceHost(Type serviceType, Uri[] baseAddresses)
        {
            return new UnityServiceHost(serviceType, Container, baseAddresses);
        }
    }
}