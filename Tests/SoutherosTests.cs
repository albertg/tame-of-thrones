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
            messages.Add("Let’s swing the sword together");
            messages.Add("Die or play the tame of thrones");
            messages.Add("Ahoy! Fight for me with men and money");
            messages.Add("Summer is coming");
            messages.Add("Drag on Martin!");

            Southeros universe = new Southeros(kingdoms);
            space.InvokeAllegiance(messages);

            Assert.IsNotNull(universe.GetRulingKingdom());
            Assert.IsNotNull(universe.GetRulingKingdom().GetAllies());
            Assert.AreEqual(4, universe.GetRulingKingdom().GetAllies().Count);
            Assert.AreSame("Space", universe.GetRulingKingdom().GetName());
            Assert.AreSame("Shan", universe.GetRulingKingdom().GetRuler());
        }
    }
}
