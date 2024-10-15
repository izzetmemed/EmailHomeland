using Email._1.DataAcccess.Concrate;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Email
{
    public partial class Sure : Form
    {
        private string? Text;
        private string? Kind;
        private dynamic? Data;

        public Sure()
        {
            InitializeComponent();
        }

        public Sure(string message, string kind)
        {
            InitializeComponent();
            Text = message;
            Kind = kind;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (Kind)
            {
                case "customer":
                    var CustomerDA = new CustomerDA();
                    Data = CustomerDA.GetAll(); 
                    break;
                case "owner":
                    var OwnerDA = new OwnerDA();
                    Data = OwnerDA.GetAll();
                    break;
                case "allemail":
                    var allemail = new AllEmailDA();
                    Data = allemail.GetAll();
                    break;
                default:
                    Data = null;
                    MessageBox.Show("Invalid kind specified. kind=null");
                    break;
            }
            if (Data != null)
            {
                foreach (var item in Data)
                {
                    
                }
            }
            else {
                MessageBox.Show("Data is null.");
            }

            MessageBox.Show("Messages have been sent.");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
