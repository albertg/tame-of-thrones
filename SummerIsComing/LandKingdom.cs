using SummerIsComing.Abstractions;
using System.Collections.Generic;
using System.Linq;

namespace SummerIsComing {
    public class LandKingdom : Kingdom {        
        public LandKingdom() :base() {            
        }

        public override string GetRuler() {
            return "Land Ruler";
        }

        public override string GetName() {
            return "Land";
        }

        public override string GetEmblem() {
            return "Panda";
        }

        public override void InvokeAllegiance(List<string> messages) {
            throw new System.NotImplementedException();
        }
    }
}
