using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sexRP {
    public partial class Form2 : Form {

        public static Form2 instance;
        public Form2() {
            InitializeComponent();
            instance = this;
        }

        private void Form2_Load(object sender, EventArgs e) {

        }

        private void btn_create_Click(object sender, EventArgs e) {
            if(cb_pclassselect.SelectedIndex == -1) {
                Console.WriteLine("select a class first");
            } else if(tb_pplayername.Text == "") {
                Console.WriteLine("Specify a name");
            } else {
                Console.WriteLine("Creating character");

                Form1.instance.newChar.p_Charactername = tb_pplayername.Text;
                Form1.instance.newChar.p_Classid = (uint)cb_pclassselect.SelectedIndex;
                Console.WriteLine(Form1.instance.newChar.p_Charactername);

                this.DialogResult = DialogResult.OK;
            }
        }
            

    }
}
