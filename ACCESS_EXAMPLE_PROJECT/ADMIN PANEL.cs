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
    public partial class CABLE : Form
    {
        public CABLE()
        {
            InitializeComponent(); 
        }


        OleDbConnection connect = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\workers.mdb");




        private void KABLE_Load(object sender, EventArgs e)
        {
            listele();
            timer1.Start();
            cablestaff.Enabled = false;
            cabletime.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                DateTime d = DateTime.Now;
                cabletime.Text = DateTime.Now.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "UNIVERSITY OF LEFKE");
            }

        }

        private void INSERT_Click(object sender, EventArgs e)
        {
            try
            {
                if (cablecode.Text != "" && cablename.Text != "" && cablelastname.Text != "" && cablepassword.Text != "" && cableid.Text != "")
                {
                    connect.Open();
                    OleDbCommand menur = new OleDbCommand("insert into interpol ([CODE],[NAME],[LASTNAME],[PASSWORD],[TIME],[STAFF]) values(@p1,@p2,@p3,@p4,@p5,@p6)", connect);
                    menur.Parameters.AddWithValue("@p1", cablecode.Text);
                    menur.Parameters.AddWithValue("@p2", cablename.Text);
                    menur.Parameters.AddWithValue("@p3", cablelastname.Text);
                    menur.Parameters.AddWithValue("@p4", cablepassword.Text);
                    menur.Parameters.AddWithValue("@p5", cabletime.Text);
                    menur.Parameters.AddWithValue("@p6", cablestaff.Text);
                    menur.ExecuteNonQuery();
                    connect.Close();
                    listele(); clear();
                }
                else
                    MessageBox.Show("Please Do Not Blank ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "UNIVERSITY OF LEFKE");
            }
        }

        private void listele()
        {

            try
            {
                DataTable naw = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter("select * from interpol", connect);
                da.Fill(naw);

                dataGridView1.Invoke((MethodInvoker)(() => dataGridView1.DataSource = naw));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "UNIVERSITY OF LEFKE");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int secilen = dataGridView1.SelectedCells[0].RowIndex;
                cableid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
                cablecode.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
                cablename.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
                cablelastname.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
                cablepassword.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();  
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void turnmainmenü_Click(object sender, EventArgs e)
        {
            this.Hide();
          
            mainmenu main = new mainmenu();
            main.menuactivestaff.Text = cablestaff.Text;
            main.menucode.Text = cablecode1.Text;
            main.ShowDialog();
        }

        private void UPDATE_Click(object sender, EventArgs e)
        {
            try
            {
                if (cablecode.Text != "" && cablename.Text != "" && cablelastname.Text != "" && cablepassword.Text != "" && cableid.Text != "")
                {
                    connect.Open();
                    OleDbCommand alert = new OleDbCommand("Update interpol set [CODE]=@p1,[NAME]=@p2,[LASTNAME]=@p3,[PASSWORD]=@p4 where ID=@p5", connect);

                alert.Parameters.AddWithValue("@p1", cablecode.Text);
                alert.Parameters.AddWithValue("@p2", cablename.Text);
                alert.Parameters.AddWithValue("@p3", cablelastname.Text);
                alert.Parameters.AddWithValue("@p4", cablepassword.Text);
                alert.Parameters.AddWithValue("@p5", cableid.Text);
                alert.ExecuteNonQuery();
                    connect.Close();
                    listele();
                clear();
                }
                else
                    MessageBox.Show("Please Do Not Blank ");
            }
           catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void DELETE_Click(object sender, EventArgs e)
        {
            try
            {
                if (cablecode.Text != "" && cablename.Text != "" && cablelastname.Text != "" && cablepassword.Text != "" && cableid.Text != "")
                {
                    connect.Open();
                    OleDbCommand komut = new OleDbCommand("Delete from interpol where ID=@p1", connect);
                    komut.Parameters.AddWithValue("@p1", cableid.Text);
                    komut.ExecuteNonQuery();
                    connect.Close();
                    listele();
                    clear();
                }
                else
                    MessageBox.Show("Please Do Not Blank ");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void clear()
        {
            cablecode.Text = "";
            cablename.Text = "";
            cablelastname.Text = "";
            cablepassword.Text = "";
            cableid.Text = "";
            
        }
        private void CLEAN_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
