using Email._1.DataAcccess.Concrate;
using Email.MyModel.Models;
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
    public partial class GetGmail : Form
    {
        private CustomerDA customerDA;
        private HomelandMediatype mediaType;
        private CustomerEmailDA customerEmailDA;
        private List<MediaType> Media0;
        private List<Customer> customerList;
        private List<CustomerEmail> customerEmails;
        public GetGmail()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            customerDA = new CustomerDA();
            mediaType = new HomelandMediatype();
            customerEmailDA=new CustomerEmailDA();
            customerList = customerDA.GetAll();
            var LastMedia = customerList.Where(x => x.Kind == "media0").LastOrDefault();
            var LastCustomerEmail = customerList.Where(x => x.Kind == "customerEmail").LastOrDefault();
            label16.Text = customerList.Count.ToString();
            label7.Text = mediaType.GetAll().Count.ToString();
            int MediaId = LastMedia?.ForeignId ?? 0;
            Media0 = mediaType.GetAll(x => x.Counter == "0" && x.Id > MediaId);
            label14.Text = Media0.Count().ToString();
            int CustomerEmailId = LastCustomerEmail?.ForeignId ?? 0;
            customerEmails = customerEmailDA.GetAll(x=>x.Id> CustomerEmailId);
            label2.Text = customerEmails.Count().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in Media0)
            {
                var data = new Customer()
                {
                    Email = item.Number,
                    ForeignId = item.Id,
                    Kind="media0"
                };
                customerDA.Add(data);
            }
            MessageBox.Show($"Yükləndi. {Media0.Count()}");
            foreach (var item in customerEmails)
            {
                var data = new Customer()
                {
                    Email = item.Email,
                    Number = item.Number,
                    Fullname=item.Fullname,
                    Kind= "customerEmail",
                    ForeignId = item.Id
                };
                customerDA.Add(data);
            }
            MessageBox.Show($"Yükləndi. {customerEmails.Count()}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var MainPage = new MainPage();
            MainPage.Show();
            this.Hide();
        }
    }
}
