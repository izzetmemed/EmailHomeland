using Email.MyModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Email
{
    public partial class MainPage : Form
    {
        private AllGmailWin AllGmailWin;
        private CustomerWin CustomerWin;
        private Form1 Form1;
        private GetGmail GetGmail;
        private GetOwner GetOwner;
        private OwnerWin OwnerWin;
        public MainPage()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerWin = new CustomerWin();
            CustomerWin.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OwnerWin = new OwnerWin();
            OwnerWin.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            GetGmail = new GetGmail();
            GetGmail.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AllGmailWin = new AllGmailWin();
            AllGmailWin.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GetOwner = new GetOwner();
            GetOwner.Show();
            this.Hide();
        }
    }
}