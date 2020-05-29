using Microsoft.AspNetCore.Mvc.Testing;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;


namespace CoronaMed.IntegrationTest
{
	public class IntegrationTest
	{
		protected readonly HttpClient httpTestClient;

		public IntegrationTest()
		{
			Environment.SetEnvironmentVariable("ASPNETCORE_ENVIRONMENT", "Test");			
			var appFactory = new WebApplicationFactory<Startup>();
			httpTestClient = appFactory.CreateClient();
			httpTestClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

		}
	}
}
