//
// Program.cs
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
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace blah
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var host = new WebHostBuilder()
				.UseKestrel()
				.UseContentRoot(Directory.GetCurrentDirectory())
				.UseStartup<Startup>()
				.Build();

			host.Run();
		}
	}
}

