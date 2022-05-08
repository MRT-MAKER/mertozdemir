using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.IO.Ports;
using System.Data.Odbc;
using System.Threading;
namespace ACCESS_EXAMPLE_PROJECT
{

    public partial class MANAGEMENT : Form
	{
		public string durum;
		public MANAGEMENT()
		{
			InitializeComponent();
			serialPort.BaudRate = 9600;            
			Control.CheckForIllegalCrossThreadCalls = false;

		}
		OleDbConnection connect = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\workers.mdb");

		private delegate void LineReceivedEvent(string data);
		
		private void Form1_Load(object sender, EventArgs e)
		{
			try
			{
				list();
				timer1.Start();
				string[] ports = SerialPort.GetPortNames();
				foreach (string port in ports)
					comboBox1.Items.Add(port);
				serialPort.DataReceived += new SerialDataReceivedEventHandler(SerialPort1_DataReceived);
				ADD.Enabled = false;
				DELETE.Enabled = false;
				UPDATE1.Enabled = false;
				clean.Enabled = false;
				NAMEE.Enabled = false;
				CODE.Enabled = false;
				NAME.Enabled = false;
				LASTNAME.Enabled = false;
				DEPART.Enabled = false;
				BIRTH.Enabled = false;
				PASSPORT.Enabled = false;
				DEPART.Enabled = false;
				BALANCE.Enabled = false;
				pictureBox1.Enabled = false;
				PICSAVE.Enabled = false;
				DELETEPIC.Enabled = false;
				TIME.Enabled = false;
			}
			catch (Exception ex) { 
			MessageBox.Show(ex.Message);
			}

		}
		string kontrol;
		private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try { 
		
				
				this.Invoke((MethodInvoker)(() => kontrol = serialPort.ReadLine()));
				this.Invoke((MethodInvoker)(() => CODE.Text = kontrol));
				CODE.Text = kontrol;
			this.BeginInvoke(new LineReceivedEvent(LineReceived), kontrol);

			if (kontrol != CODE.Text)
			{
				ID.Text = "";

				NAME.Text = "";
				LASTNAME.Text = "";
				DEPART.Text = "";
				BIRTH.Text = "";
				BALANCE.Text = "";
				search.Text = "";
				PASSPORT.Text = "";
				pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\pics\\resimyok.jpg");
			} }
				catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}


		}
		private void LineReceived(string line)
		{
			try
			{
				if (line != null)
				{
					sorgu();

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message); 
			}
		}
		void list()
		{
			try
			{
				DataTable newlist = new DataTable();
				OleDbDataAdapter da = new OleDbDataAdapter("select * from worker", connect);
				da.Fill(newlist);
				dataGridView1.DataSource = newlist;
			}
			catch(Exception ex)
            {
				MessageBox.Show(ex.Message);
			}
		}

		private void BEGIN_Click(object sender, EventArgs e)
		{

			try
			{
				System.GC.Collect();
				System.GC.WaitForPendingFinalizers();
				comboBox1.BackColor = Color.Green;
				
				serialPort.PortName = comboBox1.Text;  //ComboBox1'de seçili nesneyi port ismine ata    
				serialPort.Open();
				if (CODE.Text == "")
					pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\pics\\resimyok.jpg");
			}
			catch (Exception ex)
			{
				if (comboBox1.Text == "")
				{
					comboBox1.BackColor = Color.Red;
					MessageBox.Show(ex.Message,"PLEASE CONNECT USB");
					pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\pics\\USB.jpg");
				}
				else
				{
					MessageBox.Show(ex.Message, "ALREADY CONNECTED");
					CLEAN();
					if (CODE.Text == "")
					pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\pics\\resimyok.jpg");
					
				}

			}

		}
		private void RESTART_Click(object sender, EventArgs e)
		{
			try
			{
				
				System.GC.Collect();
				System.GC.WaitForPendingFinalizers();
				string[] ports = SerialPort.GetPortNames();   
				foreach (string port in ports)
					comboBox1.Items.Add(port);              
				if (comboBox1.Text == "")
				{
					comboBox1.BackColor = Color.Red;
				}
				else
					comboBox1.BackColor = Color.Green;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Hata");    
				comboBox1.BackColor = Color.Red;
			}
		}
		private void CLOSE_Click(object sender, EventArgs e)
		{
			System.GC.Collect();
			System.GC.WaitForPendingFinalizers();
			if (serialPort.IsOpen) { this.serialPort.Close(); 
			comboBox1.BackColor = Color.Red;
			MessageBox.Show("PORT CLOSED");
			}
			else { }
			
		}

		private void addnewuser()
		{
            try { 
			connect.Open();


			OleDbCommand aa = new OleDbCommand("select * from worker where CODE=@p2  ", connect);
			aa.Parameters.AddWithValue("@p2", CODE.Text);
			OleDbDataReader ll = aa.ExecuteReader();
			if (ll.Read())
				MessageBox.Show("SAME CODE");



			else if (!ll.Read() && pictureBox1.Image != null && CODE.Text != "" && NAME.Text != "" && LASTNAME.Text != "" && BIRTH.Text != "" && PASSPORT.Text != "" && DEPART.Text != "" && BALANCE.Text != "")

			{

				OleDbCommand komut = new OleDbCommand("insert into worker (CODE,NAME,LASTNAME,BIRTH,PASSPORT,DEPART,BALANCE,[TIME],STAFF) values(@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", connect);
				komut.Parameters.AddWithValue("@p2", CODE.Text);
				komut.Parameters.AddWithValue("@p3", NAME.Text);
				komut.Parameters.AddWithValue("@p4", LASTNAME.Text);
				komut.Parameters.AddWithValue("@p5", BIRTH.Text);
				komut.Parameters.AddWithValue("@p6", PASSPORT.Text);
				komut.Parameters.AddWithValue("@p7", DEPART.Text);
				komut.Parameters.AddWithValue("@p8", BALANCE.Text);
				komut.Parameters.AddWithValue("@p9", TIME.Text);
				komut.Parameters.AddWithValue("@p10", NAMEE.Text);

				komut.ExecuteNonQuery();
				MessageBox.Show("SUCCESFULLY ADDED");
			}
			else
				MessageBox.Show("CANNOT BLANK PLACE");

			connect.Close();
			list();
			}
			catch (Exception ex)
            {
				MessageBox.Show(ex.Message);
            }

		}
		private void sorgu()
		{

			connect.Open();

	
			OleDbCommand aa = new OleDbCommand("select * from worker where CODE=@p2  ", connect);
			aa.Parameters.AddWithValue("@p2", CODE.Text);
			OleDbDataReader ll = aa.ExecuteReader();
			if (ll.Read())
			{


				ID.Text = ll.GetValue(0).ToString();
				CODE.Text = ll.GetValue(1).ToString();
				NAME.Text = ll.GetValue(2).ToString();
				LASTNAME.Text = ll.GetValue(3).ToString();
				BIRTH.Text = ll.GetValue(4).ToString();
				PASSPORT.Text = ll.GetValue(5).ToString();
				DEPART.Text = ll.GetValue(6).ToString();
				BALANCE.Text = ll.GetValue(7).ToString();

				Int64 sayi = Convert.ToInt64(CODE.Text);

				pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // ekrana kayıtlının resmini getir

				try
				{
					pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\pics\\" + sayi + ".jpg");


				}
				catch (Exception)
				{

					pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\pics\\resimyok.jpg");
				}

			}
            else
            {
			
			
				NAME.Text = "";
				LASTNAME.Text = "";
				DEPART.Text = "";
				BIRTH.Text = "";
				BALANCE.Text = "";
				search.Text = "";
				PASSPORT.Text = "";
				pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\pics\\resimyok.jpg");
			}

			connect.Close();

		}
		private void PICSAVE_Click(object sender, EventArgs e)
		{
			addpic();

		}
		private void DELETEPIC_Click(object sender, EventArgs e)
        {
            try { 
			Int64 code1 = Convert.ToInt64(CODE.Text);

			if (File.Exists(Application.StartupPath + "\\pics\\" + code1 + ".jpg"))
			{

				pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\pics\\resimyok.jpg");
				System.GC.Collect();
				System.GC.WaitForPendingFinalizers();

				File.Delete(Application.StartupPath + "\\pics\\" + code1 + ".jpg");


				MessageBox.Show("FILE DELETED");
			}
			else
			{
				MessageBox.Show("THERE IS NO SUCH AS FILE");
			}
			}
			catch (Exception ex)
            {
				MessageBox.Show(ex.Message);
            }
		}
		private void addpic()
		{
            try { 
			Int64 code1 = Convert.ToInt64(CODE.Text);
			if (CODE.Text != null)
			{
				System.GC.Collect();
				System.GC.WaitForPendingFinalizers();

				pictureBox1.Image.Save(Application.StartupPath + "\\pics\\" + code1 + ".jpg");
				MessageBox.Show("SAVED!!");

			}
			else
				MessageBox.Show("PLEASE FILL EMPTY PLACE OR DELETE PREVIOUS IMAGE");
			}
			catch(Exception ex)
            {
				MessageBox.Show(ex.Message);
			}
		}
		private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            try { 
			System.GC.Collect();
			System.GC.WaitForPendingFinalizers();

			OpenFileDialog resimsec = new OpenFileDialog();
			resimsec.Title = "Eklenecek Resmi seçiniz";
			resimsec.Filter = "Resim Dosyası |*.jpg;*.nef;*.png |  All Documents |*.*";
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			if (resimsec.ShowDialog() == DialogResult.OK)
			{

				pictureBox1.Image = new Bitmap(resimsec.OpenFile());
			}
			}
			catch(Exception ex)
            {
				MessageBox.Show(ex.Message);
			}
		}
		private void CLEAN()
        {
			ID.Text = "";
			CODE.Text = "";
			NAME.Text = "";
			LASTNAME.Text = "";
			DEPART.Text = "";
			BIRTH.Text = "";
			BALANCE.Text = "";
			search.Text = "";
			PASSPORT.Text = "";
			pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\pics\\resimyok.jpg");
		}
        
        private void adduser_CheckedChanged(object sender, EventArgs e)
        {
			ADD.Enabled = true;
			DELETE.Enabled = true;
			UPDATE1.Enabled = false;
			clean.Enabled = true;

			CODE.Enabled = false;
			NAME.Enabled = true;
			LASTNAME.Enabled = true;
			DEPART.Enabled = true;
			BIRTH.Enabled = true;
			PASSPORT.Enabled = true;
			DEPART.Enabled=true;
			BALANCE.Enabled = true;
			pictureBox1.Enabled = true;
			PICSAVE.Enabled = true;
			DELETEPIC.Enabled = true;
			CLEAN();
		}

        private void updateuser_CheckedChanged(object sender, EventArgs e)
        {
			ADD.Enabled = false;
			DELETE.Enabled = true;
			UPDATE1.Enabled = true;
			clean.Enabled = true;

			CODE.Enabled = false;
			NAME.Enabled = true;
			LASTNAME.Enabled = true;
			DEPART.Enabled = true;
			BIRTH.Enabled = true;
			PASSPORT.Enabled = true;
			DEPART.Enabled = true;
			BALANCE.Enabled = false;
			pictureBox1.Enabled = true;
			PICSAVE.Enabled = true;
			DELETEPIC.Enabled = true;

		
		}

        private void addmoney_CheckedChanged(object sender, EventArgs e)
        {
			ADD.Enabled = false;
			DELETE.Enabled = false;
			UPDATE1.Enabled = true;
			clean.Enabled = false;

			CODE.Enabled = false;
			NAME.Enabled = false;
			LASTNAME.Enabled = false;
			DEPART.Enabled = false;
			BIRTH.Enabled = false;
			PASSPORT.Enabled = false;
			DEPART.Enabled = false;
			BALANCE.Enabled = true;
			pictureBox1.Enabled = false;
			PICSAVE.Enabled = false;
			DELETEPIC.Enabled = false;
		}

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try { 
			int secilen = dataGridView1.SelectedCells[0].RowIndex;
			
			
			ID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
			CODE.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
			NAME.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
			LASTNAME.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
			BIRTH.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
			PASSPORT.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
			DEPART.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
			BALANCE.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
			tıme.Text = dataGridView1.Rows[secilen].Cells[8].Value.ToString();
			staff.Text = dataGridView1.Rows[secilen].Cells[9].Value.ToString();
		
			Int64 sayi = Convert.ToInt64(CODE.Text);

			try
			{
				pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\pics\\" + sayi + ".jpg");


			}
			catch (Exception ex)
			{

				pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\pics\\resimyok.jpg");
				MessageBox.Show(ex.Message);
			}
			}
			catch(Exception ex)
            {
				MessageBox.Show(ex.Message);
            }
		}

        private void exit_Click(object sender, EventArgs e)
        {
            try { 
			this.Hide();
			if (serialPort.IsOpen) serialPort.Close();    
			mainmenu main = new mainmenu();
				main.menuactivestaff.Text = NAMEE.Text;
				main.menucode.Text = managecode.Text;
				main.ShowDialog();
			}
			catch(Exception ex)
            {
				MessageBox.Show(ex.Message);
            }


		}

        private void timer1_Tick(object sender, EventArgs e)
        {
            try { 
			DateTime d = DateTime.Now;
			TIME.Text = DateTime.Now.ToString();
			}
			catch(System.Exception ex)
            {
				MessageBox.Show(ex.Message);
            }
		}

        private void FIND_Click(object sender, EventArgs e)
        {
            try { 
			connect.Open();
			
			DataTable dt = new DataTable();
			OleDbCommand komut = new OleDbCommand("select * from worker where   NAME like '%" + search.Text + "%' and LASTNAME like '%" + search.Text + "%' and TIME  between  @date1 and @date2   ", connect);
			OleDbDataAdapter da = new OleDbDataAdapter(komut);
			da.SelectCommand.Parameters.AddWithValue("@date1", dateTimePicker1.Value);
			da.SelectCommand.Parameters.AddWithValue("@date2", dateTimePicker2.Value);
			da.Fill(dt);
			dataGridView1.DataSource = dt;
			connect.Close();
			}
			catch(Exception ex) { MessageBox.Show(ex.Message); }
		}

        private void clean_Click(object sender, EventArgs e)
        {
			CLEAN();
		}

		private void UPDATE_Click(object sender, EventArgs e)
		{

			try {
				if (pictureBox1.Image != null && CODE.Text != "" && NAME.Text != "" && LASTNAME.Text != "" && BIRTH.Text != "" && PASSPORT.Text != "" && DEPART.Text != "" && BALANCE.Text != "")
				{


					connect.Open();
					OleDbCommand al = new OleDbCommand("Update worker set NAME=@p1,LASTNAME=@p2,BIRTH=@p3,PASSPORT=@p4,DEPART=@p5,BALANCE=@p6 where ID=@p8", connect);


					al.Parameters.AddWithValue("@p1", NAME.Text);
					al.Parameters.AddWithValue("@p2", LASTNAME.Text);
					al.Parameters.AddWithValue("@p3", BIRTH.Text);
					al.Parameters.AddWithValue("@p4", PASSPORT.Text);
					al.Parameters.AddWithValue("@p5", DEPART.Text);
					al.Parameters.AddWithValue("@p6", BALANCE.Text);
					al.Parameters.AddWithValue("@p8", ID.Text);
					al.ExecuteNonQuery();
					connect.Close();
					list();



				}
				else {

					MessageBox.Show("PLEASE FILL BLANK PLACE");

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
		} 
		
		}
		
        private void DELETE_Click(object sender, EventArgs e)
        {
            try
            {
				if (pictureBox1.Image != null && CODE.Text != "" && NAME.Text != "" && LASTNAME.Text != "" && BIRTH.Text != "" && PASSPORT.Text != "" && DEPART.Text != "" && BALANCE.Text != "")
				{
					connect.Open();
					OleDbCommand komut = new OleDbCommand("Delete from worker where ID=@p1", connect);
					komut.Parameters.AddWithValue("@p1", ID.Text);
					komut.ExecuteNonQuery();
					connect.Close();
					list();
					CLEAN();
				}
				else
					MessageBox.Show("Please Do Not Blank ");
			}
			catch(Exception ex) { MessageBox.Show(ex.Message); }
			
		}

        private void ADD_Click(object sender, EventArgs e)
        {
			addnewuser();
		}


        private void SAVE_Click(object sender, EventArgs e)
		{
			SaveFileDialog save = new SaveFileDialog();
			save.FileName = "";
			save.Filter = "TEXT DOCUMENT|*.txt";
			save.Title = "Save Table as";
			DialogResult res = save.ShowDialog();
			if (res == DialogResult.OK) { 

			TextWriter writer = new StreamWriter(save.FileName);
			for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
			{
				for (int j = 0; j < dataGridView1.Columns.Count; j++)
				{
					
						writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
				}
				writer.WriteLine("");
				writer.WriteLine("-----------------------------------------------------");
					
			}
				MessageBox.Show("SAVED");
				writer.Close();
			}
		}


        private void MANAGEMENT_FormClosing(object sender, FormClosingEventArgs e)
        {
			if (serialPort.IsOpen) { serialPort.Close(); }
		}

        private void button1_Click(object sender, EventArgs e)
        {
			if (serialPort.IsOpen) serialPort.Close();
            else
            {
				MessageBox.Show( "PLEASE CONNECT USB");

				pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\pics\\USB.jpg");
			}
		}

        private void button2_Click(object sender, EventArgs e)
        {
			Application.Exit();
		}
    }
}
