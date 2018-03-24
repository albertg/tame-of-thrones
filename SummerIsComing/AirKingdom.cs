using SummerIsComing.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerIsComing {
    public class AirKingdom : Kingdom {
        public AirKingdom() :base() {
        }

        public override string GetRuler() {
            return "Air Ruler";
        }

        public override string GetName() {
            return "Air";
        }

        public override string GetEmblem() {
            return "Owl";
        }

        public override void InvokeAllegiance(List<string> messages) {
            throw new NotImplementedException();
        }
    }
}
