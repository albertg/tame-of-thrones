using Microsoft.VisualStudio.TestTools.UnitTesting;
using SummerIsComing;
using SummerIsComing.Abstractions;
using System.Collections.Generic;

namespace Tests {
    [TestClass]
    public class SoutherosTests {
        [TestMethod]
        public void SoutherosHasNoRulerTest() {
            List<Kingdom> kingdoms = new List<Kingdom>();
            Kingdom space = new SpaceKingdom();
            kingdoms.Add(space);
            kingdoms.Add(new LandKingdom());
            kingdoms.Add(new WaterKingdom());
            kingdoms.Add(new IceKingdom());
            kingdoms.Add(new AirKingdom());
            kingdoms.Add(new FireKingdom());

            List<string> messages = new List<string>();
            messages.Add("111111");
            messages.Add("2222222");
            messages.Add("33333333");

            Southeros universe = new Southeros(kingdoms);
            space.InvokeAllegiance(messages);

            Assert.IsNull(universe.GetRulingKingdom());
        }

        [TestMethod]
        public void SoutherosHasASpaceRulerTest() {
            List<Kingdom> kingdoms = new List<Kingdom>();
            Kingdom space = new SpaceKingdom();
            kingdoms.Add(space);
            kingdoms.Add(new LandKingdom());
            kingdoms.Add(new WaterKingdom());
            kingdoms.Add(new IceKingdom());
            kingdoms.Add(new AirKingdom());
            kingdoms.Add(new FireKingdom());

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
