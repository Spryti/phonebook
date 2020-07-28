using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phoneBook_ns
{
    public partial class Reg_form : Form
    {
        public Reg_form()
        {
            InitializeComponent();
        }

        private void newData_Click(object sender, EventArgs e)
        {
            this.newData.Enabled = false;
            this.saveData.Enabled = true;
            this.infoBox.Enabled = true;
            //Clear TextBoxes
            this.firstNameBox.ResetText();
            this.lastNameBox.ResetText();
            this.cell.ResetText();
            this.email.ResetText();
            this.comment.ResetText();
            this.address.ResetText();
        }

        private void saveData_Click(object sender, EventArgs e)
        {
            if (this.firstNameBox.Text == "")
            {
                MessageBox.Show("You must enter your first name.");
            }
            
            this.saveData.Enabled = false;
            this.newData.Enabled = true;
            this.infoBox.Enabled = false;
            //Saving Data
            string fn;
            fn = "phonebook_info\\";
            string p;
            //------------First NAme------------
            p = fn + this.firstNameBox.Text + "_fn.txt";
            System.IO.File.WriteAllText(p, this.firstNameBox.Text, Encoding.UTF8);
            //--------------Last Name-----------
            p = fn + this.firstNameBox.Text + "_ln.txt";
            System.IO.File.WriteAllText(p, this.lastNameBox.Text, Encoding.UTF8);
            //--------------Cell----------------
            p = fn + this.firstNameBox.Text + "_cp.txt";
            System.IO.File.WriteAllText(p, this.cell.Text, Encoding.UTF8);
            //-------------Email----------------
            p = fn + this.firstNameBox.Text + "_em.txt";
            System.IO.File.WriteAllText(p, this.email.Text, Encoding.UTF8);
            //-------------Address--------------
            p = fn + this.firstNameBox.Text + "_ad.txt";
            System.IO.File.WriteAllText(p, this.address.Text, Encoding.UTF8);
            //-------------Comment-------------
            p = fn + this.firstNameBox.Text + "_cm.txt";
            System.IO.File.WriteAllText(p, this.comment.Text, Encoding.UTF8);
            //-------------If saved--------------
            MessageBox.Show("Saved Successfully!");

        }

        private void infoBox_Enter(object sender, EventArgs e)
        {

        }

        private void Reg_form_Load(object sender, EventArgs e)
        {
            this.infoBox.Enabled = false;
        }
    }
} 