using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using Unity;

namespace Employee.Services
{
    internal class UnityServiceHost : ServiceHost
    {
        public UnityServiceHost(Type serviceType, IUnityContainer container, params Uri[] baseAddresses)
            : base(serviceType, baseAddresses)
        {
            Container = container;
        }

        protected override void OnOpening()
        {
            if (Description.Behaviors.Find<UnityServiceBehavior>() == null)
            {
                Description.Behaviors.Add(new UnityServiceBehavior(Container));
            }

            base.OnOpening();
        }

        protected IUnityContainer Container
        {
            get;
            set;
        }
    }
}