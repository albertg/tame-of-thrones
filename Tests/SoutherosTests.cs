using Microsoft.VisualStudio.TestTools.UnitTesting;
using SummerIsComing;
using SummerIsComing.Abstractions;
using System.Collections.Generic;

namespace Tests {
    [TestClass]
    public class SoutherosTests {
        [TestMethod]
        public void SoutherosHasNoRulerTest()
        {
            List<BaseKingdom> kingdoms = new List<BaseKingdom>();
            BaseKingdom space = new Kingdom("Space", "Gorilla", "Shan");
            kingdoms.Add(space);
            kingdoms.Add(new Kingdom("Land","Panda","Land Ruler"));
            kingdoms.Add(new Kingdom("Water", "Octopus", "Water Ruler"));
            kingdoms.Add(new Kingdom("Ice", "Mammoth", "Ice Ruler"));
            kingdoms.Add(new Kingdom("Air", "Owl", "Air Ruler"));
            kingdoms.Add(new Kingdom("Fire", "Dragon", "Fire Ruler"));

            List<string> messages = new List<string>();
            messages.Add("111111");
            messages.Add("2222222");
            messages.Add("33333333");

            Southeros universe = new Southeros(kingdoms);
            space.InvokeAllegiance(messages);

            Assert.IsNull(universe.GetRulingKingdom());
        }

        [TestMethod]
        public void SoutherosHasASpaceRulerTest()
        {
            List<BaseKingdom> kingdoms = new List<BaseKingdom>();
            BaseKingdom space = new Kingdom("Space", "Gorilla", "Shan");
            kingdoms.Add(space);
            kingdoms.Add(new Kingdom("Land", "Panda", "Land Ruler"));
            kingdoms.Add(new Kingdom("Water", "Octopus", "Water Ruler"));
            kingdoms.Add(new Kingdom("Ice", "Mammoth", "Ice Ruler"));
            kingdoms.Add(new Kingdom("Air", "Owl", "Air Ruler"));
            kingdoms.Add(new Kingdom("Fire", "Dragon", "Fire Ruler"));

            List<string> messages = new List<string>();
            messages.Add("oaaawaala");
            messages.Add("a1d22n333a4444p");
            messages.Add("zmzmzmzaztzozh");

            Southeros universe = new Southeros(kingdoms);
            space.InvokeAllegiance(messages);

            Assert.IsNotNull(universe.GetRulingKingdom());
            Assert.IsNotNull(universe.GetRulingKingdom().GetAllies());
            Assert.AreSame("Space", universe.GetRulingKingdom().GetName());
            Assert.AreSame("Shan", universe.GetRulingKingdom().GetRuler());
        }
    }
}
