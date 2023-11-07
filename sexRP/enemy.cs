using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sexRP {
    class enemy : BasePlayer{
        private int p_shield;
        private bool p_isDead;

        public enemy(uint id, int atkdmg, uint maxHealth) : base(id, atkdmg, maxHealth) {
            Random r = new Random();
            int random = r.Next(0,100);
            if(random < 50) {
                p_shield = random;
            } else {
                p_shield = 0;
            }

            p_isDead = false;
        }

        public int getShield() {
            return p_shield;
        }

        public void setShield(int shield) {
            this.p_shield = shield;
        }

        public bool killPlayer() {
            p_isDead=true;
            return p_isDead;
        }
    }
}