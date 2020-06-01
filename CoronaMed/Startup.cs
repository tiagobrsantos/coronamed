using CoronaMed.Commands.Handlers;
using CoronaMed.Commands.Handlers.Interface;
using CoronaMed.DataAccess;
using CoronaMed.DataAccess.Context;
using CoronaMed.Model.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;

namespace CoronaMed
{
	public class Startup
	{
		public Startup(IConfiguration configuration, IWebHostEnvironment webHostEnvironment)
		{
			Configuration = configuration;
			WebHostEnvironment = webHostEnvironment;
		}

		private IWebHostEnvironment WebHostEnvironment { get; set; }

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{

			services.AddControllersWithViews();

			// In production, the React files will be served from this directory
			services.AddSpaStaticFiles(configuration =>
			{
				configuration.RootPath = "ClientApp/build";
			});

			if (WebHostEnvironment.IsEnvironment("Test") || WebHostEnvironment.IsDevelopment())
			{
				services.AddDbContext<CoronaMedContext>(opt => opt.UseInMemoryDatabase("CoronaMedDB"));
			}
			else
			{
				services.AddDbContext<CoronaMedContext>(options => options.UseSqlServer(Configuration["CoronaMed_Database"]));
			}

			#region Swagger
			services.AddSwaggerGen(c =>
			{
				c.SwaggerDoc("v1", new OpenApiInfo
				{
					Version = "v1",
					Title = "CornaMed API"
				});
			});
			#endregion

			#region IOC
			//Repositories
			services.AddTransient<IPartnerRepository, PartnerRepository>();
			services.AddTransient<IContactUsRepository, ContactUsRepository>();

			//CommandHandler
			services.AddTransient<IPartnerCommandHandler, PartnerCommandHandler>();
			services.AddTransient<IContactUsCommandHandler, ContactUsCommandHandler>();

			#endregion
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseSwagger();

			// Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
			// specifying the Swagger JSON endpoint.
			app.UseSwaggerUI(c =>
			{
				c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebSip API V1");
				c.RoutePrefix = string.Empty;
			});

			app.UseHttpsRedirection();
			app.UseStaticFiles();
			app.UseSpaStaticFiles();

			app.UseRouting();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller}/{action=Index}/{id?}");
			});

			app.UseSpa(spa =>
			{
				spa.Options.SourcePath = "ClientApp";

				if (env.IsDevelopment())
				{
					spa.UseReactDevelopmentServer(npmScript: "start");
				}
			});
		}
	}
}
