using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace VKURS_1._001
{
    public partial class mainkurs : Form
    {
        public mainkurs()
        {
            InitializeComponent();
        }

        private String USD()
        {
            System.Net.WebClient wc = new System.Net.WebClient();
            String Response = wc.DownloadString("http://resources.finance.ua/ru/public/currency-cash.xml");
            String buy = System.Text.RegularExpressions.Regex.Match(Response, @"id=""USD"" br=""([0-9]+\.[0-9]+)""").Groups[1].Value;
            //String sell = System.Text.RegularExpressions.Regex.Match(Response, @"id=""USD"" ar=""([0-9]+\.[0-9]+)""").Groups[2].Value;
            return "USD \n" + "Покупка - " + buy; //+ "\n"+ "Продажа: " + sell;
        }
        private String EUR()
        {
            System.Net.WebClient wc = new System.Net.WebClient();
            String Response = wc.DownloadString("http://resources.finance.ua/ru/public/currency-cash.xml");
            String buy = System.Text.RegularExpressions.Regex.Match(Response, @"id=""EUR"" br=""([0-9]+\.[0-9]+)""").Groups[1].Value;
            //String sell = System.Text.RegularExpressions.Regex.Match(Response, @"id=""USD"" ar=""([0-9]+\.[0-9]+)""").Groups[1].Value;
            return "EUR \n" + "Покупка - " + buy;
        }
        private String RUB()
        {
            System.Net.WebClient wc = new System.Net.WebClient();
            String Response = wc.DownloadString("http://resources.finance.ua/ru/public/currency-cash.xml");
            String buy = System.Text.RegularExpressions.Regex.Match(Response, @"id=""RUB"" br=""([0-9]+\.[0-9]+)""").Groups[1].Value;
            return "RUB \n" + "Покупка - " + buy;
        }
        private String KZT()
        {
            System.Net.WebClient wc = new System.Net.WebClient();
            String Response = wc.DownloadString("http://resources.finance.ua/ru/public/currency-cash.xml");
            String buy = System.Text.RegularExpressions.Regex.Match(Response, @"id=""KZT"" br=""([0-9]+\.[0-9]+)""").Groups[1].Value;
            return "KZT \n" + "Покупка - " + buy;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(USD());
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(EUR());
        }
        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(RUB());
        }
        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(KZT());
        }
    }   
}
