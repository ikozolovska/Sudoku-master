using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Options : Form
    {
        public Form1 form;

        public Options(Form1 f) 
        {
            InitializeComponent();
            form = f;
        }

        public Options()
        {
            InitializeComponent();
        }

        public string getChecked()
        {
            if (cbYes.Checked == true)
            {
                return "Yes";
            }
            return "No";
        }

        public string getSelected()
        {
            if (rbtnNone.Checked == true)
            {
                return "None";
            }
            else if (rbtnSimple.Checked == true)
            {
                return "Simple";
            }
            else if (rbtnPou.Checked == true)
            {
                return "Pou";
            }
            else
            {
                return "Maid";
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            if((cbNo.Checked == false  && cbYes.Checked == false) || (cbNo.Checked == true && cbYes.Checked == true))
            {
                MessageBox.Show("You must check exactly ONE option from the Hints menu", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                form.setOptions(this);
                this.Close();
                form.Show();
            }            
        }

        private void Options_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ((cbNo.Checked == false && cbYes.Checked == false) || (cbNo.Checked == true && cbYes.Checked == true))
            {
                MessageBox.Show("You must check exactly ONE option from the Hints menu. THE DEFAULT VALUE IS \"Show hints\"", "Important Note", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbYes.Checked = true;
                form.Show();            
            }
            else
            {
                form.Show();
            }
        }

        
    }
}
