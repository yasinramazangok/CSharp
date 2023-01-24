using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml; // xml işlemleri için gerekli sınıf

namespace CurrencyApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string today = "https://www.tcmb.gov.tr/kurlar/today.xml";
            var xmlFile = new XmlDocument(); // var ile değişken tanımlama sebebimiz, veri çektiğimiz yerden gelen verinin türünü bilmediğimiz içindir.
            // Ayrıca burada bir nevi değişkene nesne görevi yüklenmiş oluyor.
            xmlFile.Load(today);

            string dollarBuying = xmlFile.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteBuying").InnerXml;
            lblDollarBuying.Text = dollarBuying;

            string dollarSelling = xmlFile.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
            lblDollarSelling.Text = dollarSelling;

            string euroBuying = xmlFile.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteBuying").InnerXml;
            lblEuroBuying.Text = euroBuying;

            string euroSelling = xmlFile.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;
            lblEuroSelling.Text = euroSelling;
        }

        private void btnDollarBuying_Click(object sender, EventArgs e)
        {
            txtExchangeRate.Text = lblDollarBuying.Text;
        }

        private void btnDollarSelling_Click(object sender, EventArgs e)
        {
            txtExchangeRate.Text = lblDollarSelling.Text;
        }

        private void btnEuroBuying_Click(object sender, EventArgs e)
        {
            txtExchangeRate.Text = lblEuroBuying.Text;
        }

        private void btnEuroSelling_Click(object sender, EventArgs e)
        {
            txtExchangeRate.Text = lblEuroSelling.Text;
        }

        private void txtExchangeRate_TextChanged(object sender, EventArgs e)
        {
            txtExchangeRate.Text = txtExchangeRate.Text.Replace(".",",");
            // Dışarıdan veri girişi yapıldığında eğer kullanıcı nokta ile ondalıklı sayı girişi yaparsa bunu C# 
            // integer türünde bir sayı olarak algılıyor. Bu yüzden '.' ile girilse bile ','e çevirerek sistemin bunu ondalıklı
            // sayı olarak tanımasını sağlıyoruz.
        }

        private void btnCurrencyBuy_Click(object sender, EventArgs e)
        {
            double exchangeRate, amount, total;
            exchangeRate = Convert.ToDouble(txtExchangeRate.Text);
            amount = Convert.ToDouble(txtAmount.Text);
            total = exchangeRate * amount;
            txtTotal.Text = total.ToString()+" TL";


           
        }

        private void btnCurrencySell_Click(object sender, EventArgs e)
        {
            double exchangeRate, change;
            int amount, total;
            exchangeRate = Convert.ToDouble(txtExchangeRate.Text);
            amount = Convert.ToInt32(txtAmount.Text);
            total = Convert.ToInt32(amount / exchangeRate);
            change = amount % exchangeRate;
            txtTotal.Text = total.ToString();
            txtChange.Text = change.ToString(); 
        }
    }
}
