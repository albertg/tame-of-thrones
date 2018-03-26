using System.Collections.Generic;
using System.Linq;

namespace SummerIsComing.Abstractions {
    public abstract class BaseKingdom {
        string _name;
        string _emblem;        
        string _ruler;

        private Dictionary<char, int> emblemSeq;
        protected RequestForAllegiance Handler;
        protected List<BaseKingdom> Allies;

        public string GetName()
        {
            return this._name;
        }
        public string GetEmblem()
        {
            return this._emblem;
        }
        public string GetRuler()
        {
            return this._ruler;
        }
        public void InvokeAllegiance(List<string> messages)
        {
            this.Allies = this.Handler(messages, this);
        }        

        public BaseKingdom(string name, string emblem, string ruler) {
            this._name = name;
            this._emblem = emblem;
            this._ruler = ruler;
            identifyEmblemSequence();
        }

        public List<BaseKingdom> GetAllies() {
            return this.Allies;
        }

        public bool WillPledgeAllegiance(string message) {
            Dictionary<char, int> processedMessageDictionary = new Dictionary<char, int>();

            foreach (KeyValuePair<char, int> kvp in emblemSeq) {
                processedMessageDictionary.Add(kvp.Key, message.ToLower().Split(kvp.Key).Length - 1);
            }

            return emblemSeq.Where(seq => !(processedMessageDictionary[seq.Key] >= seq.Value))
                            .Count() == 0;
        }

        public void SetRequestForAllegianceHandler(RequestForAllegiance handler) {
            this.Handler = handler;
        }

        private void identifyEmblemSequence() {
            emblemSeq = new Dictionary<char, int>();
            char[] emblemCharArray = GetEmblem().ToLower().ToCharArray();
            /*  For each unique character in the emblem, keep track of the duplicates
                For instance 'p' in the emblem is not repeated
                But 'a' in the emblem is repeated twice
                The logic below fills the emblemSeq dictioanry as : [p] = 1, [a] = 2, [n] = 1, [d] = 1*/
            for (int i = 0; i < emblemCharArray.Length; i++) {
                if (emblemSeq.Keys.Contains(emblemCharArray[i])) {
                    //The key already exists in the dictionary. increment the corresponding value
                    emblemSeq[emblemCharArray[i]] = ++emblemSeq[emblemCharArray[i]];
                }
                else {
                    emblemSeq[emblemCharArray[i]] = 1;
                }
            }
        }
    }
}
