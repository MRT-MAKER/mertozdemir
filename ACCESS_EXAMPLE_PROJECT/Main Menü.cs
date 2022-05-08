using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACCESS_EXAMPLE_PROJECT
{
    public partial class mainmenu : Form
    {
        public mainmenu()
        {
            InitializeComponent();
        }
     
        private void Main_Menü_Load(object sender, EventArgs e)
        {
            menuactivestaff.Enabled = false;
            if(menucode.Text == "2")
            {
               admincontrol.Visible = false;
            }
            else
                admincontrol.Visible=true;
        }

        private void topastsystem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                PASTSYSTEM past = new PASTSYSTEM();
                past.STAFF.Text = menuactivestaff.Text;
                past.pastcode123.Text = menucode.Text;
                past.ShowDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void tosubscribermanagement_Click(object sender, EventArgs e)
        {
            try { 

            this.Hide();
            MANAGEMENT manage= new MANAGEMENT();
            manage.NAMEE.Text = menuactivestaff.Text;
                manage.managecode.Text = menucode.Text;
                manage.ShowDialog();
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void tomarket_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
             
                SUBSCRIBER_MARKET market = new SUBSCRIBER_MARKET();
                market.STAFF.Text = menuactivestaff.Text;
                market.marketcode123.Text = menucode.Text;
                market.ShowDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void exittologin_Click(object sender, EventArgs e)
        {
            string MessageBoxTitle = " ";
            string MessageBoxContent = "Do You Want To Go Back Login ?";

            DialogResult dialogResult = MessageBox.Show(MessageBoxContent, MessageBoxTitle, MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {

                this.Hide();

                logintosystem LOG = new logintosystem();

                LOG.ShowDialog();
            }
            else if (dialogResult == DialogResult.Cancel)
            {
                //do something else
            }
        }

        private void admincontrol_Click(object sender, EventArgs e)
        {
            try
            {

                this.Hide();
                CABLE CABLEFORM = new CABLE();
                CABLEFORM.cablestaff.Text = menuactivestaff.Text;
                CABLEFORM.cablecode1.Text = menucode.Text;
                CABLEFORM.ShowDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void mainmenu_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
