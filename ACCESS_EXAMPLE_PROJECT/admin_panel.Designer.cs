namespace ACCESS_EXAMPLE_PROJECT
{
    partial class admin_panel
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.admincode = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adminname = new System.Windows.Forms.TextBox();
            this.adminpassword = new System.Windows.Forms.TextBox();
            this.adminlastname = new System.Windows.Forms.TextBox();
            this.adminstaff = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "ADD STAFF";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(162, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(219, 170);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(9, 268);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 233);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "CODE";
            // 
            // admincode
            // 
            this.admincode.FormattingEnabled = true;
            this.admincode.Location = new System.Drawing.Point(12, 66);
            this.admincode.Name = "admincode";
            this.admincode.Size = new System.Drawing.Size(133, 24);
            this.admincode.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "LASTNAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "PASSWORD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(678, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "ACTIVE STAFF";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(770, 227);
            this.dataGridView1.TabIndex = 11;
            // 
            // adminname
            // 
            this.adminname.Location = new System.Drawing.Point(12, 111);
            this.adminname.Name = "adminname";
            this.adminname.Size = new System.Drawing.Size(133, 22);
            this.adminname.TabIndex = 12;
            // 
            // adminpassword
            // 
            this.adminpassword.Location = new System.Drawing.Point(12, 223);
            this.adminpassword.Name = "adminpassword";
            this.adminpassword.Size = new System.Drawing.Size(133, 22);
            this.adminpassword.TabIndex = 13;
            // 
            // adminlastname
            // 
            this.adminlastname.Location = new System.Drawing.Point(12, 167);
            this.adminlastname.Name = "adminlastname";
            this.adminlastname.Size = new System.Drawing.Size(133, 22);
            this.adminlastname.TabIndex = 13;
            // 
            // adminstaff
            // 
            this.adminstaff.Location = new System.Drawing.Point(646, 74);
            this.adminstaff.Name = "adminstaff";
            this.adminstaff.Size = new System.Drawing.Size(133, 22);
            this.adminstaff.TabIndex = 14;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(690, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "MAIN MENU";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // admin_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.adminstaff);
            this.Controls.Add(this.adminlastname);
            this.Controls.Add(this.adminpassword);
            this.Controls.Add(this.adminname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.admincode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "admin_panel";
            this.Text = "admin_panel";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox admincode;
        private System.Windows.Forms.TextBox adminname;
        private System.Windows.Forms.TextBox adminpassword;
        private System.Windows.Forms.TextBox adminlastname;
        private System.Windows.Forms.TextBox adminstaff;
        private System.Windows.Forms.Button button4;
    }
}