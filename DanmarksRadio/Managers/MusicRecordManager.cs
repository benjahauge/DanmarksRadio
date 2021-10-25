using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DanmarksRadio.Models;

namespace DanmarksRadio.Managers
{
	public class MusicRecordManager
	{
		private static int _nextId = 1;

		private static readonly List<MusicRecord> data = new List<MusicRecord>()
		{
			new MusicRecord() {Artist = "Kanye West", Duration = 200, PublicationYear = 2011, Title = "Flashing Lights"},
			new MusicRecord() {Artist = "The Weeknd", Duration = 180, PublicationYear = 2019, Title = "After Hours"},
			new MusicRecord() {Artist = "Justin Bieber", Duration = 150, PublicationYear = 2009, Title = "Baby"}
		};

		public List<MusicRecord> GetAll()
		{
			return new List<MusicRecord>(data);
		}
	}
}
