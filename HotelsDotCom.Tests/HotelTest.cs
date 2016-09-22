using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HotelsDotCom.Tests
{
    [TestClass]
    public class HotelTest
    {
        private HotelsDotCom.Hotel h;
        [TestInitialize]
        public void ini()
        {
            h = new HotelsDotCom.Hotel();
            h.hotel_name = "Himilton";
            h.image = "room.jpg";
            h.cities = "Brampton";

        }

        [TestMethod]
        public void h_hotel_nameTest()
        {
            Assert.AreEqual("Himilton", h.hotel_name);
        }

        [TestMethod]
        public void h_imageTest()
        {
            Assert.AreEqual("room.jpg", h.image);

        }
        [TestMethod]
        public void h_citiesTest()
        {
            Assert.AreEqual("Brampton", h.cities);

        }
    }
}
