using Employee.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using Unity;
using Unity.Interception.ContainerIntegration;
using Unity.Interception.Interceptors.InstanceInterceptors.InterfaceInterception;

namespace Employee.Services
{
	public class Global : System.Web.HttpApplication
	{

		public static UnityContainer container = new UnityContainer();
		protected void Application_Start(object sender, EventArgs e)
		{
			container.AddNewExtension<Interception>();

			//TODO: To intercept request / response implement ServiceManager classes
			//container.RegisterType<IEmployeeDetailsService, EmployeeDetailsService>(
			//	new Interceptor<InterfaceInterceptor>(),
			//	new InterceptionBehavior<LoggingInterceptionBehavior>());

			container.RegisterType<BusinessLogicLayer.IEmployeeDetails, BusinessLogicLayer.EmployeeDetails>(
				new Interceptor<InterfaceInterceptor>(),
				new InterceptionBehavior<LoggingInterceptionBehavior>());

			container.RegisterType<DataAccessLayer.IEmployeeDetails, DataAccessLayer.EmployeeDetails>(
				new Interceptor<InterfaceInterceptor>(),
				new InterceptionBehavior<LoggingInterceptionBehavior>());
		}
	}
}