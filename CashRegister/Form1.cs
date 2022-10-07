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
            ///ensure item values are correct variable types
            hats = Convert.ToDouble(hatsInput.Value);
            robes = Convert.ToDouble(robesInput.Value);
            books = Convert.ToDouble(booksInput.Value);

            ///calclate subtotal, tax and total values
            subtotal = (hats * hatsCost) + (robes * robesCost) + (books * booksCost);
            taxAmount = subtotal * tax;
            total = taxAmount + subtotal;

            ///output subtotal, tax and total values as text
            subtotalOutput.Text = $"{subtotal.ToString(".00g")}";
            taxOutput.Text = $"{taxAmount.ToString(".00g")}";
            totalOutput.Text = $"{total.ToString(".00g")}";

            ///allow "calculate" button to be clicked and "amount tendered" input to take inputs
            changeButton.Enabled = true;
            tenderedInput.Visible = true;
                
            
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                ///ensure "tendered" variable is correctly formatted
                tendered = Convert.ToDouble(tenderedInput.Text);
                if (tendered < total)
                {
                    /// display that not enough money has been tendered
                    receiptTitle.Text = "Insufficient Funds Given";

                    ///add and play sound for not enough money being tendered
                    SoundPlayer errorSound = new SoundPlayer(Properties.Resources.error);
                    errorSound.Play();
                }
                else
                {
                    ///calculate how change vlaue
                    change = tendered - total;

                    ///output change value to text
                    changeOutput.Text = $"{change.ToString(".00g")}";

                    ///add and play sound of change amount being confirmed
                    SoundPlayer chachingSound = new SoundPlayer(Properties.Resources.cha_ching);
                    chachingSound.Play();

                    ///enable "confirm order?" button
                    receiptButton.Enabled = true;
                }
            }
            catch
            {
                /// if there is an error, set input to default to stop error
                tenderedInput.Text = "";
            }
        }

        private void receiptButton_Click(object sender, EventArgs e)
        {
            ///ensure values match variable types
            hats = Convert.ToDouble(hatsInput.Value);
            robes = Convert.ToDouble(robesInput.Value);
            books = Convert.ToDouble(booksInput.Value);

            ///find current date and time
            DateTime now = DateTime.Now;

            ///calculate the total cost of items purchased
            hatsTotal = hats * hatsCost;
            robesTotal = robes * robesCost;
            booksTotal = books * booksCost;

            ///add and play sound of receipt printing
                SoundPlayer printSound = new SoundPlayer(Properties.Resources.receipt_printing);
                printSound.Play();

            ///print text onto the receipt
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
                ///enable "new order" button
                neworderButton.Enabled = true;

        }

        private void neworderButton_Click(object sender, EventArgs e)
        {
            ///erase receipt
            receiptTitle.Text = "";
            receiptLeft.Text = "";
            receiptRight.Text = "";
            receiptBottom.Text = "";

            ///erase change and tendered values
            changeOutput.Text = "";
            tenderedInput.Text = "";

            ///erase subtotal, tax and total values
            subtotalOutput.Text = "";
            taxOutput.Text = "";
            totalOutput.Text = "";

            ///erase purchased items values
            hatsInput.Value = 0;
            robesInput.Value = 0;
            booksInput.Value = 0;

            ///set all button and input properties to default
            tenderedInput.Visible = false;
            changeButton.Enabled = false;
            receiptButton.Enabled = false;
            neworderButton.Enabled = false;
        }
    }
}
