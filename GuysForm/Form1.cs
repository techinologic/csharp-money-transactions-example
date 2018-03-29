// Paolo T. Inocencion
// COSC 420 Special Topics
// Guys Form
// March 28, 2018

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuysForm
{
    public partial class Form1 : Form
    {
        Guy joe, bob;
        int bank = 10;

        public void UpdateForm()
        {
            joesCashLabel.Text = joe.Name + " has $" + joe.Cash;
            bobsCashLabel.Text = bob.Name + " has $" + bob.Cash;
            bankCashLabel.Text = "The bank has $" + bank;
        }

        public Form1()
        {
            InitializeComponent();
            bob = new Guy() { Cash = 40, Name = "Bob" };
            joe = new Guy() { Cash = 20, Name = "Joe" };
            UpdateForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
                messageLabel.Text = "Transaction completed.";
            } else
            {
                //MessageBox.Show("The bank is out of money");
                messageLabel.Text = "The bank is out of money";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            messageLabel.Text = bob.status;

            UpdateForm();
        }

        private void joesGivesToBob_Click(object sender, EventArgs e)
        {
            bob.ReceiveCash(joe.GiveCash(10));
            messageLabel.Text = bob.status;

            UpdateForm();
        }

        private void bobGivesToJoe_Click(object sender, EventArgs e)
        {
            joe.ReceiveCash(bob.GiveCash(5));

            messageLabel.Text = joe.status;

            UpdateForm();
        }








    }
}
