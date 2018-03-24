using SummerIsComing.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummerIsComing {
    public class Southeros {
        private List<Kingdom> _kingdoms;
        RequestForAllegiance requestForAllegiance;
        private Kingdom _rulingKingdom;

        public Southeros(List<Kingdom> kingdoms) {
            requestForAllegiance = new RequestForAllegiance(handleRequestForAllegiance);
            _kingdoms = kingdoms;
            foreach(Kingdom kingdom in _kingdoms) {
                kingdom.SetRequestForAllegianceHandler(requestForAllegiance);
            }
        }

        public Kingdom GetRulingKingdom() {
            return _rulingKingdom;
        }

        private List<Kingdom> handleRequestForAllegiance(List<string> messages, Kingdom sender) {
            List<Kingdom> allies = new List<Kingdom>();
            foreach(string message in messages) {
                allies.AddRange(this._kingdoms.Where(kingdom => kingdom.WillPledgeAllegiance(message)));
            }
            if(allies.Count >= (this._kingdoms.Count/2)) {
                this._rulingKingdom = sender;
            }
            return allies;
        }
    }

    public delegate List<Kingdom> RequestForAllegiance(List<string> messages, Kingdom sender);
}
