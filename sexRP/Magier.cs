using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sexRP {
    class Magier : BasePlayer{
        private int p_specialattackdmg;
        private int upgradeCost;
        
        public Magier(uint classID, uint Health, string CharacterName, uint id, int atkdmg) : base(id, atkdmg, Health) {
            setClass(classID);
            //setHealth(Health);
            setName(CharacterName);
            p_specialattackdmg = 15;
            upgradeCost = 25;
        }

        public int getSpecialattackdmg() {
            return p_specialattackdmg;
        }

        public void setSpecialattackdmg(int specialattackdmg) {
            this.p_specialattackdmg = specialattackdmg;
        }

        public int getUpgradeCost() {
            return upgradeCost;
        }

        public void addUpgradeCost(int amount) {
            upgradeCost += amount;
        }
    }
}
