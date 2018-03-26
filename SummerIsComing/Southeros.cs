using SummerIsComing.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerIsComing {
    public class Southeros {
        private List<BaseKingdom> _kingdoms;
        RequestForAllegiance requestForAllegiance;
        private BaseKingdom _rulingKingdom;

        public Southeros(List<BaseKingdom> kingdoms) {
            requestForAllegiance = new RequestForAllegiance(handleRequestForAllegiance);
            _kingdoms = kingdoms;
            foreach(BaseKingdom kingdom in _kingdoms) {
                kingdom.SetRequestForAllegianceHandler(requestForAllegiance);
            }
        }

        public BaseKingdom GetRulingKingdom() {
            return _rulingKingdom;
        }

        private List<BaseKingdom> handleRequestForAllegiance(List<string> messages, BaseKingdom sender) {
            List<BaseKingdom> allies = new List<BaseKingdom>();
            foreach(string message in messages) {
                allies.AddRange(this._kingdoms.Where(kingdom => kingdom.WillPledgeAllegiance(message)));
            }
            if(allies.Count >= (this._kingdoms.Count/2)) {
                this._rulingKingdom = sender;
            }
            return allies;
        }
    }

    public delegate List<BaseKingdom> RequestForAllegiance(List<string> messages, BaseKingdom sender);
}
