namespace UmbracoLearning.Controllers
{
	using System.Web.Mvc;
	using Umbraco.Web.Mvc;

	public class HomeController : SurfaceController
	{
		private const string Partial_Views_Path = "~/Views/Partials/Home/";

		public ActionResult RenderBanner()
		{
			return PartialView($"{Partial_Views_Path}Banner.cshtml");
		}

		public ActionResult RenderSectionOne()
		{
			return PartialView($"{Partial_Views_Path}SectionOne.cshtml");
		}

		public ActionResult RenderSectionTwo()
		{
			return PartialView($"{Partial_Views_Path}SectionTwo.cshtml");
		}

		public ActionResult RenderSectionThree()
		{
			return PartialView($"{Partial_Views_Path}SectionThree.cshtml");
		}
	}
}