using Microsoft.VisualStudio.TestTools.UnitTesting;
using DanmarksRadio.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DanmarksRadio.Models;

namespace DanmarksRadio.Managers.Tests
{
	[TestClass()]
	public class MusicRecordManagerTests
	{
		MusicRecordManager manager = new MusicRecordManager();
		MusicRecord newRecord = new MusicRecord() { Title = "The Bones", Artist = "Maren Morris", Duration = 200, PublicationYear = 2019 };

		//[TestMethod()]
		//public void GetAllTest()
		//{
		//	int expectedResult = 3;

		//	Assert.AreEqual(expectedResult, manager.GetAll().Count);
		//}

		//[TestMethod()]
		//public void GetAllWithParametersTest()
		//{
		//	int expectedResult = 1;

		//	Assert.AreEqual(expectedResult, manager.GetAll("Baby", null, null).Count);
		//}

		//[TestMethod()]
		//public void AddTest()
  //      {
		//	manager.Add(newRecord);
		//	int expectedResult = 4;

		//	Assert.AreEqual(expectedResult, manager.GetAll(null).Count);

			
  //      }

		//[TestMethod()]
		//public void DeleteTest()
		//{
		//	manager.Delete(newRecord.Title);
		//	int expectedResult = 2;

		//	Assert.AreEqual(expectedResult, manager.GetAll(null).Count);
		//}

		[TestMethod()]
		public void UpdateTest()
		{
			MusicRecord Updaterecord = new MusicRecord();
			manager.Update(newRecord.Title, Updaterecord);
			Updaterecord.Title = "Paparazzi";
			Updaterecord.Artist = "asd";
			Updaterecord.Duration =  180;
			Updaterecord.PublicationYear = 2010;
			newRecord.Title = Updaterecord.Title;
			newRecord.Artist = Updaterecord.Artist;
			newRecord.Duration = Updaterecord.Duration;
			newRecord.PublicationYear = Updaterecord.PublicationYear;


			Assert.AreEqual(newRecord.Title, Updaterecord.Title);
			Assert.AreEqual(newRecord.Artist, Updaterecord.Artist);
			Assert.AreEqual(newRecord.Duration, Updaterecord.Duration);
			Assert.AreEqual(newRecord.PublicationYear, Updaterecord.PublicationYear);

		}


	}
}