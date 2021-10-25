using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DanmarksRadio.Managers;
using DanmarksRadio.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DanmarksRadio.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MusicRecordController : ControllerBase
	{
		private readonly MusicRecordManager _manager = new MusicRecordManager();

		// GET: api/<MusicRecordController>
		[HttpGet]
		public IEnumerable<MusicRecord> Get([FromQuery] string title, [FromQuery] string artist, [FromQuery] string sort_by)
		{
			return _manager.GetAll(title, artist, sort_by);
		}

		// GET api/<MusicRecordController>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<MusicRecordController>
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		// PUT api/<MusicRecordController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<MusicRecordController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
