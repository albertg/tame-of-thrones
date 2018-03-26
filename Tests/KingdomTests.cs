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
            BaseKingdom land = new Kingdom("Land", "Panda", "Land Ruler");
            bool willAlly = land.WillPledgeAllegiance(message);
            Assert.IsTrue(willAlly);
        }

        [TestMethod]
        public void AcceptableMessageLandAltTest() {
            string message = "dnapa";
            BaseKingdom land = new Kingdom("Land", "Panda", "Land Ruler");
            bool willAlly = land.WillPledgeAllegiance(message);
            Assert.IsTrue(willAlly);
        }

        [TestMethod]
        public void AcceptableMessageLandAlt2Test() {
            string message = "ppaannddaa";
            BaseKingdom land = new Kingdom("Land", "Panda", "Land Ruler");
            bool willAlly = land.WillPledgeAllegiance(message);
            Assert.IsTrue(willAlly);
        }

        [TestMethod]
        public void UnAcceptableLandMessageTest() {
            string message = "1112223333eeefffrrr";
            BaseKingdom land = new Kingdom("Land", "Panda", "Land Ruler");
            bool willAlly = land.WillPledgeAllegiance(message);
            Assert.IsFalse(willAlly);
        }

        [TestMethod]
        public void UnAcceptableLandMessageAltTest() {
            string message = "oofffattntdffda";
            BaseKingdom land = new Kingdom("Land", "Panda", "Land Ruler");
            bool willAlly = land.WillPledgeAllegiance(message);
            Assert.IsFalse(willAlly);
        }

        [TestMethod]    
        public void AcceptableMessageIceTest() {
            string message = "Ahoy! Fight for me with men and money";
            BaseKingdom ice = new Kingdom("Ice", "Mammoth", "Ice Ruler");
            bool willAlly = ice.WillPledgeAllegiance(message);
            Assert.IsTrue(willAlly);
        }

        [TestMethod]
        public void AcceptableMessageIceAltTest() {
            string message = "maomtmh";
            BaseKingdom ice = new Kingdom("Ice", "Mammoth", "Ice Ruler");
            bool willAlly = ice.WillPledgeAllegiance(message);
            Assert.IsTrue(willAlly);
        }

        [TestMethod]
        public void AcceptableMessageIceAlt2Test() {
            string message = "mmaammmmootthh";
            BaseKingdom ice = new Kingdom("Ice", "Mammoth", "Ice Ruler");
            bool willAlly = ice.WillPledgeAllegiance(message);
            Assert.IsTrue(willAlly);
        }

        [TestMethod]
        public void UnAcceptableIceMessageTest() {
            string message = "jurgyer";
            BaseKingdom ice = new Kingdom("Ice", "Mammoth", "Ice Ruler");
            bool willAlly = ice.WillPledgeAllegiance(message);
            Assert.IsFalse(willAlly);
        }

        [TestMethod]
        public void UnAcceptableIceMessageAltTest() {
            string message = "wwertmajtgho";
            BaseKingdom ice = new Kingdom("Ice", "Mammoth", "Ice Ruler");
            bool willAlly = ice.WillPledgeAllegiance(message);
            Assert.IsFalse(willAlly);
        }

        [TestMethod]
        public void AcceptableMessageFireTest() {
            string message = "Drag on, Martin!";
            BaseKingdom fire = new Kingdom("Fire", "Dragon", "Fire Ruler");
            bool willAlly = fire.WillPledgeAllegiance(message);
            Assert.IsTrue(willAlly);
        }

        [TestMethod]
        public void AcceptableMessageFireAltTest() {
            string message = "GDORNA";
            BaseKingdom fire = new Kingdom("Fire", "Dragon", "Fire Ruler");
            bool willAlly = fire.WillPledgeAllegiance(message);
            Assert.IsTrue(willAlly);
        }

        [TestMethod]
        public void AcceptableMessageFireAlt2Test() {
            string message = "ddddrrrraaaagggoon";
            BaseKingdom fire = new Kingdom("Fire", "Dragon", "Fire Ruler");
            bool willAlly = fire.WillPledgeAllegiance(message);
            Assert.IsTrue(willAlly);
        }

        [TestMethod]
        public void UnAcceptableFireMessageTest() {
            string message = "Summer is coming";
            BaseKingdom fire = new Kingdom("Fire", "Dragon", "Fire Ruler");
            bool willAlly = fire.WillPledgeAllegiance(message);
            Assert.IsFalse(willAlly);
        }

        [TestMethod]
        public void UnAcceptableFireMessageAltTest() {
            string message = "dhytrsdgmbojhn";
            BaseKingdom fire = new Kingdom("Fire", "Dragon", "Fire Ruler");
            bool willAlly = fire.WillPledgeAllegiance(message);
            Assert.IsFalse(willAlly);
        }
    }
}
