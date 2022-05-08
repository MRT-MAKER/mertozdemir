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

	public partial class PASTSYSTEM : Form
	{


		public PASTSYSTEM()
		{
			InitializeComponent();
			serialPort.BaudRate = 9600;          
			Control.CheckForIllegalCrossThreadCalls = false;
		}
		OleDbConnection connect = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\workers.mdb");

		private void subscriber_Load(object sender, EventArgs e)
		{
			timer1.Start();
			listele();
			string[] ports = SerialPort.GetPortNames(); 
			foreach (string port in ports)
				comboBox1.Items.Add(port);
			serialPort.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);

			code.Enabled = false;
			NAME.Enabled = false;
			LASTNAME.Enabled = false;
			DEPART.Enabled = false;
			BIRTH.Enabled = false;
			PASSPORT.Enabled = false;
			DEPART.Enabled = false;
			BALANCE.Enabled = false;
			TIME.Enabled = false;
			pictureBox1.Enabled = false;
			STAFF.Enabled = false;

		}
		

		string trem;
		private delegate void LineReceivedEvent(string data);
		private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
		{


			
			this.Invoke((MethodInvoker)(() => trem = serialPort.ReadLine()));
			this.Invoke((MethodInvoker)(() => code.Text = trem));
			this.BeginInvoke(new LineReceivedEvent(Data_Parsing), trem);
		}
	
		private void Data_Parsing(string line)
		{
			if(line != null)
            {
				sorgu();
			Int64 cove = Convert.ToInt64(code.Text);
				if(cove > 2)
                {
					ekle();
					Thread.Sleep(2000);

					serialPort.Write(",");
				}
		
			}

		}
		private void button1_Click(object sender, EventArgs e)
        {
            try {
				if (serialPort.IsOpen) { serialPort.Close();
					
				}
			this.Hide();
			mainmenu Main = new mainmenu();
			Main.menuactivestaff.Text = STAFF.Text;
				Main.menuactivestaff.Text = STAFF.Text;
				Main.menucode.Text = pastcode123.Text;
				Main.ShowDialog();

			}
			catch (Exception ex)
            {
				MessageBox.Show(ex.Message);
            }
		}

		private void BEGIN_Click(object sender, EventArgs e)
		{

			try
			{
			
				comboBox1.BackColor = Color.Green;

				serialPort.PortName = comboBox1.Text;     
				serialPort.Open();
				if (code.Text == "")
					pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\pics\\resimyok.jpg");
			}
			catch (Exception ex)
			{
				if (comboBox1.Text == "")
				{
					comboBox1.BackColor = Color.Red;
					MessageBox.Show(ex.Message, "PLEASE CONNECT USB");
					
					pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\pics\\USB.jpg");
				}
				else
				{
					
					MessageBox.Show(ex.Message, "ALREADY CONNECTED");
					if (code.Text == "")
						pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\pics\\resimyok.jpg");

				}

			}

		}
		private void RESTART_Click(object sender, EventArgs e)
		{
			try
			{
				if (serialPort.IsOpen) serialPort.Close();
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
				MessageBox.Show(ex.Message, "WRONG");    
				comboBox1.BackColor = Color.Red;
			}
		}
		private void button1_Click_1(object sender, EventArgs e)
		{
			if (serialPort.IsOpen) { serialPort.Close(); }
			else
			{
				MessageBox.Show("PLEASE CONNECT USB");

				pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\pics\\USB.jpg");
			}
		}

		private void ekle()
		{


				connect.Open();
				if (pictureBox1.Image != null && code.Text != "" && NAME.Text != "" && LASTNAME.Text != "" && BIRTH.Text != "" && PASSPORT.Text != "" && DEPART.Text != "" && BALANCE.Text != "")

				{

					OleDbCommand komut = new OleDbCommand("insert into subscriber (CODE,NAME,LASTNAME,BIRTH,PASSPORT,DEPART,BALANCE,[TIME],STAFF) values(@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", connect);
					komut.Parameters.AddWithValue("@p2", code.Text);
					komut.Parameters.AddWithValue("@p3", NAME.Text);
					komut.Parameters.AddWithValue("@p4", LASTNAME.Text);
					komut.Parameters.AddWithValue("@p5", BIRTH.Text);
					komut.Parameters.AddWithValue("@p6", PASSPORT.Text);
					komut.Parameters.AddWithValue("@p7", DEPART.Text);
					komut.Parameters.AddWithValue("@p8", BALANCE.Text);
					komut.Parameters.AddWithValue("@p9", TIME.Text);
					komut.Parameters.AddWithValue("@p10",STAFF.Text);
					komut.ExecuteNonQuery();
					connect.Close();
					listele();
				}
			
			
			
			
		}

		void listele()
		{

            try { 
			DataTable aaa = new DataTable();
			OleDbDataAdapter da = new OleDbDataAdapter("select * from subscriber", connect);
			da.Fill(aaa);

			dataGridView1.Invoke((MethodInvoker)(() => dataGridView1.DataSource = aaa));
			}
            catch(Exception ex) 
            {
				MessageBox.Show(ex.Message, "WRONG");
			}
		}

		private void sorgu()
		{
            try {
			connect.Open();


			OleDbCommand aa = new OleDbCommand("select * from worker where CODE=@p2  ", connect);
			aa.Parameters.AddWithValue("@p2", code.Text);
			OleDbDataReader ll = aa.ExecuteReader();
			if (ll.Read())
			{

				

				ID.Text = ll.GetValue(0).ToString();
				code.Invoke((MethodInvoker)(() => code.Text = ll.GetValue(1).ToString()));
				code.Invoke((MethodInvoker)(() => NAME.Text = ll.GetValue(2).ToString()));
				code.Invoke((MethodInvoker)(() => LASTNAME.Text = ll.GetValue(3).ToString()));
				code.Invoke((MethodInvoker)(() => BIRTH.Text = ll.GetValue(4).ToString()));
				code.Invoke((MethodInvoker)(() => PASSPORT.Text = ll.GetValue(5).ToString()));
				code.Invoke((MethodInvoker)(() => DEPART.Text = ll.GetValue(6).ToString()));
				code.Invoke((MethodInvoker)(() => BALANCE.Text = ll.GetValue(7).ToString()));


				Int64 sayi = Convert.ToInt64(code.Text);

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
				code.Invoke((MethodInvoker)(() => code.Text = ""));
				NAME.Invoke((MethodInvoker)(() => NAME.Text = ""));
				LASTNAME.Invoke((MethodInvoker)(() => LASTNAME.Text = ""));
				BIRTH.Invoke((MethodInvoker)(() => BIRTH.Text = ""));
				PASSPORT.Invoke((MethodInvoker)(() => PASSPORT.Text = ""));
				DEPART.Invoke((MethodInvoker)(() => DEPART.Text = ""));
				BALANCE.Invoke((MethodInvoker)(() => BALANCE.Text = ""));
				pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\pics\\resimyok.jpg");
			}

			connect.Close();
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
			catch (Exception ex)
            {
				MessageBox.Show(ex.Message, "WRONG");
			}


		}

        private void PASTSYSTEM_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void FIND_Click(object sender, EventArgs e)
        {
			try
			{
				connect.Open();
				//DateTime date1= DateTime.Parse(dateTimePicker1.Text);
				//DateTime date2 = DateTime.Parse(dateTimePicker2.Text);
				DataTable dt = new DataTable();
				OleDbCommand komut = new OleDbCommand("select * from subscriber where   NAME like '%" + search.Text + "%' and LASTNAME like '%" + search.Text + "%' and TIME  between  @date1 and @date2   ", connect);
				OleDbDataAdapter da = new OleDbDataAdapter(komut);
				da.SelectCommand.Parameters.AddWithValue("@date1", dateTimePicker1.Value);
				da.SelectCommand.Parameters.AddWithValue("@date2", dateTimePicker2.Value);
				da.Fill(dt);
				dataGridView1.DataSource = dt;
				connect.Close();
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }
		}

        private void SAVE_Click(object sender, EventArgs e)
        {
			SaveFileDialog save = new SaveFileDialog();
			save.FileName = "";
			save.Filter = "TEXT DOCUMENT|*.txt";
			save.Title = "Save Table as";
			DialogResult res = save.ShowDialog();
			if (res == DialogResult.OK)
			{

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

        private void PASTSYSTEM_FormClosing(object sender, FormClosingEventArgs e)
        {
			if (serialPort.IsOpen) serialPort.Close();
		}

        private void button2_Click(object sender, EventArgs e)
        {
			Application.Exit();
        }
    }




}
