namespace GlimpsePlayground.Web {
	using System.Web;
	using System.Web.Routing;
	using GlimpsePlayground.Web.App_Start;

	public class MvcApplication : HttpApplication {

		protected void Application_Start() {
			RouteConfig.RegisterRoutes(RouteTable.Routes);
		}

	}
}
