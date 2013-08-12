namespace GlimpsePlayground.Entity.Models {
	using System;
	using Glimpse.Core.Message;

	public class GlimpseMail : IMessage {

		public GlimpseMail(Mail Mail) {
			if (Mail != null) {
				this.ToEmail = Mail.ToEmail;
				this.ToName = Mail.ToName;
				this.Subject = Mail.Subject;
				this.Body = Mail.Body;
			}
		}

		public Guid Id { get; private set; }
		public string ToEmail { get; set; }
		public string ToName { get; set; }
		public string Subject { get; set; }
		public string Body { get; set; }

	}
}
