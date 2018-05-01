using Employee.Presenter;
using Employee.View;
using Employee.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Unity;

namespace Employee.UI.Web
{
	public partial class EmployeeDetails : System.Web.UI.Page, IEmployeeView
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			var mvpContainer = Global.Container.CreateChildContainer();
			mvpContainer.RegisterInstance<IEmployeeView>(this);

			if (!Page.IsPostBack)
			{
				var presenter = mvpContainer.Resolve<IEmployeePresenter>();

				presenter.GetEmployeeDetails(10);
			}
		}

		#region IEmployeeView Implementation
		public string FirstName
		{
			get
			{
				return txtFirstName.Text;
			}
			set
			{
				txtFirstName.Text = value;
			}
		}

		public string LastName
		{
			get
			{
				return txtLastName.Text;
			}
			set
			{
				txtLastName.Text = value;
			}
		}

		public string Address
		{
			get
			{
				return txtAddress.Text;
			}
			set
			{
				txtAddress.Text = value;
			}
		}
		#endregion

	}
}