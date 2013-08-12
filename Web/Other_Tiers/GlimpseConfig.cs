namespace GlimpsePlayground.Infrastructure {
	using System;
	using Glimpse.Core.Message;

	public static class GlimpseConfig {

		static GlimpseConfig() {
			Publish = m => {
				// no-op until Glimpse rigs it
			};
		}

		public static Action<IMessage> Publish { get; set; }

	}
}
