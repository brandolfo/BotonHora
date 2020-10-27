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
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) //aqui hacemos las configuraciones de nuestra db
		{
			optionsBuilder.UseSqlServer(config.GetConnectionString("BotonBase")); //aca le estamos diciendo que utilice sqlserver
			//optionsBuilder.UseSqlServer(config["ConnectionStrings: BotonBase"]); los dos hacen lo mismo
		}
		public DbSet<Button> Buttons { get; set; } // Crea e inicializa la tabla 
	}
}
