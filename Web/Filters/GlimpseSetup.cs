namespace GlimpsePlayground.Web.Filters {
	using Glimpse.Core.Extensibility;
	using GlimpsePlayground.Entity.Models;
	using GlimpsePlayground.Infrastructure;

	public class GlimpseSetup : IInspector {

		public void Setup(IInspectorContext context) {
			GlimpseConfig.Publish = m => {
				if (m != null && context.MessageBroker != null) {
					context.MessageBroker.Publish(m);
				}
			};
			/*
			context.MessageBroker.Subscribe<GlimpseMail>(a => {
				int q = 0;
			});
			*/
		}

	}
}
