using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhenAllWhenAny
{
    public partial class frmUIStillResponsive : Form
    {
        public frmUIStillResponsive()
        {
            InitializeComponent();

            lblPlayingCardsCounted.Text = String.Empty;
        }

        private void btnEatMe_Click(object sender, EventArgs e)
        {
            txtBodilyNoises.Text = "Burp!\r\n" + txtBodilyNoises.Text;
        }

        private void btnDrinkMe_Click(object sender, EventArgs e)
        {
            txtBodilyNoises.Text = "Slurp!\r\n" + txtBodilyNoises.Text;
        }

        private void btnCountCards_Click(object sender, EventArgs e)
        {
            if (chkUseAsync.Checked)
            {
                CountCardsAsync();
            }
            else
            {
                CountCards();
            }
        }

        private void CountCards()
        {
            for (int i = 1; i <= 52; i++)
            {
                UpdateCardCountWithRefresh(i);

                var t = Task.Delay(100);
                while (!t.IsCompleted) { }
            }
        }

        private void UpdateCardCount(int i)
        {
            lblPlayingCardsCounted.Text = i.ToString();
        }

        #region Hmmm, just in case that label doesn't update

        private void UpdateCardCountWithRefresh(int i)
        {
            lblPlayingCardsCounted.Text = i.ToString();
            lblPlayingCardsCounted.Refresh();
        }

        #endregion

        private async void CountCardsAsync()
        {
            for (int i = 1; i <= 52; i++)
            {
                UpdateCardCount(i);

                await Task.Delay(100);
            }
        }
    }
}