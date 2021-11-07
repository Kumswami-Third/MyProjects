using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PersonalBudgetPlanner
{
    public partial class BudgetReport : Form //form made to specifically display a report of all expenses in descending order
    {
        public BudgetReport()
        {
            InitializeComponent();
            displayExpenses();//calls display method to display all expenses in relevant txbs such that it is in descending order
        }

        public void displayExpenses()//displays all expenses in relevant txbs such that it is in descending order
        {
            //sort list in descending order so that highest expense will be at index 0 and as you increase in the index of the list(1,2,3..)
            // the total for the expense at that index decreases
            UserBudget.currentBudget.UserExpenses.sortExpenses();
           
            switch (UserBudget.currentBudget.UserExpenses.size()) //runs code depending on size of current budgets expense list
            {
                case 0: // if no expenses exist output error message in red to txb
                    txbHighest.ForeColor = Color.Red;
                    txbHighest.Text = "No Expenses made yet.Please make and Expense first before trying to view a Budget Report";
                    break;                   
                case 1: // if theres 1 expense only display to highest txb
                    txbHighest.Text = "Highest Expense:\r\n" + UserBudget.currentBudget.UserExpenses.returnExpense(0); //set highest expense txb to highest expense @ index 0
                    changeColour(UserBudget.currentBudget.UserExpenses.returnSingleExpense(0), txbHighest);//sets colour of txb text to colour of the type of expense in the txb
                    break;
                case 2:// if theres 2 expense only display to highest and lowest txb
                    txbHighest.Text = "Highest Expense:\r\n" + UserBudget.currentBudget.UserExpenses.returnExpense(0); //set highest expense txb to highest expense @ index 0
                    changeColour(UserBudget.currentBudget.UserExpenses.returnSingleExpense(0), txbHighest);//sets colour of txb text to colour of the type of expense in the txb
                    txbLowest.Text = "Lowest Expense:\r\n" + UserBudget.currentBudget.UserExpenses.returnExpense(1);//set Lowest expense txb to highest expense @ index 1
                    changeColour(UserBudget.currentBudget.UserExpenses.returnSingleExpense(1), txbLowest);//sets colour of txb text to colour of the type of expense in the txb
                    break;
                case 3:// if theres 3 expenses display to all txbs
                    txbHighest.Text = "Highest Expense:\r\n" + UserBudget.currentBudget.UserExpenses.returnExpense(0);//set highest expense txb to highest expense @ index 0
                    changeColour(UserBudget.currentBudget.UserExpenses.returnSingleExpense(0), txbHighest);//sets colour of txb text to colour of the type of expense in the txb
                    txbMedium.Text = "Medium Expense:\r\n" + UserBudget.currentBudget.UserExpenses.returnExpense(1);//set medium expense txb to highest expense @ index 1
                    changeColour(UserBudget.currentBudget.UserExpenses.returnSingleExpense(1), txbMedium);//sets colour of txb text to colour of the type of expense in the txb
                    txbLowest.Text = "Lowest Expense:\r\n" + UserBudget.currentBudget.UserExpenses.returnExpense(2);//set lowest expense txb to highest expense @ index 2
                    changeColour(UserBudget.currentBudget.UserExpenses.returnSingleExpense(2), txbLowest);//sets colour of txb text to colour of the type of expense in the txb
                    break;

                default:
                    break;
            }
 
        }

        private void changeColour(Expenses temp, TextBox output) // changes txb text colour based on a given type 
        {
            Type currentType = temp.GetType();// gets type of expense input
            Color backColour = new Color();//creates color variable
            switch (temp) //checks type of child the temp expense is
            {

                case GenericExpenses g: //sets txb text to colour scheme of generic expenses
                    backColour = Color.FromArgb(253, 66, 125);
                    output.ForeColor = backColour;

                    break;

                case Buy_Expense b://sets txb text to colour scheme of buy expenses
                    backColour = Color.FromArgb(121, 198, 132);
                    output.ForeColor = backColour;

                    break;

                case Rent_Expense r://sets txb text to colour scheme of rent expenses
                    backColour = Color.FromArgb(121, 198, 132);
                    output.ForeColor = backColour;
                    break;

                case VehicleExpense v://sets txb text to colour scheme of vehicle expenses
                    backColour = Color.FromArgb(35, 141, 214);
                    output.ForeColor = backColour;
                    break;

                default:
                    break;
            }
        }
        private void txbHighest_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblReport_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BudgetReport_Load(object sender, EventArgs e)
        {

        }
    }
}

