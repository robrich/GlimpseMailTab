namespace GlimpsePlayground.Repository {
	using GlimpsePlayground.Entity;
	using GlimpsePlayground.Entity.Models;
	using GlimpsePlayground.Infrastructure;
	using System;
	using System.Net.Mail;

	public interface ISmtpRepository {

		/// <summary>
		/// Don't consume this directly, consume MailRepository instead
		/// </summary>
		void SendEmail(Mail Mail);

	}

	public class SmtpRepository : ISmtpRepository {

		public void SendEmail(Mail Mail) {
			if (Mail == null) {
				throw new ArgumentNullException("Mail");
			}
			MailAddress toAddress = string.IsNullOrEmpty(Mail.ToName) ? new MailAddress(Mail.ToEmail) : new MailAddress(Mail.ToEmail, Mail.ToName);
			MailAddress fromAddress = new MailAddress("from@from.com");
			MailMessage message = new MailMessage(fromAddress, toAddress) {
				Subject = Mail.Subject,
				Body = Mail.Body,
				IsBodyHtml = true
			};

			// Add to Glimpse
			GlimpseConfig.Publish(new GlimpseMail(Mail));

			// Now send the email:
			/*
			try {
				new SmtpClient().Send(message);
			} catch (Exception ex) {
				StringBuilder sb = new StringBuilder();
				sb.Append("Error sending email:");
				sb.Append(" to: " + toAddress.Address);
				sb.Append(", subject: " + Mail.Subject);
				sb.Append(", body: " + Mail.Body);
				sb.Append(", Exception message: " + ex.Message);
				throw new Exception(sb.ToString(), ex);
			}
			*/
		}

	}
}
