using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sexRP {
    internal class BasePlayer {
        protected string p_name;
        protected int p_health;
        protected uint p_class;
        protected int p_attackdmg;
        protected uint p_id;
        protected uint p_maxhealth;
        protected int p_money;

        public BasePlayer(uint id, int atkdmg, uint maxHealth) {
            p_id = id;
            p_attackdmg = atkdmg;
            p_maxhealth = maxHealth;
            p_health = (int)maxHealth;
            p_money = 5;
        }

        public int addMoney(int amount) {
            p_money += amount;
            return p_money;
        }

        public int getAttackdmg() {
            return p_attackdmg;
        }

        public void laufen() {
            Console.WriteLine("Character " + p_name + " ist gelaufen");
        }

        public void springen() {
            Console.WriteLine("Character " + p_name + " ist gesprungen");
        }

        public int angreifen(enemy enemyName) {
            int p_damageDealt = p_attackdmg; // cahgne later, done
            Console.WriteLine("Character " + p_name + " hat angegriffen");

            if(enemyName.getShield() >= 0) {
                enemyName.setHealth(enemyName.getHealth() - p_attackdmg);
            } else {
                if(enemyName.getShield() < p_damageDealt) {
                    enemyName.setShield(0);
                } else {
                    enemyName.setShield(enemyName.getShield() - p_attackdmg);
                }
            }

            if(enemyName.getHealth() < p_attackdmg) {
                enemyName.setHealth(0);
                enemyName.killPlayer();
            }

            return p_damageDealt;
        }

        public uint getid() {
            return p_id;
        }

        public void tanzen() {
            Console.WriteLine("Character " + p_name + " hat getanzt");
        }

        public string getName() {
            return p_name;
        }

        public int getHealth() {
            return p_health;
        }

        public void setName(string name) {
            p_name = name;
        }

        public void setHealth(int health) {
            p_health = health;
        }

        public uint getClass() {
            return p_class;
        }

        public void setClass(uint classid) {
            p_class = classid;
        }

        public uint getMaxHealth() {
            return p_maxhealth;
        }

        public void setMaxHealth(uint maxhealth) {
            p_maxhealth = maxhealth;
        }
    }
}
