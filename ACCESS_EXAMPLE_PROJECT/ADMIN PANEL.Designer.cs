namespace ACCESS_EXAMPLE_PROJECT
{
    partial class CABLE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CABLE));
            this.INSERT = new System.Windows.Forms.Button();
            this.cablecode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cablename = new System.Windows.Forms.TextBox();
            this.cablepassword = new System.Windows.Forms.TextBox();
            this.cablelastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cabletime = new System.Windows.Forms.TextBox();
            this.cableid = new System.Windows.Forms.TextBox();
            this.cablestaff = new System.Windows.Forms.TextBox();
            this.cablecode1 = new System.Windows.Forms.TextBox();
            this.turnmainmenü = new System.Windows.Forms.Button();
            this.UPDATE = new System.Windows.Forms.Button();
            this.DELETE = new System.Windows.Forms.Button();
            this.CLEAN = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // INSERT
            // 
            this.INSERT.BackColor = System.Drawing.Color.Gold;
            this.INSERT.Location = new System.Drawing.Point(335, 60);
            this.INSERT.Name = "INSERT";
            this.INSERT.Size = new System.Drawing.Size(109, 34);
            this.INSERT.TabIndex = 0;
            this.INSERT.Text = "INSERT";
            this.INSERT.UseVisualStyleBackColor = false;
            this.INSERT.Click += new System.EventHandler(this.INSERT_Click);
            // 
            // cablecode
            // 
            this.cablecode.Location = new System.Drawing.Point(150, 133);
            this.cablecode.Name = "cablecode";
            this.cablecode.Size = new System.Drawing.Size(167, 27);
            this.cablecode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "CODE";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(740, 286);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 378);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 313);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LIST OF ADMIN";
            // 
            // cablename
            // 
            this.cablename.Location = new System.Drawing.Point(150, 193);
            this.cablename.Name = "cablename";
            this.cablename.Size = new System.Drawing.Size(167, 27);
            this.cablename.TabIndex = 2;
            // 
            // cablepassword
            // 
            this.cablepassword.Location = new System.Drawing.Point(150, 313);
            this.cablepassword.Name = "cablepassword";
            this.cablepassword.Size = new System.Drawing.Size(167, 27);
            this.cablepassword.TabIndex = 4;
            // 
            // cablelastname
            // 
            this.cablelastname.Location = new System.Drawing.Point(150, 253);
            this.cablelastname.Name = "cablelastname";
            this.cablelastname.Size = new System.Drawing.Size(167, 27);
            this.cablelastname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "LASTNAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "PASSWORD";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cabletime
            // 
            this.cabletime.Location = new System.Drawing.Point(150, 76);
            this.cabletime.Name = "cabletime";
            this.cabletime.Size = new System.Drawing.Size(167, 27);
            this.cabletime.TabIndex = 12;
            // 
            // cableid
            // 
            this.cableid.Location = new System.Drawing.Point(40, 102);
            this.cableid.Name = "cableid";
            this.cableid.Size = new System.Drawing.Size(10, 27);
            this.cableid.TabIndex = 13;
            this.cableid.Visible = false;
            // 
            // cablestaff
            // 
            this.cablestaff.Location = new System.Drawing.Point(150, 25);
            this.cablestaff.Name = "cablestaff";
            this.cablestaff.Size = new System.Drawing.Size(167, 27);
            this.cablestaff.TabIndex = 14;
            // 
            // cablecode1
            // 
            this.cablecode1.Location = new System.Drawing.Point(25, 102);
            this.cablecode1.Name = "cablecode1";
            this.cablecode1.Size = new System.Drawing.Size(10, 27);
            this.cablecode1.TabIndex = 15;
            this.cablecode1.Visible = false;
            // 
            // turnmainmenü
            // 
            this.turnmainmenü.BackColor = System.Drawing.Color.Orange;
            this.turnmainmenü.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.turnmainmenü.Location = new System.Drawing.Point(472, 12);
            this.turnmainmenü.Name = "turnmainmenü";
            this.turnmainmenü.Size = new System.Drawing.Size(127, 33);
            this.turnmainmenü.TabIndex = 16;
            this.turnmainmenü.Text = "MAIN MENU";
            this.turnmainmenü.UseVisualStyleBackColor = false;
            this.turnmainmenü.Click += new System.EventHandler(this.turnmainmenü_Click);
            // 
            // UPDATE
            // 
            this.UPDATE.BackColor = System.Drawing.Color.Gold;
            this.UPDATE.Location = new System.Drawing.Point(335, 136);
            this.UPDATE.Name = "UPDATE";
            this.UPDATE.Size = new System.Drawing.Size(109, 34);
            this.UPDATE.TabIndex = 17;
            this.UPDATE.Text = "UPDATE";
            this.UPDATE.UseVisualStyleBackColor = false;
            this.UPDATE.Click += new System.EventHandler(this.UPDATE_Click);
            // 
            // DELETE
            // 
            this.DELETE.BackColor = System.Drawing.Color.Gold;
            this.DELETE.Location = new System.Drawing.Point(335, 212);
            this.DELETE.Name = "DELETE";
            this.DELETE.Size = new System.Drawing.Size(109, 34);
            this.DELETE.TabIndex = 18;
            this.DELETE.Text = "DELETE";
            this.DELETE.UseVisualStyleBackColor = false;
            this.DELETE.Click += new System.EventHandler(this.DELETE_Click);
            // 
            // CLEAN
            // 
            this.CLEAN.BackColor = System.Drawing.Color.Gold;
            this.CLEAN.Location = new System.Drawing.Point(335, 288);
            this.CLEAN.Name = "CLEAN";
            this.CLEAN.Size = new System.Drawing.Size(109, 34);
            this.CLEAN.TabIndex = 19;
            this.CLEAN.Text = "CLEAN";
            this.CLEAN.UseVisualStyleBackColor = false;
            this.CLEAN.Click += new System.EventHandler(this.CLEAN_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cablecode1);
            this.groupBox2.Controls.Add(this.cablepassword);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cableid);
            this.groupBox2.Controls.Add(this.CLEAN);
            this.groupBox2.Controls.Add(this.DELETE);
            this.groupBox2.Controls.Add(this.cabletime);
            this.groupBox2.Controls.Add(this.cablecode);
            this.groupBox2.Controls.Add(this.UPDATE);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cablestaff);
            this.groupBox2.Controls.Add(this.cablename);
            this.groupBox2.Controls.Add(this.cablelastname);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.INSERT);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 365);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PERSONEL";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 19);
            this.label5.TabIndex = 56;
            this.label5.Text = "TIME:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 19);
            this.label6.TabIndex = 57;
            this.label6.Text = "ACTIVE STAFF:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(472, 52);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(286, 319);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 55;
            this.pictureBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(631, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 33);
            this.button1.TabIndex = 56;
            this.button1.Text = "EXIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CABLE
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(762, 703);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.turnmainmenü);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CABLE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMIN PANEL";
            this.Load += new System.EventHandler(this.KABLE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button INSERT;
        private System.Windows.Forms.TextBox cablecode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox cablename;
        private System.Windows.Forms.TextBox cablepassword;
        private System.Windows.Forms.TextBox cablelastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox cabletime;
        private System.Windows.Forms.TextBox cableid;
        public System.Windows.Forms.TextBox cablestaff;
        public System.Windows.Forms.TextBox cablecode1;
        private System.Windows.Forms.Button turnmainmenü;
        private System.Windows.Forms.Button UPDATE;
        private System.Windows.Forms.Button DELETE;
        private System.Windows.Forms.Button CLEAN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
    }
}