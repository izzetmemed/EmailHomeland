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
    public partial class OwnerWin : Form
    {
        public OwnerWin()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            var owner = new OwnerDA();
            var dataTable = owner.GetAll();
            dataGridView1.DataSource = dataTable;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var Text = message.Text;
            if (Text.Length > 0)
            {
                Sure sure = new Sure(Text, "owner");
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
