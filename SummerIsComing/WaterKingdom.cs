using SummerIsComing.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerIsComing {
    public class WaterKingdom : Kingdom{
        public WaterKingdom() :base() {
        }

        public override string GetRuler() {
            return "Water Ruler";
        }

        public override string GetName() {
            return "Water";
        }

        public override string GetEmblem() {
            return "Octopus";
        }

        public override void InvokeAllegiance(List<string> messages) {
            throw new NotImplementedException();
        }
    }
}
