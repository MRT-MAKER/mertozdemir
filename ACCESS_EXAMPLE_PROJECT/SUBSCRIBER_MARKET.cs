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
using QRCoder;
using System.Xml;
namespace ACCESS_EXAMPLE_PROJECT
{
	public partial class SUBSCRIBER_MARKET : Form
	{
		public SUBSCRIBER_MARKET()
		{
			InitializeComponent();
			serialPort.BaudRate = 9600;
			Control.CheckForIllegalCrossThreadCalls = false;
		}
		OleDbConnection connect = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\workers.mdb");

		string data;
		double MM;
		double MM2;
		int i = 0;
		private delegate void LineReceivedEvent(string data);


		private void timer1_Tick(object sender, EventArgs e)
		{
			try
			{
				DateTime d = DateTime.Now;
				TIME.Text = DateTime.Now.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}


		}

		private void SUBSCRIBER_PAYMENT_Load(object sender, EventArgs e)
		{

		
			try
			{
				list();string[] ports = SerialPort.GetPortNames(); 
				foreach (string port in ports)
					comboBox1.Items.Add(port);
				serialPort.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
				string kur = "https://www.tcmb.gov.tr/kurlar/today.xml";
				var xmldoc = new XmlDocument();
				xmldoc.Load(kur);
				DateTime tarih = Convert.ToDateTime(xmldoc.SelectSingleNode("//Tarih_Date").Attributes["Tarih"].Value);

				string DOLAR = xmldoc.SelectSingleNode("Tarih_Date/Currency  [@Kod='USD']/BanknoteSelling").InnerXml;
				USD.Text = DOLAR;

				string sterlin = xmldoc.SelectSingleNode("Tarih_Date/Currency  [@Kod='GBP']/BanknoteSelling").InnerXml;
				POUND.Text = sterlin;

				string avro = xmldoc.SelectSingleNode("Tarih_Date/Currency  [@Kod='EUR']/BanknoteSelling").InnerXml;
				EURO.Text = avro;
				string RUBİ = xmldoc.SelectSingleNode("Tarih_Date/Currency  [@Kod='EUR']/CrossRateOther").InnerXml;
				eurusd.Text = RUBİ;

				USD.Enabled = false;
				code.Enabled = false;
				NAME.Enabled = false;
				LASTNAME.Enabled = false;
				DEPART.Enabled = false;
				BIRTH.Enabled = false;
				PASSPORT.Enabled = false;
				DEPART.Enabled = false;
				balance.Enabled = false;
				TIME.Enabled = false;
				pictureBox1.Enabled = false;
				STAFF.Enabled = false;
				newbalance.Enabled = false;
				POUND.Enabled = false;
				EURO.Enabled = false;
				eurusd.Enabled = false;
				timer1.Start();
				
				
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }
		}
		
		private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
		{
			this.Invoke((MethodInvoker)(() => data = serialPort.ReadLine()));
			code.Text = data;
			this.BeginInvoke(new LineReceivedEvent(LineReceived), data);
			if (data != code.Text)
				{
					ID.Text = "";

					NAME.Text = "";
					LASTNAME.Text = "";
					DEPART.Text = "";
					BIRTH.Text = "";
					balance.Text = "";

					PASSPORT.Text = "";
					pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\pics\\resimyok.jpg");
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
			catch (Exception ex) { MessageBox.Show(ex.Message); }

		}
		private void BEGIN_Click(object sender, EventArgs e)
		{

			try
			{
				comboBox1.BackColor = Color.Green;

				serialPort.PortName = comboBox1.Text;  //ComboBox1'de seçili nesneyi port ismine ata    
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
				MessageBox.Show(ex.Message, "Hata");
				comboBox1.BackColor = Color.Red;
			}
		}
	
		private void addnew()
		{
			try
			{
				connect.Open();

				if (pictureBox1.Image != null && code.Text != "" && NAME.Text != "" && LASTNAME.Text != "" && BIRTH.Text != "" && PASSPORT.Text != "" && DEPART.Text != "" && balance.Text != "")

				{

					OleDbCommand komut = new OleDbCommand("insert into pay (CODE,NAME,LASTNAME,BIRTH,PASSPORT,DEPART,BALANCE,NEWBALANCE,[TIME],STAFF) values(@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", connect);
					komut.Parameters.AddWithValue("@p2", code.Text);
					komut.Parameters.AddWithValue("@p3", NAME.Text);
					komut.Parameters.AddWithValue("@p4", LASTNAME.Text);
					komut.Parameters.AddWithValue("@p5", BIRTH.Text);
					komut.Parameters.AddWithValue("@p6", PASSPORT.Text);
					komut.Parameters.AddWithValue("@p7", DEPART.Text);
					komut.Parameters.AddWithValue("@p8", balance.Text);
					komut.Parameters.AddWithValue("@p9", newbalance.Text);
					komut.Parameters.AddWithValue("@p10", TIME.Text);
					komut.Parameters.AddWithValue("@p11", STAFF.Text);

					komut.ExecuteNonQuery();

				}
				connect.Close();
				list();
			}

			catch (Exception ex) { MessageBox.Show(ex.Message); }
		}
		void list()
		{

			try
			{
				DataTable aaa = new DataTable();
				OleDbDataAdapter da = new OleDbDataAdapter("select * from pay", connect);
				da.Fill(aaa);

				dataGridView1.Invoke((MethodInvoker)(() => dataGridView1.DataSource = aaa));
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }
		}

		private void sorgu()
		{
			try
			{
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
					code.Invoke((MethodInvoker)(() => balance.Text = ll.GetValue(7).ToString()));


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
					balance.Invoke((MethodInvoker)(() => balance.Text = ""));
					pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\pics\\resimyok.jpg");
				}

				connect.Close();
			}

			catch (Exception ex) { MessageBox.Show(ex.Message); }
		}
	
		
		private void exit_Click(object sender, EventArgs e)
		{
			try
			{
				serialPort.Close();
				
				this.Hide();
				mainmenu Main = new mainmenu();
				Main.menuactivestaff.Text = STAFF.Text;
				Main.menucode.Text = marketcode123.Text;
				Main.ShowDialog();
			}
			catch (Exception ex) { MessageBox.Show(ex.Message); }


		}

        private void button1_Click(object sender, EventArgs e)
        {
			if (serialPort.IsOpen) serialPort.Close();
			else
			{
				MessageBox.Show("PLEASE CONNECT USB");

				pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\pics\\USB.jpg");
			}
		}
		
        private void BILL_Click(object sender, EventArgs e)
        {
			MM=Convert.ToInt32(moneycollect.Text);
			MM2 = Convert.ToInt32(balance.Text);
			double durum= MM2 - MM;
			if(durum > 0)
            {
				newbalance.Text=durum.ToString();i = 1;
            }
            else
            {
				MessageBox.Show("insufficient balance");
				i= 0;
            }
        }

        private void cleanbalance_Click(object sender, EventArgs e)
        {
			moneycollect.Text = "";
			newbalance.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
			try
			{
				string MessageBoxTitle = " ";
				string MessageBoxContent = "Do You Want To Pay ?";

				DialogResult dialogResult = MessageBox.Show(MessageBoxContent, MessageBoxTitle, MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{
					if ( i == 1 && pictureBox1.Image != null && code.Text != "" && NAME.Text != "" && LASTNAME.Text != "" && BIRTH.Text != "" && PASSPORT.Text != "" && DEPART.Text != "" && balance.Text != "")
					{

						connect.Open();
						OleDbCommand al = new OleDbCommand("Update worker set BALANCE=@p6 where ID=@p7", connect);

						al.Parameters.AddWithValue("@p6", newbalance.Text);
						al.Parameters.AddWithValue("@p7", ID.Text);

						al.ExecuteNonQuery();

						connect.Close();



						string metin =  moneycollect.Text + "TL PAID BY "+ NAME.Text + LASTNAME.Text;
						QRCodeGenerator q = new QRCodeGenerator();
						QRCodeData qr = q.CreateQrCode(metin, QRCodeGenerator.ECCLevel.Q);
						QRCode qrcode = new QRCode(qr);

						Bitmap qrcodeimage = qrcode.GetGraphic(50);
						pictureBox3.Image = qrcodeimage;


					}

					else
					{
						MessageBox.Show("Please fill blank");
					}
				}
				else if (dialogResult == DialogResult.No)
				{
					//do something else
				}


			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message);

			}

			addnew(); list();
			sorgu();
			newbalance.Text = "";
			moneycollect.Text = "";
		}

        private void SUBSCRIBER_MARKET_FormClosing(object sender, FormClosingEventArgs e)
        {
          if (serialPort.IsOpen) { serialPort.Close(); }
			Application.Exit();
		}

     
    }
}
