using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WEEK6.MnbServiceReference;

namespace WEEK6
{
    public partial class Form1 : Form
    {
        WEEK6.Entities.RateData context = new WEEK6.Entities.RateData();
        BindingList<WEEK6.Entities.RateData> Rates = new BindingList<WEEK6.Entities.RateData>();

        public Form1()
        {
            InitializeComponent();
            
            var mnbService = new MNBArfolyamServiceSoapClient();
            
            var request = new GetExchangeRatesRequestBody()
            {
                currencyNames = "EUR",
                startDate = "2020-01-01",
                endDate = "2020-06-30"
            };

            var response = mnbService.GetExchangeRates(request);
            var result = response.GetExchangeRatesResult;

            dataGridView1.DataSource = Rates;

        }
    }
}
