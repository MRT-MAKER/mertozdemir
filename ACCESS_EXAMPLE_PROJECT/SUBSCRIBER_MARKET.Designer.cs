namespace ACCESS_EXAMPLE_PROJECT
{
    partial class SUBSCRIBER_MARKET
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SUBSCRIBER_MARKET));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.connectionlabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.RESTART = new System.Windows.Forms.Button();
            this.BEGIN = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.newbalance = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.FIND = new System.Windows.Forms.Button();
            this.ARA = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BIRTH = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.cleanbalance = new System.Windows.Forms.Button();
            this.marketcode123 = new System.Windows.Forms.TextBox();
            this.BILL = new System.Windows.Forms.Button();
            this.STAFF = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.moneycollect = new System.Windows.Forms.TextBox();
            this.TIME = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.balance = new System.Windows.Forms.TextBox();
            this.PASSPORT = new System.Windows.Forms.TextBox();
            this.DEPART = new System.Windows.Forms.TextBox();
            this.LASTNAME = new System.Windows.Forms.TextBox();
            this.NAME = new System.Windows.Forms.TextBox();
            this.code = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TY = new System.Windows.Forms.Label();
            this.USD = new System.Windows.Forms.TextBox();
            this.POUND = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.EURO = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.eurusd = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // connectionlabel
            // 
            this.connectionlabel.AutoSize = true;
            this.connectionlabel.Location = new System.Drawing.Point(35, 79);
            this.connectionlabel.Name = "connectionlabel";
            this.connectionlabel.Size = new System.Drawing.Size(125, 20);
            this.connectionlabel.TabIndex = 52;
            this.connectionlabel.Text = "CONNECTION ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(7, 104);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(178, 28);
            this.comboBox1.TabIndex = 51;
            // 
            // RESTART
            // 
            this.RESTART.BackColor = System.Drawing.Color.DarkOrange;
            this.RESTART.Location = new System.Drawing.Point(7, 177);
            this.RESTART.Margin = new System.Windows.Forms.Padding(4);
            this.RESTART.Name = "RESTART";
            this.RESTART.Size = new System.Drawing.Size(177, 35);
            this.RESTART.TabIndex = 49;
            this.RESTART.Text = "RESTART";
            this.RESTART.UseVisualStyleBackColor = false;
            this.RESTART.Click += new System.EventHandler(this.RESTART_Click);
            // 
            // BEGIN
            // 
            this.BEGIN.BackColor = System.Drawing.Color.DarkOrange;
            this.BEGIN.Location = new System.Drawing.Point(7, 136);
            this.BEGIN.Margin = new System.Windows.Forms.Padding(4);
            this.BEGIN.Name = "BEGIN";
            this.BEGIN.Size = new System.Drawing.Size(177, 35);
            this.BEGIN.TabIndex = 48;
            this.BEGIN.Text = "BEGIN";
            this.BEGIN.UseVisualStyleBackColor = false;
            this.BEGIN.Click += new System.EventHandler(this.BEGIN_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.eurusd);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.EURO);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.POUND);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.newbalance);
            this.groupBox1.Controls.Add(this.USD);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.TY);
            this.groupBox1.Controls.Add(this.exit);
            this.groupBox1.Controls.Add(this.FIND);
            this.groupBox1.Controls.Add(this.ARA);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.connectionlabel);
            this.groupBox1.Controls.Add(this.BIRTH);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.balance);
            this.groupBox1.Controls.Add(this.RESTART);
            this.groupBox1.Controls.Add(this.BEGIN);
            this.groupBox1.Controls.Add(this.PASSPORT);
            this.groupBox1.Controls.Add(this.DEPART);
            this.groupBox1.Controls.Add(this.LASTNAME);
            this.groupBox1.Controls.Add(this.NAME);
            this.groupBox1.Controls.Add(this.code);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            this.groupBox1.Location = new System.Drawing.Point(6, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1348, 325);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SUBSCRIBER";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(955, 36);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(260, 279);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 63;
            this.pictureBox3.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.Location = new System.Drawing.Point(8, 215);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 35);
            this.button1.TabIndex = 62;
            this.button1.Text = "CLOSE PORT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // newbalance
            // 
            this.newbalance.Location = new System.Drawing.Point(336, 280);
            this.newbalance.Margin = new System.Windows.Forms.Padding(4);
            this.newbalance.Name = "newbalance";
            this.newbalance.Size = new System.Drawing.Size(175, 27);
            this.newbalance.TabIndex = 59;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Info;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.label8.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label8.Location = new System.Drawing.Point(194, 286);
            this.label8.Margin = new System.Windows.Forms.Padding(1, 1, 3, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 19);
            this.label8.TabIndex = 58;
            this.label8.Text = "NEW BALANCE";
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.DarkOrange;
            this.exit.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.exit.Location = new System.Drawing.Point(8, 22);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(124, 39);
            this.exit.TabIndex = 57;
            this.exit.Text = "MAIN MENU";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // FIND
            // 
            this.FIND.BackColor = System.Drawing.Color.DarkOrange;
            this.FIND.Location = new System.Drawing.Point(7, 258);
            this.FIND.Margin = new System.Windows.Forms.Padding(4);
            this.FIND.Name = "FIND";
            this.FIND.Size = new System.Drawing.Size(100, 28);
            this.FIND.TabIndex = 1;
            this.FIND.Text = "FIND";
            this.FIND.UseVisualStyleBackColor = false;
            // 
            // ARA
            // 
            this.ARA.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ARA.Location = new System.Drawing.Point(7, 290);
            this.ARA.Margin = new System.Windows.Forms.Padding(4);
            this.ARA.Multiline = true;
            this.ARA.Name = "ARA";
            this.ARA.Size = new System.Drawing.Size(177, 25);
            this.ARA.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(518, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 281);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // BIRTH
            // 
            this.BIRTH.Location = new System.Drawing.Point(336, 131);
            this.BIRTH.Margin = new System.Windows.Forms.Padding(4);
            this.BIRTH.Name = "BIRTH";
            this.BIRTH.Size = new System.Drawing.Size(175, 27);
            this.BIRTH.TabIndex = 39;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.cleanbalance);
            this.groupBox2.Controls.Add(this.marketcode123);
            this.groupBox2.Controls.Add(this.BILL);
            this.groupBox2.Controls.Add(this.STAFF);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.moneycollect);
            this.groupBox2.Controls.Add(this.TIME);
            this.groupBox2.Controls.Add(this.ID);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.groupBox2.Location = new System.Drawing.Point(719, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 281);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PAYMENT SELECTION";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Desktop;
            this.button2.Location = new System.Drawing.Point(72, 191);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 45);
            this.button2.TabIndex = 62;
            this.button2.Text = "PAY";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cleanbalance
            // 
            this.cleanbalance.BackColor = System.Drawing.Color.Coral;
            this.cleanbalance.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cleanbalance.Location = new System.Drawing.Point(125, 141);
            this.cleanbalance.Name = "cleanbalance";
            this.cleanbalance.Size = new System.Drawing.Size(83, 35);
            this.cleanbalance.TabIndex = 61;
            this.cleanbalance.Text = "CLEAN";
            this.cleanbalance.UseVisualStyleBackColor = false;
            this.cleanbalance.Click += new System.EventHandler(this.cleanbalance_Click);
            // 
            // marketcode123
            // 
            this.marketcode123.Location = new System.Drawing.Point(10, 203);
            this.marketcode123.Name = "marketcode123";
            this.marketcode123.Size = new System.Drawing.Size(14, 28);
            this.marketcode123.TabIndex = 60;
            this.marketcode123.Visible = false;
            // 
            // BILL
            // 
            this.BILL.BackColor = System.Drawing.SystemColors.Desktop;
            this.BILL.Location = new System.Drawing.Point(33, 141);
            this.BILL.Name = "BILL";
            this.BILL.Size = new System.Drawing.Size(83, 35);
            this.BILL.TabIndex = 60;
            this.BILL.Text = "TRIO";
            this.BILL.UseVisualStyleBackColor = false;
            this.BILL.Click += new System.EventHandler(this.BILL_Click);
            // 
            // STAFF
            // 
            this.STAFF.Location = new System.Drawing.Point(30, 52);
            this.STAFF.Margin = new System.Windows.Forms.Padding(4);
            this.STAFF.Name = "STAFF";
            this.STAFF.Size = new System.Drawing.Size(175, 28);
            this.STAFF.TabIndex = 59;
            this.STAFF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Underline);
            this.label10.Location = new System.Drawing.Point(56, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 19);
            this.label10.TabIndex = 58;
            this.label10.Text = "ACTIVE STAFF";
            // 
            // moneycollect
            // 
            this.moneycollect.Location = new System.Drawing.Point(30, 88);
            this.moneycollect.Margin = new System.Windows.Forms.Padding(4);
            this.moneycollect.Name = "moneycollect";
            this.moneycollect.Size = new System.Drawing.Size(175, 28);
            this.moneycollect.TabIndex = 43;
            this.moneycollect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TIME
            // 
            this.TIME.Location = new System.Drawing.Point(49, 246);
            this.TIME.Margin = new System.Windows.Forms.Padding(4);
            this.TIME.Name = "TIME";
            this.TIME.Size = new System.Drawing.Size(177, 28);
            this.TIME.TabIndex = 55;
            this.TIME.Text = "TIME";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(30, 203);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(14, 28);
            this.ID.TabIndex = 46;
            this.ID.Visible = false;
            // 
            // balance
            // 
            this.balance.Location = new System.Drawing.Point(336, 239);
            this.balance.Margin = new System.Windows.Forms.Padding(4);
            this.balance.Name = "balance";
            this.balance.Size = new System.Drawing.Size(175, 27);
            this.balance.TabIndex = 42;
            // 
            // PASSPORT
            // 
            this.PASSPORT.Location = new System.Drawing.Point(336, 167);
            this.PASSPORT.Margin = new System.Windows.Forms.Padding(4);
            this.PASSPORT.Name = "PASSPORT";
            this.PASSPORT.Size = new System.Drawing.Size(175, 27);
            this.PASSPORT.TabIndex = 40;
            // 
            // DEPART
            // 
            this.DEPART.Location = new System.Drawing.Point(336, 203);
            this.DEPART.Margin = new System.Windows.Forms.Padding(4);
            this.DEPART.Name = "DEPART";
            this.DEPART.Size = new System.Drawing.Size(175, 27);
            this.DEPART.TabIndex = 41;
            // 
            // LASTNAME
            // 
            this.LASTNAME.Location = new System.Drawing.Point(336, 95);
            this.LASTNAME.Margin = new System.Windows.Forms.Padding(4);
            this.LASTNAME.Name = "LASTNAME";
            this.LASTNAME.Size = new System.Drawing.Size(175, 27);
            this.LASTNAME.TabIndex = 38;
            // 
            // NAME
            // 
            this.NAME.Location = new System.Drawing.Point(336, 59);
            this.NAME.Margin = new System.Windows.Forms.Padding(4);
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(175, 27);
            this.NAME.TabIndex = 37;
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(336, 23);
            this.code.Margin = new System.Windows.Forms.Padding(4);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(175, 27);
            this.code.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Info;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(265, 140);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 1, 3, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 35;
            this.label5.Text = "BIRTH";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Info;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(236, 245);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 1, 3, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 19);
            this.label7.TabIndex = 34;
            this.label7.Text = "BALANCE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Info;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(214, 210);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 1, 3, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 19);
            this.label6.TabIndex = 33;
            this.label6.Text = "DEPARMENT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(234, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 1, 3, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "PASSPORT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(225, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 1, 3, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 19);
            this.label3.TabIndex = 31;
            this.label3.Text = "LASTNAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(264, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 1, 3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(267, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 1, 3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 29;
            this.label1.Text = "CODE";
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(6, 323);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1348, 402);
            this.groupBox3.TabIndex = 54;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PAYED MEMBERS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Desktop;
            this.dataGridView1.Location = new System.Drawing.Point(6, 27);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1335, 348);
            this.dataGridView1.TabIndex = 0;
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // TY
            // 
            this.TY.AutoSize = true;
            this.TY.BackColor = System.Drawing.SystemColors.Info;
            this.TY.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.TY.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TY.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TY.Location = new System.Drawing.Point(1233, 41);
            this.TY.Margin = new System.Windows.Forms.Padding(1, 1, 3, 2);
            this.TY.Name = "TY";
            this.TY.Size = new System.Drawing.Size(77, 19);
            this.TY.TabIndex = 55;
            this.TY.Text = "TRY/USD";
            // 
            // USD
            // 
            this.USD.Location = new System.Drawing.Point(1233, 67);
            this.USD.Margin = new System.Windows.Forms.Padding(4);
            this.USD.Name = "USD";
            this.USD.Size = new System.Drawing.Size(108, 27);
            this.USD.TabIndex = 56;
            this.USD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // POUND
            // 
            this.POUND.Location = new System.Drawing.Point(1233, 127);
            this.POUND.Margin = new System.Windows.Forms.Padding(4);
            this.POUND.Name = "POUND";
            this.POUND.Size = new System.Drawing.Size(108, 27);
            this.POUND.TabIndex = 58;
            this.POUND.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Info;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.label9.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(1233, 101);
            this.label9.Margin = new System.Windows.Forms.Padding(1, 1, 3, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 19);
            this.label9.TabIndex = 57;
            this.label9.Text = "TRY/POUND";
            // 
            // EURO
            // 
            this.EURO.Location = new System.Drawing.Point(1233, 187);
            this.EURO.Margin = new System.Windows.Forms.Padding(4);
            this.EURO.Name = "EURO";
            this.EURO.Size = new System.Drawing.Size(108, 27);
            this.EURO.TabIndex = 60;
            this.EURO.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Info;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.label11.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(1233, 161);
            this.label11.Margin = new System.Windows.Forms.Padding(1, 1, 3, 2);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 19);
            this.label11.TabIndex = 59;
            this.label11.Text = "TRY/EURO";
            // 
            // eurusd
            // 
            this.eurusd.Location = new System.Drawing.Point(1233, 256);
            this.eurusd.Margin = new System.Windows.Forms.Padding(4);
            this.eurusd.Name = "eurusd";
            this.eurusd.Size = new System.Drawing.Size(108, 27);
            this.eurusd.TabIndex = 65;
            this.eurusd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Info;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.label12.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(1233, 230);
            this.label12.Margin = new System.Windows.Forms.Padding(1, 1, 3, 2);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 19);
            this.label12.TabIndex = 64;
            this.label12.Text = "EUR/USD";
            // 
            // SUBSCRIBER_MARKET
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1355, 698);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SUBSCRIBER_MARKET";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SUBSCRIBER_PAYMENT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SUBSCRIBER_MARKET_FormClosing);
            this.Load += new System.EventHandler(this.SUBSCRIBER_PAYMENT_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label connectionlabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button RESTART;
        private System.Windows.Forms.Button BEGIN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox BIRTH;
        private System.Windows.Forms.TextBox balance;
        private System.Windows.Forms.TextBox PASSPORT;
        private System.Windows.Forms.TextBox DEPART;
        private System.Windows.Forms.TextBox LASTNAME;
        private System.Windows.Forms.TextBox NAME;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox ARA;
        private System.Windows.Forms.Button FIND;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox TIME;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox moneycollect;
        public System.Windows.Forms.TextBox STAFF;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox newbalance;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox marketcode123;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BILL;
        private System.Windows.Forms.Button cleanbalance;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label TY;
        private System.Windows.Forms.TextBox USD;
        private System.Windows.Forms.TextBox EURO;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox POUND;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox eurusd;
        private System.Windows.Forms.Label label12;
    }
}