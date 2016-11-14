//
// Global.asax.cs
//
// Created on 10/23/2016
//
// Author:
//       Auston Lopez <MRPOWERZ83@me.com>
//
// Copyright (c) 2016 
//
//
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Http;

namespace SibLink
{
	public class Global : HttpApplication
	{
		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();
			GlobalConfiguration.Configure(WebApiConfig.Register);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
		}
	}
}
