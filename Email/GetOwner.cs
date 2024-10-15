using Email._1.DataAcccess.Abstract;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Email
{

    public partial class GetOwner : Form
    {
        private OwnerDA ownerDA;
        private HomelandRent homelandRent;
        private HomelandSell homelandSell;
        private HomelandLand homelandLand;
        private HomelandObyekt homelandObyekt;
        private HomelandOffice homelandOffice;
        private List<Sell> sell;
        private List<RentHome> rent;
        private List<Land> land;
        private List<Office> office;
        private List<Obyekt> obyekt;
        public GetOwner()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            homelandRent = new HomelandRent();
            homelandSell = new HomelandSell();
            homelandLand = new HomelandLand();
            homelandOffice = new HomelandOffice();
            homelandObyekt = new HomelandObyekt();
            ownerDA = new OwnerDA();
            var AllData = ownerDA.GetAll();
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
            label16.Text=AllData.Count.ToString(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in rent)
            {
                if (item.Email != null)
                {
                    var data = new Owner()
                    {
                        Email = item.Email,
                        ForeignId = item.Id,
                        Kind = "rent",
                        Number=item.Number,
                        Fullname=item.Fullname
                    };
                    ownerDA.Add(data);
                }
            }
            MessageBox.Show($"Yükləndi. Rent {rent.Count()}");


            foreach (var item in sell)
            {
                if (item.Email != null)
                {
                    var data = new Owner()
                    {
                        Email = item.Email,
                        ForeignId = item.Id,
                        Kind = "sell",
                        Number = item.Number,
                        Fullname = item.Fullname
                    };
                    ownerDA.Add(data);
                }
            }
            MessageBox.Show($"Yükləndi. sell {sell.Count()}");


            foreach (var item in land)
            {
                if (item.Email != null)
                {
                    var data = new Owner()
                    {
                        Email = item.Email,
                        ForeignId = item.Id,
                        Kind = "land",
                        Number = item.Number,
                        Fullname = item.Fullname
                    };
                    ownerDA.Add(data);
                }
            }
            MessageBox.Show($"Yükləndi. Land {land.Count()}");

            foreach (var item in office)
            {
                if (item.Email != null)
                {
                    var data = new Owner()
                    {
                        Email = item.Email,
                        ForeignId = item.Id,
                        Kind = "office",
                        Number = item.Number,
                        Fullname = item.Fullname
                    };
                    ownerDA.Add(data);
                }
            }
            MessageBox.Show($"Yükləndi. Office {office.Count()}");

            foreach (var item in obyekt)
            {
                if (item.Email != null)
                {
                    var data = new Owner()
                    {
                        Email = item.Email,
                        ForeignId = item.Id,
                        Kind = "obyekt",
                        Number = item.Number,
                        Fullname = item.Fullname
                    };
                    ownerDA.Add(data);
                }
            }
            MessageBox.Show($"Yükləndi. Obyekt {obyekt.Count()}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var MainPage = new MainPage();
            MainPage.Show();
            this.Hide();
        }
    }
}
