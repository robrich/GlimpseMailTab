namespace GlimpsePlayground.Web.Filters {
	using System.Linq;
	using Glimpse.AspNet.Extensibility;
	using Glimpse.Core.Extensibility;
	using Glimpse.Core.Extensions;
	using GlimpsePlayground.Entity.Models;
	using System.Collections.Generic;

	public class MailTab : AspNetTab {

		public override string Name {
			get { return "Mail"; }
		}

		public override object GetData(ITabContext context) {
			List<GlimpseMail> m = context.GetMessages<GlimpseMail>().ToList();
			return m;
		}

	}
}
