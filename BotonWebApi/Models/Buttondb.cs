using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BotonWebApi.Models
{
	public class Buttondb : DbContext
	{
		private readonly IConfiguration config; // inyeccion de dependencia

		public Buttondb(IConfiguration config) { //constructor
			this.config = config;
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(config.GetConnectionString("Brandombase"));
			//optionsBuilder.UseSqlServer(config["ConnectionStrings: Brandombase"]); los dos hacen lo mismo
		}
		public DbSet<Button> Buttons { get; set; }
	}
}
