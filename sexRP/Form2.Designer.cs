namespace sexRP {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.cb_pclassselect = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_pplayername = new System.Windows.Forms.TextBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Klasse Wählen:";
            // 
            // cb_pclassselect
            // 
            this.cb_pclassselect.FormattingEnabled = true;
            this.cb_pclassselect.Items.AddRange(new object[] {
            "Magier"});
            this.cb_pclassselect.Location = new System.Drawing.Point(105, 6);
            this.cb_pclassselect.Name = "cb_pclassselect";
            this.cb_pclassselect.Size = new System.Drawing.Size(203, 21);
            this.cb_pclassselect.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Charakter Name:";
            // 
            // tb_pplayername
            // 
            this.tb_pplayername.Location = new System.Drawing.Point(105, 43);
            this.tb_pplayername.Name = "tb_pplayername";
            this.tb_pplayername.Size = new System.Drawing.Size(203, 20);
            this.tb_pplayername.TabIndex = 3;
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(12, 69);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(298, 45);
            this.btn_create.TabIndex = 4;
            this.btn_create.Text = "erstellen";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 126);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.tb_pplayername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_pclassselect);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "einen vollidioten erstellen";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_pclassselect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_pplayername;
        private System.Windows.Forms.Button btn_create;
    }
}