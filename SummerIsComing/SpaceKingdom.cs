using SummerIsComing.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerIsComing {
    public class SpaceKingdom : Kingdom{
        public SpaceKingdom() :base() {
        }

        public override string GetRuler() {
            return "Shan";
        }

        public override string GetName() {
            return "Space";
        }

        public override string GetEmblem() {
            return "Gorilla";
        }

        public override void InvokeAllegiance(List<string> messages) {
            base.Allies = this.Handler(messages, this);
        }
    }
}
