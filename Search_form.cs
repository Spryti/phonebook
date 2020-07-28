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
    public partial class Search_form : Form
    {
        public Search_form()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (this.searchButton.Text == "")
            {
                MessageBox.Show("You must enter a someone's first name to search.");
            }
            string fn;
            fn = "phonebook_info\\";
            string p;
            string r;
            //------------First NAme------------
            p = fn + this.searchBox.Text + "_fn.txt";
            r = System.IO.File.ReadAllText(p, Encoding.UTF8);
            this.firstNameBox.Text = r;
            //System.IO.File.WriteAllText(p, this.firstNameBox.Text, Encoding.UTF8);
            //--------------Last Name-----------
            p = fn + this.searchBox.Text + "_ln.txt";
            r = System.IO.File.ReadAllText(p, Encoding.UTF8);
            this.lastNameBox.Text = r;
            // System.IO.File.WriteAllText(p, this.lastNameBox.Text, Encoding.UTF8);
            //--------------Cell----------------
            p = fn + this.searchBox.Text + "_cp.txt";
            r = System.IO.File.ReadAllText(p, Encoding.UTF8);
            this.cell.Text = r;
            //System.IO.File.WriteAllText(p, this.cell.Text, Encoding.UTF8);
            //-------------Email----------------
            p = fn + this.searchBox.Text + "_em.txt";
            r = System.IO.File.ReadAllText(p, Encoding.UTF8);
            this.email.Text = r;
            //System.IO.File.WriteAllText(p, this.email.Text, Encoding.UTF8);
            //-------------Address--------------
            p = fn + this.searchBox.Text + "_ad.txt";
            r = System.IO.File.ReadAllText(p, Encoding.UTF8);
            this.address.Text = r;
            //System.IO.File.WriteAllText(p, this.address.Text, Encoding.UTF8);
            //-------------Comment-------------
            p = fn + this.searchBox.Text + "_cm.txt";
            r = System.IO.File.ReadAllText(p, Encoding.UTF8);
            this.comment.Text = r;
            //System.IO.File.WriteAllText(p, this.comment.Text, Encoding.UTF8);

        }
    }
}
