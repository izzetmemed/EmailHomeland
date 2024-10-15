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

namespace Email.MyModel
{
    public partial class AllGmailWin : Form
    {
        private AllEmailDA allEmailDA;
        private HomelandRent homelandRent;
        private HomelandSell homelandSell;
        private HomelandLand homelandLand;
        private HomelandObyekt homelandObyekt;
        private HomelandOffice homelandOffice;
        private HomelandMediatype homelandMediatype;
        private CustomerEmailDA customerEmailDA;
        private List<Sell> sell;
        private List<RentHome> rent;
        private List<Land> land;
        private List<Office> office;
        private List<Obyekt> obyekt;
        private List<MediaType> Media;
        private List<MediaType> Media0;
        private List<CustomerEmail> customerEmail;
        public AllGmailWin()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            customerEmailDA = new CustomerEmailDA();
            homelandRent = new HomelandRent();
            homelandSell = new HomelandSell();
            homelandLand = new HomelandLand();
            homelandOffice = new HomelandOffice();
            homelandObyekt = new HomelandObyekt();
            homelandMediatype = new HomelandMediatype();
            allEmailDA = new AllEmailDA();

            var AllData = allEmailDA.GetAll();

            var LastGmailRent = AllData.Where(x => x.Kind == "rent").LastOrDefault();
            int LastGmailRentId = LastGmailRent?.ForeignId ?? 0;
            rent = homelandRent.GetAll(x => x.Id > LastGmailRentId);
            label5.Text = rent.Count.ToString();

            var LastGmailSell = AllData.Where(x => x.Kind == "sell").LastOrDefault();
            int LastGmailSellId = LastGmailSell?.ForeignId ?? 0;
            sell = homelandSell.GetAll(x => x.Id > LastGmailSellId);
            label6.Text = sell.Count.ToString();

            var LastGmailLand = AllData.Where(x => x.Kind == "land").LastOrDefault();
            int LastGmailLandId = LastGmailLand?.ForeignId ?? 0;
            land = homelandLand.GetAll(x => x.Id > LastGmailLandId);
            label8.Text = land.Count.ToString();

            var LastGmailOffice = AllData.Where(x => x.Kind == "office").LastOrDefault();
            int LastGmailOfficeId = LastGmailOffice?.ForeignId ?? 0;
            office = homelandOffice.GetAll(x => x.Id > LastGmailOfficeId);
            label12.Text = office.Count.ToString();

            var LastGmailObyekt = AllData.Where(x => x.Kind == "obyekt").LastOrDefault();
            int LastGmailObyektId = LastGmailObyekt?.ForeignId ?? 0;
            obyekt = homelandObyekt.GetAll(x => x.Id > LastGmailObyektId);
            label10.Text = obyekt.Count.ToString();

            var LastGmailCustomer = AllData.Where(x => x.Kind == "customer").LastOrDefault();
            Media = homelandMediatype.GetAll();
            label3.Text = Media.Count.ToString();
            int LastGmailCustomerId = LastGmailCustomer?.ForeignId ?? 0;
            Media0 = Media.Where(x => x.Counter == "0" && x.Id > LastGmailCustomerId).ToList();
            label14.Text = Media0.Count.ToString();
            var LastGmailCustomerEmail = AllData.Where(x => x.Kind == "customerEmail").LastOrDefault();
            int LastGmailCustomerEmailId = LastGmailCustomerEmail?.ForeignId ?? 0;
            customerEmail = customerEmailDA.GetAll(x=>x.Id> LastGmailCustomerEmailId);
            label18.Text=customerEmail.Count.ToString();

            label16.Text = AllData.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in rent)
            {
                if (item.Email != null)
                {
                    var data = new AllEmail()
                    {
                        Email = item.Email,
                        ForeignId = item.Id,
                        Number=item.Number,
                        Fullname=item.Fullname,
                        Kind = "rent"
                    };
                    allEmailDA.Add(data);
                }
            }
            MessageBox.Show($"Yükləndi. Rent {rent.Count()}");


            foreach (var item in sell)
            {
                if (item.Email != null)
                {
                    var data = new AllEmail()
                    {
                        Email = item.Email,
                        ForeignId = item.Id,
                        Number = item.Number,
                        Fullname = item.Fullname,
                        Kind = "sell"
                    };
                    allEmailDA.Add(data);
                }
            }
            MessageBox.Show($"Yükləndi. sell {sell.Count()}");


            foreach (var item in land)
            {
                if (item.Email != null)
                {
                    var data = new AllEmail()
                    {
                        Email = item.Email,
                        ForeignId = item.Id,
                        Number = item.Number,
                        Fullname = item.Fullname,
                        Kind = "land"
                    };
                    allEmailDA.Add(data);
                }
            }
            MessageBox.Show($"Yükləndi. Land {land.Count()}");

            foreach (var item in office)
            {
                if (item.Email != null)
                {
                    var data = new AllEmail()
                    {
                        Email = item.Email,
                        ForeignId = item.Id,
                        Number = item.Number,
                        Fullname = item.Fullname,
                        Kind = "office"
                    };
                    allEmailDA.Add(data);
                }
            }
            MessageBox.Show($"Yükləndi. Office {office.Count()}");

            foreach (var item in obyekt)
            {
                if (item.Email != null)
                {
                    var data = new AllEmail()
                    {
                        Email = item.Email,
                        ForeignId = item.Id,
                        Number = item.Number,
                        Fullname = item.Fullname,
                        Kind = "obyekt"
                    };
                    allEmailDA.Add(data);
                }
            }
            MessageBox.Show($"Yükləndi. Obyekt {obyekt.Count()}");
            foreach (var item in Media0)
            {
                if (item.Number != null)
                {
                    var data = new AllEmail()
                    {
                        Email = item.Number,
                        ForeignId = item.Id,
                        Kind = "customer"
                    };
                    allEmailDA.Add(data);
                }
            }
            MessageBox.Show($"Yükləndi. Media0 {Media0.Count()}");
            foreach (var item in customerEmail)
            {
                if (item.Email != null)
                {
                    var data = new AllEmail()
                    {
                        Email = item.Email,
                        ForeignId = item.Id,
                        Number = item.Number,
                        Fullname = item.Fullname,
                        Kind = "customerEmail"
                    };
                    allEmailDA.Add(data);
                }
            }
            MessageBox.Show($"Yükləndi. customerEmail {customerEmail.Count()}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var MainPage = new MainPage();
            MainPage.Show();
            this.Hide();
        }
    }
}
