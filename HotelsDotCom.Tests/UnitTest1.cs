using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HotelsDotCom.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private HotelsDotCom.Search search;
        [TestInitialize]
        public void ini()
        {
            search = new HotelsDotCom.Search();
            search.StartingDate = "05/25/16";
            search.EndingDate = "05/10/16";
            search.Destination = "hawai";

        }
        [TestMethod]
        public void search_srtDateTest()
        {
            Assert.AreEqual("05/25/16", search.StartingDate);
        }

        [TestMethod]
        public void search_endDateTest()
        {
            Assert.AreEqual("05/10/16", search.EndingDate);

        }
        [TestMethod]
        public void destinationTest()
        {
            Assert.AreEqual("hawai", search.Destination);

        }
    }
}
