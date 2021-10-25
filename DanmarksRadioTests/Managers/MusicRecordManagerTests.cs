using Microsoft.VisualStudio.TestTools.UnitTesting;
using DanmarksRadio.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
	}
}