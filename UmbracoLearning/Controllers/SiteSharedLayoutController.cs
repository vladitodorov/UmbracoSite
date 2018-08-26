namespace UmbracoLearning.Controllers
{
	using System.Web.Mvc;
	using Umbraco.Web.Mvc;

	public class SiteSharedLayoutController : SurfaceController
	{
		private const string Partial_Views_Path = "~/Views/Partials/SharedLayout/";

		public ActionResult RenderHeader()
		{
			return PartialView($"{Partial_Views_Path}Header.cshtml");
		}

		public ActionResult RenderFooter()
		{
			return PartialView($"{Partial_Views_Path}Footer.cshtml");
		}

	}
} 