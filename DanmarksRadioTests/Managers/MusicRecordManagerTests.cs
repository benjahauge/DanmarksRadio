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
		[TestMethod()]
		public void GetAllTest()
		{
			int expectedResult = 3;

			Assert.AreEqual(expectedResult, manager.GetAll().Count);
		}

		[TestMethod()]
		public void GetAllWithParametersTest()
		{
			int expectedResult = 1;

			Assert.AreEqual(expectedResult, manager.GetAll("Baby", null, null).Count);
		}

		[TestMethod()]
		public void AddTest()
        {
			MusicRecord musicrecord = new MusicRecord() { Title = "The Bones", Artist = "Maren Morris", Duration = 200, PublicationYear = 2019 };
			manager.Add(musicrecord);
			int expectedResult = 4;

			Assert.AreEqual(expectedResult, manager.GetAll(null).Count);

			
        }

		//[TestMethod()]
		//public void DeleteTest()
  //      {
		//	MusicRecord musicrecord = new MusicRecord() { Title = "Baby" };
		//	manager.Delete(musicrecord.Title);
		//	int expectedResult = 2;

		//	Assert.AreEqual(expectedResult, manager.GetAll(null).Count);
  //      }

	}
}