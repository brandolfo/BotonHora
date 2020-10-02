using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BotonWebApi.Models
{
	public class Buttondb : DbContext
	{
		private readonly IConfiguration config;

		public Buttondb(IConfiguration config) {
			this.config = config;
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(config.GetConnectionString("Brandombase")); 
		}
		public DbSet<Button> Buttons { get; set; }
	}
}
