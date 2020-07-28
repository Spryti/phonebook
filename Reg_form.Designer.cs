namespace phoneBook_ns
{
    partial class Reg_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reg_form));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.newData = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveData = new System.Windows.Forms.ToolStripButton();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cell = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comment = new System.Windows.Forms.TextBox();
            this.infoBox = new System.Windows.Forms.GroupBox();
            this.toolStrip1.SuspendLayout();
            this.infoBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.newData,
            this.toolStripSeparator2,
            this.saveData});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(461, 61);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 61);
            // 
            // newData
            // 
            this.newData.Image = ((System.Drawing.Image)(resources.GetObject("newData.Image")));
            this.newData.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newData.Name = "newData";
            this.newData.Size = new System.Drawing.Size(94, 58);
            this.newData.Text = "New Data";
            this.newData.Click += new System.EventHandler(this.newData_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 61);
            // 
            // saveData
            // 
            this.saveData.Enabled = false;
            this.saveData.Image = ((System.Drawing.Image)(resources.GetObject("saveData.Image")));
            this.saveData.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.saveData.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveData.Name = "saveData";
            this.saveData.Size = new System.Drawing.Size(94, 58);
            this.saveData.Text = "Save Data";
            this.saveData.Click += new System.EventHandler(this.saveData_Click);
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(106, 19);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(238, 20);
            this.firstNameBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last Name:";
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(106, 55);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(238, 20);
            this.lastNameBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cell phone:";
            // 
            // cell
            // 
            this.cell.Location = new System.Drawing.Point(106, 100);
            this.cell.Name = "cell";
            this.cell.Size = new System.Drawing.Size(238, 20);
            this.cell.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email:";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(106, 143);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(238, 20);
            this.email.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Address:";
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(106, 191);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(238, 20);
            this.address.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Comment:";
            // 
            // comment
            // 
            this.comment.Location = new System.Drawing.Point(106, 237);
            this.comment.Name = "comment";
            this.comment.Size = new System.Drawing.Size(238, 20);
            this.comment.TabIndex = 11;
            // 
            // infoBox
            // 
            this.infoBox.Controls.Add(this.label6);
            this.infoBox.Controls.Add(this.comment);
            this.infoBox.Controls.Add(this.label5);
            this.infoBox.Controls.Add(this.address);
            this.infoBox.Controls.Add(this.label4);
            this.infoBox.Controls.Add(this.email);
            this.infoBox.Controls.Add(this.label3);
            this.infoBox.Controls.Add(this.cell);
            this.infoBox.Controls.Add(this.label2);
            this.infoBox.Controls.Add(this.lastNameBox);
            this.infoBox.Controls.Add(this.label1);
            this.infoBox.Controls.Add(this.firstNameBox);
            this.infoBox.Enabled = false;
            this.infoBox.Location = new System.Drawing.Point(11, 81);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(387, 315);
            this.infoBox.TabIndex = 13;
            this.infoBox.TabStop = false;
            this.infoBox.Text = "groupBox1";
            this.infoBox.Enter += new System.EventHandler(this.infoBox_Enter);
            // 
            // Reg_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(461, 482);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.toolStrip1);
            this.MinimizeBox = false;
            this.Name = "Reg_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Data";
            this.Load += new System.EventHandler(this.Reg_form_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.infoBox.ResumeLayout(false);
            this.infoBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton newData;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton saveData;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cell;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox comment;
        private System.Windows.Forms.GroupBox infoBox;
    }
}