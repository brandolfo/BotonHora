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
		private readonly Buttondb buttondb;
		public SaveTimeController(Buttondb buttondb) //constructor
		{
			this.buttondb = buttondb;
		}
		// GET: api/<SaveTimeController>
		[HttpGet]
		public IEnumerable<Button> Get()
		{
			var buttonList = buttondb.Buttons;
			return buttonList;
		}

		// GET api/<SaveTimeController>/5
		[HttpGet("{id}")]
		public Button Get(Guid id)
		{
			var buttonF = buttondb.Buttons.FirstOrDefault(x => x.Id == id);
			return buttonF;
		}

		// POST api/<SaveTimeController>
		[HttpPost]
		public void Post([FromBody] string value)
		{

		}

		// PUT api/<SaveTimeController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<SaveTimeController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
