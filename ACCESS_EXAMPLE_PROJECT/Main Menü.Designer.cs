namespace ACCESS_EXAMPLE_PROJECT
{
    partial class mainmenu
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
            this.topastsystem = new System.Windows.Forms.Button();
            this.tosubscribermanagement = new System.Windows.Forms.Button();
            this.tomarket = new System.Windows.Forms.Button();
            this.menuactivestaff = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.exittologin = new System.Windows.Forms.Button();
            this.menucode = new System.Windows.Forms.TextBox();
            this.admincontrol = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // topastsystem
            // 
            this.topastsystem.BackColor = System.Drawing.SystemColors.HotTrack;
            this.topastsystem.Location = new System.Drawing.Point(30, 146);
            this.topastsystem.Name = "topastsystem";
            this.topastsystem.Size = new System.Drawing.Size(188, 46);
            this.topastsystem.TabIndex = 0;
            this.topastsystem.Text = "PAST SYSTEM";
            this.topastsystem.UseVisualStyleBackColor = false;
            this.topastsystem.Click += new System.EventHandler(this.topastsystem_Click);
            // 
            // tosubscribermanagement
            // 
            this.tosubscribermanagement.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tosubscribermanagement.Location = new System.Drawing.Point(30, 203);
            this.tosubscribermanagement.Name = "tosubscribermanagement";
            this.tosubscribermanagement.Size = new System.Drawing.Size(188, 46);
            this.tosubscribermanagement.TabIndex = 1;
            this.tosubscribermanagement.Text = "SUBSCRIBER MANAGEMENT";
            this.tosubscribermanagement.UseVisualStyleBackColor = false;
            this.tosubscribermanagement.Click += new System.EventHandler(this.tosubscribermanagement_Click);
            // 
            // tomarket
            // 
            this.tomarket.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tomarket.Location = new System.Drawing.Point(30, 260);
            this.tomarket.Name = "tomarket";
            this.tomarket.Size = new System.Drawing.Size(188, 46);
            this.tomarket.TabIndex = 2;
            this.tomarket.Text = "SUBSCRIBER MARKET";
            this.tomarket.UseVisualStyleBackColor = false;
            this.tomarket.Click += new System.EventHandler(this.tomarket_Click);
            // 
            // menuactivestaff
            // 
            this.menuactivestaff.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.menuactivestaff.Location = new System.Drawing.Point(30, 51);
            this.menuactivestaff.Margin = new System.Windows.Forms.Padding(4);
            this.menuactivestaff.Name = "menuactivestaff";
            this.menuactivestaff.Size = new System.Drawing.Size(188, 27);
            this.menuactivestaff.TabIndex = 55;
            this.menuactivestaff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Desktop;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(62, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 19);
            this.label10.TabIndex = 54;
            this.label10.Text = "ACTIVE STAFF";
            // 
            // exittologin
            // 
            this.exittologin.BackColor = System.Drawing.Color.OrangeRed;
            this.exittologin.Location = new System.Drawing.Point(30, 317);
            this.exittologin.Name = "exittologin";
            this.exittologin.Size = new System.Drawing.Size(188, 46);
            this.exittologin.TabIndex = 56;
            this.exittologin.Text = "EXIT TO LOGIN";
            this.exittologin.UseVisualStyleBackColor = false;
            this.exittologin.Click += new System.EventHandler(this.exittologin_Click);
            // 
            // menucode
            // 
            this.menucode.Location = new System.Drawing.Point(193, 10);
            this.menucode.Name = "menucode";
            this.menucode.Size = new System.Drawing.Size(17, 27);
            this.menucode.TabIndex = 57;
            this.menucode.Visible = false;
            // 
            // admincontrol
            // 
            this.admincontrol.BackColor = System.Drawing.SystemColors.HotTrack;
            this.admincontrol.Location = new System.Drawing.Point(30, 89);
            this.admincontrol.Name = "admincontrol";
            this.admincontrol.Size = new System.Drawing.Size(188, 46);
            this.admincontrol.TabIndex = 58;
            this.admincontrol.Text = "ADMIN";
            this.admincontrol.UseVisualStyleBackColor = false;
            this.admincontrol.Click += new System.EventHandler(this.admincontrol_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(30, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 46);
            this.button1.TabIndex = 59;
            this.button1.Text = "EXIT ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainmenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(248, 436);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.admincontrol);
            this.Controls.Add(this.menucode);
            this.Controls.Add(this.exittologin);
            this.Controls.Add(this.menuactivestaff);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tomarket);
            this.Controls.Add(this.tosubscribermanagement);
            this.Controls.Add(this.topastsystem);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Name = "mainmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.TransparencyKey = System.Drawing.Color.ForestGreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainmenu_FormClosed);
            this.Load += new System.EventHandler(this.Main_Menü_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button topastsystem;
        private System.Windows.Forms.Button tosubscribermanagement;
        private System.Windows.Forms.Button tomarket;
        public System.Windows.Forms.TextBox menuactivestaff;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button exittologin;
        public System.Windows.Forms.TextBox menucode;
        private System.Windows.Forms.Button admincontrol;
        private System.Windows.Forms.Button button1;
    }
}