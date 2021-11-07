using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PersonalBudgetPlanner
{
    public partial class PropertyExpense : Form
    {
        public PropertyExpense()
        {
            InitializeComponent();
            backColour = Color.FromArgb(121, 198, 132);//set rgb value of backcolour theme for form to backcolour
            //checks if there already exists a rent  or buy expenses            
            if (UserBudget.currentBudget.UserExpenses.containsType(buy))// if their already exists a buy expense 
               {
                 txbOutput.Text = UserBudget.currentBudget.UserExpenses.returnExpenseDisplay(buy);//output buy expense for user to see
                 btnDelete.Visible = true; // sets delete button to visible as there is a buy expense to delete
               }
            if (UserBudget.currentBudget.UserExpenses.containsType(rent)) // if the expense is a Rent expense
               {
                  txbOutput.Text = UserBudget.currentBudget.UserExpenses.returnExpenseDisplay(rent);//output rent expense for user to see
                  btnDelete.Visible = true; // sets delete button to visible as there is a rent expense to delete
               }
   
        }

        bool monRent = false;//boolean to check if monthly rental amount has been entered or not
        bool purchPrice = false;//boolean to check if purchase price has been entered or not
        bool totDep = false;//boolean to check if property price has been entered or not

        Color backColour = new Color();//make object for backcolour theme, to change panel colours back to normal colour scheme for form.Used in validation methods
        Type buy = typeof(Buy_Expense);//create a type for buying expenses to be used in checking if a buying expense already exists
        Type rent = typeof(Rent_Expense);//create a type for rent expenses to be used in checking if a rent expense already exists


  
        public void resetInputs()// resets inputs by unselecting both rbs and triggering their code dor this event
        {
            rbBuy.Checked = false;
            rbRent.Checked = false;

        }

        public bool checkRentNull()//checks that all values needed for rent have been entered by user
        {
            bool output = true;
            if (monRent == false)
            {
                 output = false;
            }
            return output;
        }

        public bool checkBuyNull()//checks that all values needed to buy have been entered by user
        {
            bool output = true;
            if (purchPrice == false || totDep == false)
            {
                output = false;
            }
            return output;
        }
        private void rbBuy_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBuy.Checked == true) //if rb is checked
            {
                rbRent.Checked = false;//uncheck
                pnlRent.Visible =false;//make rent not visible
                pnlBuy.Visible = true;//make buy pnl visible
            }
            else //if this rb is de selected set all txbs and pnls and fonts to default values and text
            {
                txbPurchPrice.Text = "Purchase Price";
                txbPurchPrice.Font = new Font(txbPurchPrice.Font, FontStyle.Italic);
                pnlPurchPrice.BackColor = backColour;
                txbTotDep.Text = "Total Deposit";
                txbPurchPrice.Font = new Font(txbPurchPrice.Font, FontStyle.Italic);
                pnlTotDep.BackColor = backColour;
                numericUpDownInterestRate.Value = 0;
                numericUpDownMonRepay.Value = 240;
                pnlBuy.Visible = false;
            }

        }

        private void rbRent_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRent.Checked == true)
            {
                rbBuy.Checked = false; //uncheck buy
                pnlRent.Visible = true;//make buy panel not visible
                pnlBuy.Visible = false;//show buy pnl
            }
            else//if this rb is de selected set all txbs and pnls and fonts to default values and text
            {
                txbMonRent.Text = "Monthly Rental Amount";
                txbMonRent.Font = new Font(txbMonRent.Font, FontStyle.Italic);
                pnlMonRent.BackColor = backColour;
                pnlRent.Visible = false;
            }
        }

        private void txbMonRent_TextChanged(object sender, EventArgs e)
        {
            monRent = Validation.validateCurrency(pnlMonRent, txbMonRent.Text, backColour);//checks if txb input is appropriate and assigns output to check variable
        }

        private void txbMonRent_Enter(object sender, EventArgs e)//When txb is "entered" , this empties txb if default text is present, so user may enter their value
        {
            if (txbMonRent.Text == "Monthly Rental Amount")
            {
                txbMonRent.Text = "";

                txbMonRent.Font = new Font(txbMonRent.Font, FontStyle.Regular);
            }
        }

        private void txbMonRent_Leave(object sender, EventArgs e)//sets textbox text to a default value if user leaves textbox and has not entered their value
        {
            if (txbMonRent.Text == "")
            {
                txbMonRent.Text = "Monthly Rental Amount";

                txbMonRent.Font = new Font(txbMonRent.Font, FontStyle.Italic);
            }
        }

        private void txbPurchPrice_Enter(object sender, EventArgs e)//When txb is "entered" , this empties txb if default text is present, so user may enter their value
        {
            if (txbPurchPrice.Text == "Purchase Price")
            {
                txbPurchPrice.Text = "";

                txbPurchPrice.Font = new Font(txbPurchPrice.Font, FontStyle.Regular);
            }
        }

        private void TotDep_Enter(object sender, EventArgs e)//When txb is "entered" , this empties txb if default text is present, so user may enter their value
        {
            if (txbTotDep.Text == "Total Deposit")
            {
                txbTotDep.Text = "";
            
                txbTotDep.Font = new Font(txbTotDep.Font, FontStyle.Regular);
            }
        }

        private void TotDep_Leave(object sender, EventArgs e)//sets textbox text to a default value if user leaves textbox and has not entered their value
        {
            if (txbTotDep.Text =="")
            {
                txbTotDep.Text = "Total Deposit";

                txbTotDep.Font = new Font(txbTotDep.Font, FontStyle.Italic);
            }
        }

        private void txbPurchPrice_Leave(object sender, EventArgs e)//sets textbox text to a default value if user leaves textbox and has not entered their value
        {
            if (txbPurchPrice.Text == "")
            {
                txbPurchPrice.Text = "Purchase Price";

                txbPurchPrice.Font = new Font(txbPurchPrice.Font, FontStyle.Italic);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (!(UserBudget.currentBudget.UserExpenses.containsType(buy)  || UserBudget.currentBudget.UserExpenses.containsType(rent)))
            {   //if there does not exist a buy or rent
                if (rbBuy.Checked || rbRent.Checked) //if one of the rb is selected
                {
                    if (rbRent.Checked)//if rent is checked
                    {
                        if (checkRentNull()) //if unputs are not null
                        {
                            double monRent = double.Parse(Validation.alterCurrency(txbMonRent.Text));
                            //get input for rent expense
                            Rent_Expense newRent = new Rent_Expense(monRent);
                            //make rent expense
                            UserBudget.currentBudget.UserExpenses.addExpense(newRent);
                            //add rent expense to expense list
                            txbOutput.Text = newRent.displayExpenses();
                            //set output text to rent expense string display
                            btnDelete.Visible = true;
                            //make delete visible as their is now a rent expense to delete
                            resetInputs();
                            //reset inputs to default values
                            BudgetForm current = (BudgetForm)BudgetForm.ActiveForm;
                            current.setLiveIncome();
                            //as an expense was added the remaining money has changed thus we call setLiveIncome to update this on the BudgetForm
                        }
                        else
                        {
                            MessageBox.Show("Incorrect currency format or a Value was not entered", "Input incorrect",  MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                       
                    }
                    if (rbBuy.Checked) //if buy is checked
                    {
                        if (checkBuyNull())
                        {
                            double purchPrice = double.Parse(Validation.alterCurrency(txbPurchPrice.Text));
                            double totDep = double.Parse(Validation.alterCurrency(txbTotDep.Text));
                            double intRate = double.Parse(numericUpDownInterestRate.Value + "");
                            double monRepay = double.Parse(numericUpDownMonRepay.Value + "");
                            //get input for a buy expense
                            Buy_Expense newBuy = new Buy_Expense(purchPrice, totDep, intRate, monRepay);
                            //make buy expense
                            UserBudget.currentBudget.UserExpenses.addExpense(newBuy);
                            //add buy expense to expense list
                            newBuy.homeLoanWarning(UserBudget.currentBudget.GrossMonInc);
                            //call homeloan warning for buy expense
                            txbOutput.Text = newBuy.displayExpenses();
                            //set output text to buy expense string display
                            btnDelete.Visible = true;
                            //make delete visible as their is now a rent expense to delete
                            resetInputs();
                            //reset inputs to default values
                            BudgetForm current = (BudgetForm)BudgetForm.ActiveForm;
                            current.setLiveIncome();
                            //as an expense was added the remaining money has changed thus we call setLiveIncome to update this on the BudgetForm
                        }
                        else
                        {
                            MessageBox.Show("Incorrect currency format or a Value was not entered", "Input incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
                else
                {
                    MessageBox.Show("You have not selected a property type. Please select Buy or Rent", "No poperty type selected", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You already have a Property expense. Please delete your current one first and try again",
                           "Property Expense already exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void txbPurchPrice_TextChanged(object sender, EventArgs e)
        {
            purchPrice = Validation.validateCurrency(pnlPurchPrice, txbPurchPrice.Text, backColour);//checks if txb input is appropriate and assigns output to check variable
        }

        private void txbTotDep_TextChanged(object sender, EventArgs e)
        {
            totDep = Validation.validateCurrency(pnlTotDep, txbTotDep.Text, backColour);//checks if txb input is appropriate and assigns output to check variable
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (UserBudget.currentBudget.UserExpenses.containsType(buy)) // if there exists a buy expense
            {
                UserBudget.currentBudget.UserExpenses.deleteExpense(buy);//deletes expense of type buy from list of expenses
                BudgetForm current = (BudgetForm)BudgetForm.ActiveForm;
                current.setLiveIncome(); //set live income as an expense was deleted so remaining money has changed
                txbOutput.Text = "";//there is no expense to display so set output txb text to nothing
                resetInputs();//resetInputs to ensure inputs are appropriate for a user to enter a new generic expense
            }
            if (UserBudget.currentBudget.UserExpenses.containsType(rent))// if there exists a buy expense
            {
                UserBudget.currentBudget.UserExpenses.deleteExpense(rent);//deletes expense of type rent from list of expenses
                BudgetForm current = (BudgetForm)BudgetForm.ActiveForm;
                current.setLiveIncome();//set live income as an expense was deleted so remaining money has changed
                txbOutput.Text = "";//there is no expense to display so set output txb text to nothing
                resetInputs();//resetInputs to ensure inputs are appropriate for a user to enter a new generic expense
                btnDelete.Visible = false;// there is no longer an expense of generic to delete so the delete button must be unaccessible
            }
        }
    }
}
