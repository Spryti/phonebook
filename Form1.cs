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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registerData_Click(object sender, EventArgs e)
        {
            Reg_form reg = new Reg_form();
            reg.MdiParent = this;
            reg.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Search_form reg = new Search_form();
            reg.MdiParent = this;
            reg.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            About_Us_Form reg = new About_Us_Form();
            reg.MdiParent = this;
            reg.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.process1.StartInfo.FileName = "C:\\Windows\\System32\\calc";
            this.process1.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                registerData_Click(sender, e);
            }
            if (e.KeyCode == Keys.F3)
            {
                toolStripButton1_Click(sender, e);
            }
            if (e.KeyCode == Keys.F4)
            {
                toolStripButton2_Click(sender, e);
            }
            if (e.KeyCode == Keys.F5)
            {
                toolStripButton3_Click(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                toolStripButton4_Click(sender, e);
            }

        }
    }
}
