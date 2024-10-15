using Email._1.DataAcccess.Abstract;
using Email._1.DataAcccess.Concrate;

namespace Email
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            var allemail = new AllEmailDA();
            var dataTable = allemail.GetAll();
            dataGridView1.DataSource = dataTable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Text = message.Text;
            if (Text.Length > 0)
            {
                Sure sure = new Sure(Text, "allemail");
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
    }
}
