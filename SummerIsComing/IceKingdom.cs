using SummerIsComing.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerIsComing {
    public class IceKingdom : Kingdom {
        public IceKingdom() : base() {
        }

        public override string GetEmblem() {
            return "Mammoth";
        }

        public override string GetName() {
            return "Ice";
        }

        public override string GetRuler() {
            return "Ice Ruler";
        }

        public override void InvokeAllegiance(List<string> messages) {
            throw new NotImplementedException();
        }
    }
}
