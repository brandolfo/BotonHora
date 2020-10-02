using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BotonWebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BotonController : ControllerBase
	{
		// GET: api/<BotonController>
		[HttpGet]
		public IEnumerable<string> Get()
		{
			DateTime time = DateTime.Now;
			return new string[] { "value1", "value2" };
		}

		// GET api/<BotonController>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<BotonController>
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		// PUT api/<BotonController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<BotonController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
