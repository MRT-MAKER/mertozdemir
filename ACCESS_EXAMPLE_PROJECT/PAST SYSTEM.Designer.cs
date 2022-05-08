namespace ACCESS_EXAMPLE_PROJECT
{
    partial class PASTSYSTEM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PASTSYSTEM));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pastcode123 = new System.Windows.Forms.TextBox();
            this.FIND = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SAVE = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.STAFF = new System.Windows.Forms.TextBox();
            this.TIME = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BIRTH = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BALANCE = new System.Windows.Forms.TextBox();
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.mainmenubtn = new System.Windows.Forms.Button();
            this.connectionlabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.RESTART = new System.Windows.Forms.Button();
            this.BEGIN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.pastcode123);
            this.groupBox1.Controls.Add(this.FIND);
            this.groupBox1.Controls.Add(this.search);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.SAVE);
            this.groupBox1.Controls.Add(this.ID);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.STAFF);
            this.groupBox1.Controls.Add(this.TIME);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.BIRTH);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.BALANCE);
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
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(177, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1039, 320);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SUBSCRIBER";
            // 
            // pastcode123
            // 
            this.pastcode123.Location = new System.Drawing.Point(185, 184);
            this.pastcode123.Name = "pastcode123";
            this.pastcode123.Size = new System.Drawing.Size(14, 27);
            this.pastcode123.TabIndex = 65;
            this.pastcode123.Visible = false;
            // 
            // FIND
            // 
            this.FIND.BackColor = System.Drawing.Color.DarkOrange;
            this.FIND.Location = new System.Drawing.Point(1, 266);
            this.FIND.Margin = new System.Windows.Forms.Padding(4);
            this.FIND.Name = "FIND";
            this.FIND.Size = new System.Drawing.Size(100, 28);
            this.FIND.TabIndex = 64;
            this.FIND.Text = "SEARCH";
            this.FIND.UseVisualStyleBackColor = false;
            this.FIND.Click += new System.EventHandler(this.FIND_Click);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.SystemColors.MenuBar;
            this.search.Location = new System.Drawing.Point(1, 295);
            this.search.Margin = new System.Windows.Forms.Padding(4);
            this.search.Multiline = true;
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(208, 25);
            this.search.TabIndex = 63;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(18, 217);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(158, 27);
            this.dateTimePicker2.TabIndex = 62;
            this.dateTimePicker2.Value = new System.DateTime(2022, 2, 26, 16, 52, 28, 0);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(18, 181);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(158, 27);
            this.dateTimePicker1.TabIndex = 61;
            this.dateTimePicker1.Value = new System.DateTime(2022, 2, 26, 16, 52, 28, 0);
            // 
            // SAVE
            // 
            this.SAVE.BackColor = System.Drawing.Color.DarkOrange;
            this.SAVE.Location = new System.Drawing.Point(99, 266);
            this.SAVE.Margin = new System.Windows.Forms.Padding(4);
            this.SAVE.Name = "SAVE";
            this.SAVE.Size = new System.Drawing.Size(100, 28);
            this.SAVE.TabIndex = 60;
            this.SAVE.Text = "SAVE";
            this.SAVE.UseVisualStyleBackColor = false;
            this.SAVE.Click += new System.EventHandler(this.SAVE_Click);
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(185, 220);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(14, 27);
            this.ID.TabIndex = 46;
            this.ID.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(764, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(275, 320);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 55;
            this.pictureBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Info;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(23, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 20);
            this.label9.TabIndex = 57;
            this.label9.Text = "ACTIVE TIME";
            // 
            // STAFF
            // 
            this.STAFF.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.STAFF.Location = new System.Drawing.Point(7, 68);
            this.STAFF.Margin = new System.Windows.Forms.Padding(4);
            this.STAFF.Name = "STAFF";
            this.STAFF.Size = new System.Drawing.Size(154, 27);
            this.STAFF.TabIndex = 54;
            // 
            // TIME
            // 
            this.TIME.Location = new System.Drawing.Point(7, 132);
            this.TIME.Margin = new System.Windows.Forms.Padding(4);
            this.TIME.Name = "TIME";
            this.TIME.Size = new System.Drawing.Size(157, 27);
            this.TIME.TabIndex = 45;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(535, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 304);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // BIRTH
            // 
            this.BIRTH.Location = new System.Drawing.Point(353, 150);
            this.BIRTH.Margin = new System.Windows.Forms.Padding(4);
            this.BIRTH.Name = "BIRTH";
            this.BIRTH.Size = new System.Drawing.Size(175, 27);
            this.BIRTH.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Info;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(14, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 20);
            this.label8.TabIndex = 56;
            this.label8.Text = "ACTIVE STAFF";
            // 
            // BALANCE
            // 
            this.BALANCE.Location = new System.Drawing.Point(353, 282);
            this.BALANCE.Margin = new System.Windows.Forms.Padding(4);
            this.BALANCE.Name = "BALANCE";
            this.BALANCE.Size = new System.Drawing.Size(175, 27);
            this.BALANCE.TabIndex = 42;
            // 
            // PASSPORT
            // 
            this.PASSPORT.Location = new System.Drawing.Point(353, 194);
            this.PASSPORT.Margin = new System.Windows.Forms.Padding(4);
            this.PASSPORT.Name = "PASSPORT";
            this.PASSPORT.Size = new System.Drawing.Size(175, 27);
            this.PASSPORT.TabIndex = 40;
            // 
            // DEPART
            // 
            this.DEPART.Location = new System.Drawing.Point(353, 238);
            this.DEPART.Margin = new System.Windows.Forms.Padding(4);
            this.DEPART.Name = "DEPART";
            this.DEPART.Size = new System.Drawing.Size(175, 27);
            this.DEPART.TabIndex = 41;
            // 
            // LASTNAME
            // 
            this.LASTNAME.Location = new System.Drawing.Point(353, 106);
            this.LASTNAME.Margin = new System.Windows.Forms.Padding(4);
            this.LASTNAME.Name = "LASTNAME";
            this.LASTNAME.Size = new System.Drawing.Size(175, 27);
            this.LASTNAME.TabIndex = 38;
            // 
            // NAME
            // 
            this.NAME.Location = new System.Drawing.Point(353, 62);
            this.NAME.Margin = new System.Windows.Forms.Padding(4);
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(175, 27);
            this.NAME.TabIndex = 37;
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(353, 18);
            this.code.Margin = new System.Windows.Forms.Padding(4);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(175, 27);
            this.code.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Info;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label5.Location = new System.Drawing.Point(270, 152);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 1, 3, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 22);
            this.label5.TabIndex = 35;
            this.label5.Text = "BIRTH";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Info;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label7.Location = new System.Drawing.Point(236, 281);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 1, 3, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 22);
            this.label7.TabIndex = 34;
            this.label7.Text = "BALANCE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Info;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label6.Location = new System.Drawing.Point(210, 238);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 1, 3, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 22);
            this.label6.TabIndex = 33;
            this.label6.Text = "DEPARMENT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Info;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label4.Location = new System.Drawing.Point(233, 195);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 1, 3, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 22);
            this.label4.TabIndex = 32;
            this.label4.Text = "PASSPORT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label3.Location = new System.Drawing.Point(222, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 1, 3, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 22);
            this.label3.TabIndex = 31;
            this.label3.Text = "LASTNAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(270, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 1, 3, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 22);
            this.label2.TabIndex = 30;
            this.label2.Text = "NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(274, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 1, 3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 22);
            this.label1.TabIndex = 29;
            this.label1.Text = "CODE";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // mainmenubtn
            // 
            this.mainmenubtn.BackColor = System.Drawing.Color.DarkOrange;
            this.mainmenubtn.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mainmenubtn.Location = new System.Drawing.Point(13, 14);
            this.mainmenubtn.Name = "mainmenubtn";
            this.mainmenubtn.Size = new System.Drawing.Size(158, 32);
            this.mainmenubtn.TabIndex = 1;
            this.mainmenubtn.Text = "MAIN MENU";
            this.mainmenubtn.UseVisualStyleBackColor = false;
            this.mainmenubtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // connectionlabel
            // 
            this.connectionlabel.AutoSize = true;
            this.connectionlabel.BackColor = System.Drawing.Color.DarkOrange;
            this.connectionlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.connectionlabel.Location = new System.Drawing.Point(28, 110);
            this.connectionlabel.Name = "connectionlabel";
            this.connectionlabel.Size = new System.Drawing.Size(125, 20);
            this.connectionlabel.TabIndex = 47;
            this.connectionlabel.Text = "CONNECTION ";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(8, 133);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 28);
            this.comboBox1.TabIndex = 46;
            // 
            // RESTART
            // 
            this.RESTART.BackColor = System.Drawing.Color.DarkOrange;
            this.RESTART.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RESTART.Location = new System.Drawing.Point(8, 227);
            this.RESTART.Margin = new System.Windows.Forms.Padding(4);
            this.RESTART.Name = "RESTART";
            this.RESTART.Size = new System.Drawing.Size(158, 32);
            this.RESTART.TabIndex = 44;
            this.RESTART.Text = "RESTART";
            this.RESTART.UseVisualStyleBackColor = false;
            this.RESTART.Click += new System.EventHandler(this.RESTART_Click);
            // 
            // BEGIN
            // 
            this.BEGIN.BackColor = System.Drawing.Color.DarkOrange;
            this.BEGIN.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BEGIN.Location = new System.Drawing.Point(8, 176);
            this.BEGIN.Margin = new System.Windows.Forms.Padding(4);
            this.BEGIN.Name = "BEGIN";
            this.BEGIN.Size = new System.Drawing.Size(158, 32);
            this.BEGIN.TabIndex = 43;
            this.BEGIN.Text = "BEGIN";
            this.BEGIN.UseVisualStyleBackColor = false;
            this.BEGIN.Click += new System.EventHandler(this.BEGIN_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.Location = new System.Drawing.Point(8, 278);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 35);
            this.button1.TabIndex = 62;
            this.button1.Text = "CLOSE PORT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(12, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 32);
            this.button2.TabIndex = 63;
            this.button2.Text = "EXIT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Desktop;
            this.dataGridView1.Location = new System.Drawing.Point(5, 324);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(1211, 363);
            this.dataGridView1.TabIndex = 0;
            // 
            // PASTSYSTEM
            // 
            this.AcceptButton = this.BEGIN;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1218, 689);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.connectionlabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.RESTART);
            this.Controls.Add(this.BEGIN);
            this.Controls.Add(this.mainmenubtn);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PASTSYSTEM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SUBSCRIBER PAST SCREEN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PASTSYSTEM_FormClosing);
            this.Load += new System.EventHandler(this.subscriber_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox BIRTH;
        private System.Windows.Forms.TextBox BALANCE;
        private System.Windows.Forms.TextBox PASSPORT;
        private System.Windows.Forms.TextBox DEPART;
        private System.Windows.Forms.TextBox LASTNAME;
        private System.Windows.Forms.TextBox NAME;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TIME;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Button mainmenubtn;
        private System.Windows.Forms.Label connectionlabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button RESTART;
        private System.Windows.Forms.Button BEGIN;
        public System.Windows.Forms.TextBox STAFF;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button SAVE;
        private System.Windows.Forms.Button FIND;
        private System.Windows.Forms.TextBox search;
        public System.Windows.Forms.TextBox pastcode123;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}