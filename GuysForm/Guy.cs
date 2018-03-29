// Paolo T. Inocencion
// COSC 420 Special Topics
// Guys Form
// March 28, 2018
 
using System;
using System.Windows.Forms;

public class Guy
{
    public string Name;
    public int Cash;
    public string status = "Transaction Completed.";

    public int GiveCash(int amount)
    {
        if (amount <= Cash && amount > 0)
        {
            Cash -= amount;
            status = "Transaction Completed.";
            return amount;
        } else
        {
            status = "I don't enough cash to give you $" + amount + " " + Name + " says...";

            //MessageBox.Show("I don't enough cash to give you " + amount, Name + " says...");
            return 0;
        }
    }

    public int ReceiveCash(int amount)
    {
        if (amount > 0)
        {
            Cash += amount;
            status = "Transaction Completed.";
            return amount;
        } else
        {
            status = amount + " isn't an amount I'll take " + Name + " says... You are broke.";

            //MessageBox.Show(amount + " isn't an amount I'll take", Name + " says...");
            return 0;
        }
    }
	
	
}
