namespace GlimpsePlayground.Web.Filters {
	using Glimpse.AspNet.Extensions;
	using Glimpse.Core.Extensibility;
	using System.Web;

	public class GlimpseSecurityPolicy : IRuntimePolicy {

		public RuntimePolicy Execute(IRuntimePolicyContext policyContext) {

			HttpContextBase httpContext = policyContext.GetHttpContext();
			// if (!httpContext.User.IsInRole("Administrator"))
			// {
			//     return RuntimePolicy.Off;
			// }
			return RuntimePolicy.On;
		}

		public RuntimeEvent ExecuteOn {
			get { return RuntimeEvent.EndRequest; }
		}

	}
}
