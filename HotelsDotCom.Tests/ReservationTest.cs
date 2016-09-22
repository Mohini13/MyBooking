using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HotelsDotCom.Tests
{
    [TestClass]
    public class ReservationTest
    {
        private Reservation r;
        [TestInitialize]
        public void ini()
        {
            r = new Reservation();
            r.h_name = "hi";
            // rs = new RoomService(rsv);
            r.r_id = 1;
            r.c_id = 2;
            r.r_type = "simple";
            r.starting = "3-3-2016";
            r.ending = "5-5-2016";
            r.quantity = 3;
            r.spCost = 250;
            r.spDescription = ":)";
        }
        [TestMethod]
        public void nameTest()
        {
            Assert.AreEqual("hi", r.h_name);
        }

        [TestMethod]
        public void reservationPriceTest()
        {
            Assert.AreEqual(0, r.cost());

        }
        [TestMethod]
        public void spacialReqTest()
        {
            Assert.AreEqual("", r.specialRequirement());

        }

        [TestMethod]
        public void r_id_Test()
        {
            Assert.AreEqual(1, r.r_id);

        }
        [TestMethod]
        public void c_id_Test()
        {
            Assert.AreEqual(2, r.c_id);

        }

        [TestMethod]
        public void r_type_Test()
        {
            Assert.AreEqual("simple", r.r_type);

        }
        [TestMethod]
        public void r_starting_Test()
        {
            Assert.AreEqual("3-3-2016", r.starting);

        }
        [TestMethod]
        public void r_ending_Test()
        {
            Assert.AreEqual("5-5-2016", r.ending);

        }
        [TestMethod]
        public void quantity_Test()
        {
            Assert.AreEqual(3, r.quantity);

        }
        [TestMethod]
        public void r_spcost_Test()
        {
            Assert.AreEqual(250, r.spCost);

        }
        [TestMethod]
        public void r_spDesc_Test()
        {
            Assert.AreEqual(":)", r.spDescription);

        }
    }
}
