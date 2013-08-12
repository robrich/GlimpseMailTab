namespace GlimpsePlayground.Web.Controllers {
	using GlimpsePlayground.Entity;
	using GlimpsePlayground.Repository;
	using System;
	using System.Web.Mvc;

	public class HomeController : Controller {

		private readonly ISmtpRepository smtpRepository;

		public HomeController(ISmtpRepository SmtpRepository) {
			if (SmtpRepository == null) {
				throw new ArgumentNullException("SmtpRepository");
			}
			smtpRepository = SmtpRepository;
		}

		public HomeController()
			: this(new SmtpRepository()) {
		}

		public ActionResult Index() {

			this.smtpRepository.SendEmail(new Mail {
				ToEmail = "someone@example.com",
				ToName = "Someone",
				Subject = "This is a mail",
				Body = "I've got a body\nthat says a lot and\nhas some <a href=\"markup.aspx\">markup</a> in it"
			});

			return this.View();
		}

	}
}
