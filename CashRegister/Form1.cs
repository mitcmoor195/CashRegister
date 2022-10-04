using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace CashRegister
{
    public partial class Form1 : Form
    {
        double hats;
        double robes;
        double books;
        double hatsCost = 30;
        double robesCost = 55;
        double booksCost = 47;
        double hatsTotal = 30;
        double robesTotal = 55;
        double booksTotal = 47;
        double subtotal;
        double tax = 0.27;
        double taxAmount;
        double total;
        double tendered;
        double change;

        public Form1()
        {
            InitializeComponent();
        }

        private void priceButton_Click(object sender, EventArgs e)
        {
            hats = Convert.ToDouble(hatsInput.Value);
            robes = Convert.ToDouble(robesInput.Value);
            books = Convert.ToDouble(booksInput.Value);

            hatsTotal = hats * hatsCost;
            robesTotal = robes * robesCost;
            booksTotal = books * booksCost;

            subtotal = (hats * hatsCost) + (robes * robesCost) + (books * booksCost);
            taxAmount = subtotal * tax;
            total = taxAmount + subtotal;

            subtotalOutput.Text = $"{subtotal.ToString(".00g")}";
            taxOutput.Text = $"{taxAmount.ToString(".00g")}";
            totalOutput.Text = $"{total.ToString(".00g")}";

            changeButton.Enabled = true;
            tenderedInput.Visible = true;
                
            
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                tendered = Convert.ToDouble(tenderedInput.Text);
                if (tendered < total)
                {
                    receiptTitle.Text = "Insufficient Funds Given";
                    SoundPlayer errorSound = new SoundPlayer(Properties.Resources.error);
                    errorSound.Play();
                }
                else
                {

                    change = tendered - total;

                    changeOutput.Text = $"{change.ToString(".00g")}";

                    SoundPlayer chachingSound = new SoundPlayer(Properties.Resources.cha_ching);
                    chachingSound.Play();

                    receiptButton.Enabled = true;
                }
            }
            catch
            {
                tenderedInput.Text = "";
            }
        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            hats = Convert.ToDouble(hatsInput.Value);
            robes = Convert.ToDouble(robesInput.Value);
            books = Convert.ToDouble(booksInput.Value);
            DateTime now = DateTime.Now;

            hatsTotal = hats * hatsCost;
            robesTotal = robes * robesCost;
            booksTotal = books * booksCost;

                SoundPlayer printSound = new SoundPlayer(Properties.Resources.receipt_printing);
                printSound.Play();

                receiptTitle.Text = $"Ye Olde Wizard Shoppe";
                Thread.Sleep(750);
                Refresh();
                receiptTitle.Text += $"\n~~~~~~~~~~~~~~~~~~~~~~~~~~";
                Thread.Sleep(750);
                Refresh();
                receiptLeft.Text = $"Wizard Hats x{hats}";
                receiptRight.Text = $"@{hatsTotal}g";
                Thread.Sleep(750);
                Refresh();
                receiptLeft.Text += $"\nWizard Robes x{robes}";
                receiptRight.Text += $"\n@{robesTotal.ToString(".00g")}";
                Thread.Sleep(750);
                Refresh();
                receiptLeft.Text += $"\nSpellbooks x{books}";
                receiptRight.Text += $"\n@{booksTotal.ToString(".00g")}";
                Thread.Sleep(750);
                Refresh();
                receiptLeft.Text += $"\n\nSubtotal";
                receiptRight.Text += $"\n\n{subtotal.ToString(".00g")}";
                Thread.Sleep(750);
                Refresh();
                receiptLeft.Text += $"\nTax";
                receiptRight.Text += $"\n{taxAmount.ToString(".00g")}";
                Thread.Sleep(750);
                Refresh();
                receiptLeft.Text += $"\nTotal";
                receiptRight.Text += $"\n{total.ToString(".00g")}";
                Thread.Sleep(750);
                Refresh();
                receiptLeft.Text += $"\n\nTendered";
                receiptRight.Text += $"\n\n{tendered.ToString(".00g")}";
                Thread.Sleep(750);
                Refresh();
                receiptLeft.Text += $"\nChange Due";
                receiptRight.Text += $"\n{change.ToString(".00g")}";
                Thread.Sleep(750);
                Refresh();
                receiptBottom.Text = $"{now.ToString("F")}";
                Thread.Sleep(750);
                Refresh();
                receiptBottom.Text += $"\nThank you for your purchase!";
                neworderButton.Enabled = true;

        }

        private void neworderButton_Click(object sender, EventArgs e)
        {
            receiptTitle.Text = "";
            receiptLeft.Text = "";
            receiptRight.Text = "";
            receiptBottom.Text = "";

            changeOutput.Text = "";
            tenderedInput.Text = "";

            subtotalOutput.Text = "";
            taxOutput.Text = "";
            totalOutput.Text = "";

            hatsInput.Value = 0;
            robesInput.Value = 0;
            booksInput.Value = 0;

            tenderedInput.Visible = false;
            changeButton.Enabled = false;
            receiptButton.Enabled = false;
            neworderButton.Enabled = false;
        }
    }
}
