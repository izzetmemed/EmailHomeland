using Email._1.DataAcccess.Concrate;
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
    public partial class CustomerWin : Form
    {
        public CustomerWin()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            var CustomerDA = new CustomerDA();
            var dataTable = CustomerDA.GetAll();
            dataGridView1.DataSource = dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Text = message.Text;
            if (Text.Length > 0)
            {
                Sure sure = new Sure(Text, "customer");
                sure.Show();
            }
            else
            {
                MessageBox.Show("Messaj boşdur");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var MainPage = new MainPage();
            MainPage.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
