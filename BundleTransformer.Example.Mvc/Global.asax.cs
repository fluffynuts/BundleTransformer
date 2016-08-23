﻿namespace BundleTransformer.Example.Mvc
{
	using System.Web;
	using System.Web.Mvc;
	using System.Web.Optimization;
	using System.Web.Routing;

	using JavaScriptEngineSwitcher.Core;

	public class MvcApplication : HttpApplication
	{
		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();

			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			JsEngineSwitcherConfig.Configure(JsEngineSwitcher.Instance);
			BundleConfig.RegisterBundles(BundleTable.Bundles);
		}
	}
}