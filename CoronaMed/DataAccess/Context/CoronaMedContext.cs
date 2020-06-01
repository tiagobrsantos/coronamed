using CoronaMed.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoronaMed.DataAccess.Context
{
	public class CoronaMedContext: DbContext
	{

		public DbSet<Partner> Partners { get; set; }
		public DbSet<ContactUs> ContactUs { get; set; }

		public CoronaMedContext(DbContextOptions options) : base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{


			foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
			{
				relationship.DeleteBehavior = DeleteBehavior.Restrict;
			}

			base.OnModelCreating(modelBuilder);
			//modelBuilder.Seed();
		}
	}
}
