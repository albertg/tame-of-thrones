using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SummerIsComing.Abstractions;
using SummerIsComing;

namespace Tests {
    [TestClass]
    public class KingdomTests {
        [TestMethod]
        public void AcceptableMessageLandTest() {
            string message = "a1d22n333a4444p";
            Kingdom land = new LandKingdom();
            bool willAlly = land.WillPledgeAllegiance(message);
            Assert.IsTrue(willAlly);
        }

        [TestMethod]
        public void AcceptableMessageLandAltTest() {
            string message = "dnapa";
            Kingdom land = new LandKingdom();
            bool willAlly = land.WillPledgeAllegiance(message);
            Assert.IsTrue(willAlly);
        }

        [TestMethod]
        public void AcceptableMessageLandAlt2Test() {
            string message = "ppaannddaa";
            Kingdom land = new LandKingdom();
            bool willAlly = land.WillPledgeAllegiance(message);
            Assert.IsTrue(willAlly);
        }

        [TestMethod]
        public void UnAcceptableLandMessageTest() {
            string message = "1112223333eeefffrrr";
            Kingdom land = new LandKingdom();
            bool willAlly = land.WillPledgeAllegiance(message);
            Assert.IsFalse(willAlly);
        }

        [TestMethod]
        public void UnAcceptableLandMessageAltTest() {
            string message = "oofffattntdffda";
            Kingdom land = new LandKingdom();
            bool willAlly = land.WillPledgeAllegiance(message);
            Assert.IsFalse(willAlly);
        }

        [TestMethod]
        public void AcceptableMessageIceTest() {
            string message = "Ahoy! Fight for me with men and money";
            Kingdom ice = new IceKingdom();
            bool willAlly = ice.WillPledgeAllegiance(message);
            Assert.IsTrue(willAlly);
        }

        [TestMethod]
        public void AcceptableMessageIceAltTest() {
            string message = "maomtmh";
            Kingdom ice = new IceKingdom();
            bool willAlly = ice.WillPledgeAllegiance(message);
            Assert.IsTrue(willAlly);
        }

        [TestMethod]
        public void AcceptableMessageIceAlt2Test() {
            string message = "mmaammmmootthh";
            Kingdom ice = new IceKingdom();
            bool willAlly = ice.WillPledgeAllegiance(message);
            Assert.IsTrue(willAlly);
        }

        [TestMethod]
        public void UnAcceptableIceMessageTest() {
            string message = "jurgyer";
            Kingdom ice = new IceKingdom();
            bool willAlly = ice.WillPledgeAllegiance(message);
            Assert.IsFalse(willAlly);
        }

        [TestMethod]
        public void UnAcceptableIceMessageAltTest() {
            string message = "wwertmajtgho";
            Kingdom ice = new IceKingdom();
            bool willAlly = ice.WillPledgeAllegiance(message);
            Assert.IsFalse(willAlly);
        }

        [TestMethod]
        public void AcceptableMessageFireTest() {
            string message = "Drag on, Martin!";
            Kingdom fire = new FireKingdom();
            bool willAlly = fire.WillPledgeAllegiance(message);
            Assert.IsTrue(willAlly);
        }

        [TestMethod]
        public void AcceptableMessageFireAltTest() {
            string message = "GDORNA";
            Kingdom fire = new FireKingdom();
            bool willAlly = fire.WillPledgeAllegiance(message);
            Assert.IsTrue(willAlly);
        }

        [TestMethod]
        public void AcceptableMessageFireAlt2Test() {
            string message = "ddddrrrraaaagggoon";
            Kingdom fire = new FireKingdom();
            bool willAlly = fire.WillPledgeAllegiance(message);
            Assert.IsTrue(willAlly);
        }

        [TestMethod]
        public void UnAcceptableFireMessageTest() {
            string message = "fth33489jb";
            Kingdom fire = new FireKingdom();
            bool willAlly = fire.WillPledgeAllegiance(message);
            Assert.IsFalse(willAlly);
        }

        [TestMethod]
        public void UnAcceptableFireMessageAltTest() {
            string message = "dhytrsdgmbojhn";
            Kingdom fire = new FireKingdom();
            bool willAlly = fire.WillPledgeAllegiance(message);
            Assert.IsFalse(willAlly);
        }
    }
}
