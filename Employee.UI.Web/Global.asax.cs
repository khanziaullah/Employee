using Employee.Infrastructure;
using Employee.PresentationLogic;
using Employee.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using Unity;
using Unity.Interception.ContainerIntegration;
using Unity.Interception.Interceptors.InstanceInterceptors.InterfaceInterception;
using Unity.Lifetime;
using Employee.PresentationLogic.EmployeeDetailsServiceReference;
using Unity.RegistrationByConvention;
using Unity.Injection;

namespace Employee.UI.Web
{
	public class Global : System.Web.HttpApplication
	{
		public static UnityContainer Container = new UnityContainer();
		protected void Application_Start(object sender, EventArgs e)
		{
			Container.AddNewExtension<Interception>();

			Container.RegisterType<EmployeeDetailsServiceClient>(new InjectionConstructor());

			Container.RegisterType<IEmployeePresenter, EmployeePresenter>(
				new Interceptor<InterfaceInterceptor>(),
				new InterceptionBehavior<LoggingInterceptionBehavior>());

			Container.RegisterType<IEmployeePresentationLogic, EmployeePresentationLogic>(
				new Interceptor<InterfaceInterceptor>(),
				new InterceptionBehavior<LoggingInterceptionBehavior>());
		}
	}
}