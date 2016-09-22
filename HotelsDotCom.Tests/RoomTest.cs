using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HotelsDotCom.Tests
{
    [TestClass]
    public class RoomTest
    {
        private HotelsDotCom.Room room;
        [TestInitialize]
        public void ini()
        {
            room = new HotelsDotCom.Room();
            room.room_id = "1";
            room.hotel_name = "Brampton";
            room.room_type = "President";

        }
        [TestMethod]
        public void room_idTest()
        {
            Assert.AreEqual("1", room.room_id);
        }

        [TestMethod]
        public void room_hotel_nameTest()
        {
            Assert.AreEqual("Brampton", room.hotel_name);

        }
        [TestMethod]
        public void room_typeTest()
        {
            Assert.AreEqual("President", room.room_type);

        }
    }
}
