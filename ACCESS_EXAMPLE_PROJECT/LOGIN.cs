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

namespace ACCESS_EXAMPLE_PROJECT
{
    public partial class logintosystem : Form
    {
        public logintosystem()
        {
            InitializeComponent();
        }
        OleDbConnection connect = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\workers.mdb");


        private void button1_Click(object sender, EventArgs e)
        {
          
            connect.Open();

            OleDbCommand aa = new OleDbCommand("select * from interpol where (CODE=@p1 and NAME=@p2 and LASTNAME=@p3 and PASSWORD=@p4)", connect);
            aa.Parameters.AddWithValue("@p1", textBox1.Text);
            aa.Parameters.AddWithValue("@p2", textBox2.Text);
            aa.Parameters.AddWithValue("@p3", textBox3.Text);
            aa.Parameters.AddWithValue("@p4", textBox4.Text);
            OleDbDataReader ll = aa.ExecuteReader();

            if (ll.Read())
            {

                    name1.Text = textBox2.Text;
                    lastname2.Text = textBox3.Text;
                    this.Hide();
                    mainmenu mainz = new mainmenu();
                    mainz.menuactivestaff.Text = name1.Text + " " + lastname2.Text;
                    mainz.menucode.Text = textBox1.Text;
                    mainz.ShowDialog();
            }
            else
                {
                    MessageBox.Show("PLEASE LOGIN CORRECT ");
                }
                connect.Close();
           

        }

        private void PAYMENT_Load(object sender, EventArgs e)
        {
            textBox4.PasswordChar = '*';
            textBox1.PasswordChar = '*';
        }

        private void showpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showpassword.Checked != true)
            {
                textBox4.PasswordChar = '*';
                textBox1.PasswordChar = '*';


            }
            else
            {
                textBox4.PasswordChar = (Char)0; textBox1.PasswordChar = (Char)0;
            }
        }

        private void CANCEL_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logintosystem_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
    }


