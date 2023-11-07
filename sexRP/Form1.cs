using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sexRP {
    public partial class Form1 : Form {
        public static Form1 instance;
        List<Magier> magierList = new List<Magier>();

        List<enemy> enemyList = new List<enemy>();
        

        public struct CharacterSettings {
            public string p_Charactername;
            public uint p_Classid;
        };

        public CharacterSettings newChar = new CharacterSettings();

        public Form1() {
            InitializeComponent();
            instance = this;
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void cb_pclass_SelectedIndexChanged(object sender, EventArgs e) {
            Console.WriteLine("Current selected class: " + cb_pplayer.SelectedText);
            lb_pname.Text = magierList[cb_pplayer.SelectedIndex].getName();
            lb_p_specialattack.Text = Convert.ToString(magierList[cb_pplayer.SelectedIndex].getSpecialattackdmg());

            pb_phealth.Maximum = Convert.ToInt32(magierList[cb_pplayer.SelectedIndex].getMaxHealth());
            pb_phealth.Value = Convert.ToInt32(magierList[cb_pplayer.SelectedIndex].getHealth());
            lb_attackdmg.Text = Convert.ToString(magierList[cb_pplayer.SelectedIndex].getAttackdmg());
            lb_pMoney.Text = Convert.ToString(magierList[cb_pplayer.SelectedIndex].addMoney(0));

            lb_cost.Text = Convert.ToString(magierList[cb_pplayer.SelectedIndex].getUpgradeCost());
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Form2 createCharacter = new Form2();

            if(createCharacter.ShowDialog() == DialogResult.OK) {
                Console.WriteLine(newChar.p_Charactername);
                cb_pplayer.Items.Add(newChar.p_Charactername);

                Magier temp = new Magier(newChar.p_Classid,50,newChar.p_Charactername, (uint)magierList.Count+1,15);
                magierList.Add(temp);

                Console.WriteLine("created magier");
            }
        }

        private void btn_spawnEnemy_Click(object sender, EventArgs e) {
            if(enemyList.Count != 0) {
                enemyList[enemyList.Count - 1].killPlayer();
            }

            Console.WriteLine("killed old NPC");
            enemy tempEnemy = new enemy((uint)enemyList.Count + 1, 25, 100);
            tempEnemy.setClass(1);
            tempEnemy.setName("npc");

            enemyList.Add(tempEnemy);
            
            lb_penemyclass.Text = Convert.ToString(enemyList[enemyList.Count-1].getClass());

            pb_penemyHealth.Value = enemyList[enemyList.Count-1].getHealth();
            pb_penemyshield.Maximum = enemyList[enemyList.Count - 1].getShield();
            pb_penemyshield.Value = enemyList[enemyList.Count-1].getShield();

            lb_penemyHealth.Text = Convert.ToString(enemyList[enemyList.Count-1].getHealth());
            lb_penemyShield.Text = Convert.ToString(enemyList[enemyList.Count-1].getShield());

            lb_penemyid.Text = Convert.ToString(enemyList[enemyList.Count-1].getid());
        }

        private void btn_dance_Click(object sender, EventArgs e) {
            image_dance.Visible = !(image_dance.Visible);
        }

        private void btn_pAttack_Click(object sender, EventArgs e) {

            magierList[cb_pplayer.SelectedIndex].angreifen(enemyList[enemyList.Count - 1]);

            pb_penemyHealth.Value = enemyList[enemyList.Count - 1].getHealth();
            pb_penemyshield.Value = enemyList[enemyList.Count - 1].getShield();

            lb_penemyHealth.Text = Convert.ToString(enemyList[enemyList.Count - 1].getHealth());
            lb_penemyShield.Text = Convert.ToString(enemyList[enemyList.Count - 1].getShield());

            if(enemyList[enemyList.Count - 1].getHealth() == 0) {
                magierList[cb_pplayer.SelectedIndex].addMoney(25);
            }
        }

        private void btn_pLevelup_Click(object sender, EventArgs e) {
            magierList[cb_pplayer.SelectedIndex].setSpecialattackdmg(15);
        }
    }
}
