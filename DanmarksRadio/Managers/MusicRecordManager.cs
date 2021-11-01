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

		public List<MusicRecord> GetAll(string title = null, string artist = null, string sortBy = null)
		{
			List<MusicRecord> records = new List<MusicRecord>(data);

			if (title != null)
			{
				records = records.FindAll(record => record.Title != null && record.Title.StartsWith(title));
			}
			if (artist != null)
			{
				records = records.FindAll(record => record.Artist != null && record.Artist.StartsWith(artist));
			}
			if (sortBy != null)
			{
				switch (sortBy.ToLower())
				{
					case "title":
						records = records.OrderBy(record => record.Title).ToList();
						break;
					case "artist":
						records = records.OrderBy(record => record.Artist).ToList();
						break;
				}
			}

			return records;
			//return new List<MusicRecord>(data);
		}

		public MusicRecord Add(MusicRecord newRecord)
		{
			data.Add(newRecord);
			return newRecord;
		}

		public MusicRecord Delete(string title)
		{
			MusicRecord record = data.Find(record1 => record1.Title == title);
			if (record == null) return null;
			data.Remove(record);
			return record;
		}

		public MusicRecord Update(string title, MusicRecord updates)
		{
			MusicRecord record = data.Find(record => record.Title == title);
			if (record == null) return null;
			record.Title = updates.Title;
			record.Artist = updates.Artist;
			record.Duration = updates.Duration;
			record.PublicationYear = updates.PublicationYear;
			return record;
		}
	}
}
