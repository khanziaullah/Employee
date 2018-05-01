using System;
using System.Configuration;
using System.Globalization;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using Unity;

namespace Employee.Services
{
    internal class UnityInstanceProvider : IInstanceProvider
    {
        public UnityInstanceProvider(IUnityContainer container, Type serviceType)
        {
            Container = container ?? throw new ArgumentNullException("container");
            ServiceType = serviceType ?? throw new ArgumentNullException("serviceType");
        }

        public Object GetInstance(InstanceContext instanceContext)
        {
            return GetInstance(instanceContext, null);
        }

        public Object GetInstance(InstanceContext instanceContext, Message message)
        {
            Object instance = Container.Resolve(ServiceType);

            if (instance == null)
            {
                const String MessageFormat = "No unity configuration was found for service type '{0}'";
                String failureMessage = String.Format(CultureInfo.InvariantCulture, MessageFormat, ServiceType.FullName);

                throw new ConfigurationErrorsException(failureMessage);
            }

            return instance;
        }

        public void ReleaseInstance(InstanceContext instanceContext, Object instance)
        {
        }

        protected Type ServiceType
        {
            get;
            set;
        }

        private IUnityContainer Container
        {
            get;
            set;
        }
    }
}