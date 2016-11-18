//
// Startup.cs
//
// Created on 11/17/2016
//
// Author:
//       Auston Lopez <MRPOWERZ83@me.com>
//
// Copyright (c) 2016 
//
//

using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace blah
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
		}

		public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
		{
			loggerFactory.AddConsole();

			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			app.Run(async (context) =>
			{
				await context.Response.WriteAsync("Hello World!");
			});
		}
	}
}

