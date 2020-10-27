using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using BotonWebApi.Models;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BotonWebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SaveTimeController : ControllerBase
	{
		private readonly Buttondb buttondb; //inyeccion de dependencia, "nos traemos la base de datos para poder usarla"
		public SaveTimeController(Buttondb buttondb) //constructor
		{
			this.buttondb = buttondb;
		}
		// GET: api/<SaveTimeController>
		[HttpGet]
		public IEnumerable<Button> Get() //nos da toda la lista botones de la db
		{
			var buttonList = buttondb.Buttons;
			return buttonList;
		}

		// GET api/<SaveTimeController>/5
		[HttpGet("{id}")]
		public Button Get(Guid id) // filtra un boton de la db
		{
			var buttonF = buttondb.Buttons.FirstOrDefault(x => x.Id == id);
			return buttonF;
		}

		// POST api/<SaveTimeController>
		[HttpPost]
		public IActionResult Post(Button button) // agrega un botton a la db y retorna el resultado de la accion
		{
			buttondb.Buttons.Add(button);
			buttondb.SaveChanges();
			return new CreatedResult(button.Id.ToString(), button);
		}

		// PUT api/<SaveTimeController>/5
		[HttpPut("{id}")]
		public void Put(Button button)
		{
			var buttonA = buttondb.Buttons.FirstOrDefault(x => x.Id == button.Id);
			buttonA.TimeClick = DateTime.Now;
			buttondb.SaveChanges();
		}

		// DELETE api/<SaveTimeController>/5
		[HttpDelete("{id}")]
		public void Delete(Guid id) //elimina un boton hora de la bd
		{
			var buttonE = buttondb.Buttons.FirstOrDefault(y => y.Id == id);
			buttondb.Buttons.Remove(buttonE);
			buttondb.SaveChanges();

		}
	}
}
