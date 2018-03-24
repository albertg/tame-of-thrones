using SummerIsComing.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerIsComing {
    public class FireKingdom : Kingdom {
        public FireKingdom() :base() {
        }

        public override string GetRuler() {
            return "Fire Ruler";
        }

        public override string GetName() {
            return "Fire";
        }

        public override string GetEmblem() {
            return "Dragon";
        }

        public override void InvokeAllegiance(List<string> messages) {
            throw new NotImplementedException();
        }
    }
}
