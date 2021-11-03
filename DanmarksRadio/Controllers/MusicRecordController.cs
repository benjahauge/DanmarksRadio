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
		[ProducesResponseType(200)]
		[ProducesResponseType(204)]
		public ActionResult<IEnumerable<MusicRecord>> Get([FromQuery] string title, [FromQuery] string artist, [FromQuery] string sort_by)
		{
			var musicRecords = _manager.GetAll(title, artist, sort_by);
			if (musicRecords.Count == 0)
			{
				return NoContent();
			}
			return Ok(musicRecords);
		}

		// GET api/<MusicRecordController>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<MusicRecordController>
		[HttpPost]
		[ProducesResponseType(200)]
		public ActionResult<MusicRecord> Post([FromBody] MusicRecord value)
		{
			return Ok(_manager.Add(value));
		}

		// PUT api/<MusicRecordController>/5
		[HttpPut("{title}")]
		[ProducesResponseType(200)]
		[ProducesResponseType(404)]
		public ActionResult<MusicRecord> Put(string title, [FromBody] MusicRecord value)
		{
			var musicRecord = _manager.Update(title, value);
			if (musicRecord == null)
			{
				return NotFound();
			}
			return Ok(musicRecord);
		}

		// DELETE api/<MusicRecordController>/5
		[HttpDelete("{title}")]
		[ProducesResponseType(200)]
		[ProducesResponseType(404)]
		public ActionResult<MusicRecord> Delete(string title)
		{
			var musicRecord = _manager.Delete(title);
			if (musicRecord != null)
			{
				return Ok(musicRecord);
			}
			return NotFound();

		}
	}
}
