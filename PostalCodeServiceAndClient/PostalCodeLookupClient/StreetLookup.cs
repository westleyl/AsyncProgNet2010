using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PostalCodeLookup;

namespace PostalCodeClient
{
    public partial class StreetLookup : Form
    {
        public StreetLookup()
        {
            InitializeComponent();
        }

        private async void bFindStreet_Click(object sender, EventArgs e)
        {
            string[] postalCodeList = tSearchPostalCode.Text.Substring(1).Split(tSearchPostalCode.Text[0]);

            StreetData[] resultList;
            var beforeCallingWebClient = DateTime.Now;

            if (!cUseAsync.Checked)
            {
                resultList = new StreetData[postalCodeList.Length];
                for (var i = 0; i < postalCodeList.Length; i++)
                {
                    resultList[i] = GetSingleAddress(postalCodeList[i]);
                }
            }
            else
            {
                var allStreetSearches = new Task<StreetData>[postalCodeList.Length];
                for (var i = 0; i < postalCodeList.Length; i++)
                {
                    allStreetSearches[i] = GetSingleAddressAsync(postalCodeList[i]);
                }
                resultList = await Task.WhenAll(allStreetSearches);
            }
            tProgress.Text = String.Format("Total time taken : {0:n} s.", (DateTime.Now.Subtract(beforeCallingWebClient).TotalSeconds));

            DisplaySingleAddress(resultList[0]);
            foreach(var result in resultList)
            {
                tAllResults.Text += String.Format("{0}, {1}, {2}, {3}, {4}", 
                                    result.RoadName, result.Town, result.City, result.County,
                                    result.PostalCode) + "\r\n";
            }
            tAllResults.Text += "(" + tProgress.Text + ")\r\n\r\n";
        }

        private StreetData GetSingleAddress(string postalCode)
        {
            var wcfClient = new StreetLookupClient();
            return wcfClient.GetStreet(postalCode);
        }
        private async Task<StreetData> GetSingleAddressAsync(string postalCode)
        {
            var wcfClient = new StreetLookupClient();
            var sd = await wcfClient.GetStreetAsync(postalCode);
            return sd;
        }

        private void DisplaySingleAddress(StreetData myStreet)
        {
            if (String.IsNullOrWhiteSpace(myStreet.PostalCode))
            {
                FormatTextBox(tRoadName, "Road name", true);
                FormatTextBox(tTown, "Town", true);
                FormatTextBox(tCity, "City", true);
                FormatTextBox(tCounty, "County", true);
                FormatTextBox(tPostalCode, "Postal code", true);
            }
            else
            {
                FormatTextBox(tRoadName, myStreet.RoadName, false);
                FormatTextBox(tTown, myStreet.Town, false);
                FormatTextBox(tCity, myStreet.City, false);
                FormatTextBox(tCounty, myStreet.County, false);
                FormatTextBox(tPostalCode, myStreet.PostalCode, false);
            }
        }

        private void FormatTextBox(TextBox tb, string contents, bool isDefault)
        {
            tb.Enabled = !isDefault;
            tb.Text = contents;
            tb.Font = new Font(tb.Font.FontFamily, tb.Font.Size, isDefault ? FontStyle.Italic : FontStyle.Regular);
        }

        private void tTown_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
