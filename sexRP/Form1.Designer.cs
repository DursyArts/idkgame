namespace sexRP {
    partial class Form1 {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pb_phealth = new System.Windows.Forms.ProgressBar();
            this.pb_pmana = new System.Windows.Forms.ProgressBar();
            this.cb_pplayer = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_pAttack = new System.Windows.Forms.Button();
            this.btn_dance = new System.Windows.Forms.Button();
            this.btn_spawnEnemy = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_p_specialattack = new System.Windows.Forms.Label();
            this.lb_attackdmg = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_pname = new System.Windows.Forms.Label();
            this.pb_penemyHealth = new System.Windows.Forms.ProgressBar();
            this.pb_penemyshield = new System.Windows.Forms.ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_penemyclass = new System.Windows.Forms.Label();
            this.lb_penemyShield = new System.Windows.Forms.Label();
            this.lb_penemyHealth = new System.Windows.Forms.Label();
            this.btn_pLevelup = new System.Windows.Forms.Button();
            this.lb_pMoney = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.image_dance = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_cost = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lb_penemyid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.image_dance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 454);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Leben:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 512);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Character:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 483);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mana:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pb_phealth
            // 
            this.pb_phealth.Location = new System.Drawing.Point(103, 444);
            this.pb_phealth.Name = "pb_phealth";
            this.pb_phealth.Size = new System.Drawing.Size(211, 23);
            this.pb_phealth.TabIndex = 4;
            // 
            // pb_pmana
            // 
            this.pb_pmana.Location = new System.Drawing.Point(103, 473);
            this.pb_pmana.Name = "pb_pmana";
            this.pb_pmana.Size = new System.Drawing.Size(211, 23);
            this.pb_pmana.TabIndex = 5;
            // 
            // cb_pplayer
            // 
            this.cb_pplayer.FormattingEnabled = true;
            this.cb_pplayer.Location = new System.Drawing.Point(103, 509);
            this.cb_pplayer.Name = "cb_pplayer";
            this.cb_pplayer.Size = new System.Drawing.Size(211, 21);
            this.cb_pplayer.TabIndex = 6;
            this.cb_pplayer.SelectedIndexChanged += new System.EventHandler(this.cb_pclass_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 536);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "laufen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(184, 536);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "springen";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_pAttack
            // 
            this.btn_pAttack.Location = new System.Drawing.Point(103, 565);
            this.btn_pAttack.Name = "btn_pAttack";
            this.btn_pAttack.Size = new System.Drawing.Size(75, 23);
            this.btn_pAttack.TabIndex = 9;
            this.btn_pAttack.Text = "angreifen";
            this.btn_pAttack.UseVisualStyleBackColor = true;
            this.btn_pAttack.Click += new System.EventHandler(this.btn_pAttack_Click);
            // 
            // btn_dance
            // 
            this.btn_dance.Location = new System.Drawing.Point(184, 565);
            this.btn_dance.Name = "btn_dance";
            this.btn_dance.Size = new System.Drawing.Size(75, 23);
            this.btn_dance.TabIndex = 10;
            this.btn_dance.Text = "tanzen";
            this.btn_dance.UseVisualStyleBackColor = true;
            this.btn_dance.Click += new System.EventHandler(this.btn_dance_Click);
            // 
            // btn_spawnEnemy
            // 
            this.btn_spawnEnemy.Location = new System.Drawing.Point(744, 502);
            this.btn_spawnEnemy.Name = "btn_spawnEnemy";
            this.btn_spawnEnemy.Size = new System.Drawing.Size(128, 23);
            this.btn_spawnEnemy.TabIndex = 11;
            this.btn_spawnEnemy.Text = "spawn enemy";
            this.btn_spawnEnemy.UseVisualStyleBackColor = true;
            this.btn_spawnEnemy.Click += new System.EventHandler(this.btn_spawnEnemy_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(457, 291);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(203, 21);
            this.comboBox2.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "getötete wichser:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 616);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "spezialangriff:";
            // 
            // lb_p_specialattack
            // 
            this.lb_p_specialattack.AutoSize = true;
            this.lb_p_specialattack.Location = new System.Drawing.Point(100, 616);
            this.lb_p_specialattack.Name = "lb_p_specialattack";
            this.lb_p_specialattack.Size = new System.Drawing.Size(82, 13);
            this.lb_p_specialattack.TabIndex = 15;
            this.lb_p_specialattack.Text = "p_specialattack";
            // 
            // lb_attackdmg
            // 
            this.lb_attackdmg.AutoSize = true;
            this.lb_attackdmg.Location = new System.Drawing.Point(120, 591);
            this.lb_attackdmg.Name = "lb_attackdmg";
            this.lb_attackdmg.Size = new System.Drawing.Size(27, 13);
            this.lb_attackdmg.TabIndex = 16;
            this.lb_attackdmg.Text = "dmg";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(320, 512);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(85, 13);
            this.linkLabel1.TabIndex = 17;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "create character";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 650);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "name:";
            // 
            // lb_pname
            // 
            this.lb_pname.AutoSize = true;
            this.lb_pname.Location = new System.Drawing.Point(100, 650);
            this.lb_pname.Name = "lb_pname";
            this.lb_pname.Size = new System.Drawing.Size(47, 13);
            this.lb_pname.TabIndex = 19;
            this.lb_pname.Text = "p_Name";
            // 
            // pb_penemyHealth
            // 
            this.pb_penemyHealth.Location = new System.Drawing.Point(744, 291);
            this.pb_penemyHealth.Name = "pb_penemyHealth";
            this.pb_penemyHealth.Size = new System.Drawing.Size(281, 49);
            this.pb_penemyHealth.TabIndex = 21;
            // 
            // pb_penemyshield
            // 
            this.pb_penemyshield.Location = new System.Drawing.Point(744, 428);
            this.pb_penemyshield.Name = "pb_penemyshield";
            this.pb_penemyshield.Size = new System.Drawing.Size(281, 39);
            this.pb_penemyshield.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(698, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Leben:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(698, 444);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Mana:";
            // 
            // lb_penemyclass
            // 
            this.lb_penemyclass.AutoSize = true;
            this.lb_penemyclass.Location = new System.Drawing.Point(878, 507);
            this.lb_penemyclass.Name = "lb_penemyclass";
            this.lb_penemyclass.Size = new System.Drawing.Size(65, 13);
            this.lb_penemyclass.TabIndex = 25;
            this.lb_penemyclass.Text = "enemy class";
            // 
            // lb_penemyShield
            // 
            this.lb_penemyShield.AutoSize = true;
            this.lb_penemyShield.Location = new System.Drawing.Point(878, 444);
            this.lb_penemyShield.Name = "lb_penemyShield";
            this.lb_penemyShield.Size = new System.Drawing.Size(34, 13);
            this.lb_penemyShield.TabIndex = 26;
            this.lb_penemyShield.Text = "shield";
            // 
            // lb_penemyHealth
            // 
            this.lb_penemyHealth.AutoSize = true;
            this.lb_penemyHealth.Location = new System.Drawing.Point(878, 314);
            this.lb_penemyHealth.Name = "lb_penemyHealth";
            this.lb_penemyHealth.Size = new System.Drawing.Size(38, 13);
            this.lb_penemyHealth.TabIndex = 27;
            this.lb_penemyHealth.Text = "Health";
            // 
            // btn_pLevelup
            // 
            this.btn_pLevelup.Location = new System.Drawing.Point(188, 611);
            this.btn_pLevelup.Name = "btn_pLevelup";
            this.btn_pLevelup.Size = new System.Drawing.Size(75, 23);
            this.btn_pLevelup.TabIndex = 28;
            this.btn_pLevelup.Text = "increase";
            this.btn_pLevelup.UseVisualStyleBackColor = true;
            this.btn_pLevelup.Click += new System.EventHandler(this.btn_pLevelup_Click);
            // 
            // lb_pMoney
            // 
            this.lb_pMoney.AutoSize = true;
            this.lb_pMoney.Location = new System.Drawing.Point(100, 663);
            this.lb_pMoney.Name = "lb_pMoney";
            this.lb_pMoney.Size = new System.Drawing.Size(51, 13);
            this.lb_pMoney.TabIndex = 30;
            this.lb_pMoney.Text = "p_Money";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 663);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "geld:";
            // 
            // image_dance
            // 
            this.image_dance.Image = global::sexRP.Properties.Resources.R;
            this.image_dance.Location = new System.Drawing.Point(283, 536);
            this.image_dance.Name = "image_dance";
            this.image_dance.Size = new System.Drawing.Size(377, 169);
            this.image_dance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image_dance.TabIndex = 31;
            this.image_dance.TabStop = false;
            this.image_dance.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::sexRP.Properties.Resources._39247700aee8529413bfa9cf8eb066f9;
            this.pictureBox2.Location = new System.Drawing.Point(744, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(348, 484);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sexRP.Properties.Resources.Anime_Miku_Hatsune_Download_Transparent_PNG_Image;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(326, 426);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(185, 637);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "cost:";
            // 
            // lb_cost
            // 
            this.lb_cost.AutoSize = true;
            this.lb_cost.Location = new System.Drawing.Point(221, 637);
            this.lb_cost.Name = "lb_cost";
            this.lb_cost.Size = new System.Drawing.Size(10, 13);
            this.lb_cost.TabIndex = 33;
            this.lb_cost.Text = "-";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(810, 557);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "id:";
            // 
            // lb_penemyid
            // 
            this.lb_penemyid.AutoSize = true;
            this.lb_penemyid.Location = new System.Drawing.Point(831, 557);
            this.lb_penemyid.Name = "lb_penemyid";
            this.lb_penemyid.Size = new System.Drawing.Size(10, 13);
            this.lb_penemyid.TabIndex = 35;
            this.lb_penemyid.Text = ".";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 717);
            this.Controls.Add(this.lb_penemyid);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lb_cost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.image_dance);
            this.Controls.Add(this.lb_pMoney);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_pLevelup);
            this.Controls.Add(this.lb_penemyHealth);
            this.Controls.Add(this.lb_penemyShield);
            this.Controls.Add(this.lb_penemyclass);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pb_penemyshield);
            this.Controls.Add(this.pb_penemyHealth);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lb_pname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lb_attackdmg);
            this.Controls.Add(this.lb_p_specialattack);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.btn_spawnEnemy);
            this.Controls.Add(this.btn_dance);
            this.Controls.Add(this.btn_pAttack);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_pplayer);
            this.Controls.Add(this.pb_pmana);
            this.Controls.Add(this.pb_phealth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.image_dance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar pb_phealth;
        private System.Windows.Forms.ProgressBar pb_pmana;
        private System.Windows.Forms.ComboBox cb_pplayer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_pAttack;
        private System.Windows.Forms.Button btn_dance;
        private System.Windows.Forms.Button btn_spawnEnemy;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_p_specialattack;
        private System.Windows.Forms.Label lb_attackdmg;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_pname;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ProgressBar pb_penemyHealth;
        private System.Windows.Forms.ProgressBar pb_penemyshield;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_penemyclass;
        private System.Windows.Forms.Label lb_penemyShield;
        private System.Windows.Forms.Label lb_penemyHealth;
        private System.Windows.Forms.Button btn_pLevelup;
        private System.Windows.Forms.Label lb_pMoney;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox image_dance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_cost;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lb_penemyid;
    }
}

