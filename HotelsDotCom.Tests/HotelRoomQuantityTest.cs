using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HotelsDotCom.Tests
{
    [TestClass]
    public class HotelRoomQuantityTest
    {
        private HotelsDotCom.HotelRoomQuantity hrq;

        [TestInitialize]
        public void init()
        {
            hrq = new HotelsDotCom.HotelRoomQuantity();
            hrq.Quantity = 17;
            hrq.TotalRooms = 12;
            hrq.AvailableRooms = 6;
        }
        [TestMethod]
        public void hrq_QuantityTest()
        {
            Assert.AreEqual(17, hrq.Quantity);
        }

        [TestMethod]
        public void hrq_TotalRoomsTest()
        {
            Assert.AreEqual(12, hrq.TotalRooms);

        }
        [TestMethod]
        public void hrq_AvaialbleRoomsTest()
        {
            Assert.AreEqual(6, hrq.AvailableRooms);

        }
    }
}
