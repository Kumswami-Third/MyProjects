using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PersonalBudgetPlanner
{
    public partial class VehicleExpenseForm : Form
    {
        public VehicleExpenseForm()
        {
            InitializeComponent();
            backColour = Color.FromArgb(35, 141, 214);//set rgb value of backcolour theme for form to backcolour
            if (UserBudget.currentBudget.UserExpenses.containsType(vehicle))//checks if there already exists a Vehicle expenses
            {
                btnDelete.Visible = true;// sets delete button to visible as there is a Vehicle expense to delete
                txbOutput.Text =  UserBudget.currentBudget.UserExpenses.returnExpenseDisplay(vehicle);//output current Vehicle expense for user to see
            }
        }
        bool make = false;//boolean to check if make has been entered or not
        bool model = false;//boolean to check if model has been entered or not
        bool purchPrice = false;//boolean to check if purchise price has been entered or not
        bool totDeopsit = false;//boolean to check if total deposit has been entered or not
        bool interestPrem = false;//boolean to check if interest premium has been entered or not
        Color backColour = new Color();//make object for backcolour theme, to change panel colours back to normal colour scheme for form.Used in validation methods
        Type vehicle = typeof(VehicleExpense); //create a type for generic expenses to be used in checking if a generic expense already exists
        public bool checkNull()//checks that all values needed have been entered by user
        {
            bool output = true;
            List<bool> checks = new List<bool> { make,model,purchPrice,totDeopsit,interestPrem};//stores bool checks in list
            foreach(bool check in checks)//loops through list
            {
                if (check == false)//if one of the bool items in the list is false the set output to false and end loop
                {
                    output = false;
                    break;
                }

            }
            return output;
        }
        
        private void VehicleExpenseForm_Load(object sender, EventArgs e)
        {
           
        }

        public void resetInputs()// resets input textboxes text and font, and panels color, all to default values
        {
            txbMake.Text = "Make";
            txbMake.Font = new Font(txbMake.Font, FontStyle.Italic);
            txbModel.Text = "Model";
            txbModel.Font = new Font(txbModel.Font, FontStyle.Italic);
            txbPurchPrice.Text = "Purchase Price";
            txbPurchPrice.Font = new Font(txbPurchPrice.Font, FontStyle.Italic);
            txbTotDeposit.Text = "Total Deposit";
            txbTotDeposit.Font = new Font(txbTotDeposit.Font, FontStyle.Italic);
            numericUpDownInterestRate.Value = 0;
            txbInsurancePrem.Text = "Insurance Premium";
            txbInsurancePrem.Font = new Font(txbInsurancePrem.Font, FontStyle.Italic);
            List<Panel> outputPanels = new List<Panel> { pnlPurchPrice, pnlTotDeposit, pnlInterestPrem };
            foreach (Panel item in outputPanels)
            {
                item.BackColor = backColour;
            }

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            totDeopsit = Validation.validateCurrency(pnlTotDeposit, txbTotDeposit.Text, backColour);//checks if txb input is appropriate and assigns output to check variable
        }

        private void txbMake_Enter(object sender, EventArgs e)//When txb is "entered" , this empties txb if default text is present, so user may enter their value
        {
            if (txbMake.Text == "Make")
            {
                txbMake.Text = "";

                txbMake.Font = new Font(txbMake.Font, FontStyle.Regular);
            }
        }

        private void txbMake_Leave(object sender, EventArgs e)//sets textbox text to a default value if user leaves textbox and has not entered their value
        {
            if (txbMake.Text == "")
            {
                txbMake.Text = "Make";

                txbMake.Font = new Font(txbMake.Font, FontStyle.Italic);
            }
           
        }

        private void txbModel_Enter(object sender, EventArgs e)//When txb is "entered" , this empties txb if default text is present, so user may enter their value
        {
            if (txbModel.Text == "Model")
            {
                txbModel.Text = "";

                txbModel.Font = new Font(txbModel.Font, FontStyle.Regular);
            }
           
        }

        private void txbModel_Leave(object sender, EventArgs e)//sets textbox text to a default value if user leaves textbox and has not entered their value
        {
            if (txbModel.Text == "")
            {
                txbModel.Text = "Model";

                txbModel.Font = new Font(txbModel.Font, FontStyle.Italic);
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

        private void txbPurchPrice_Leave(object sender, EventArgs e)//sets textbox text to a default value if user leaves textbox and has not entered their value
        {
            if (txbPurchPrice.Text == "")
            {
                txbPurchPrice.Text = "Purchase Price";

                txbPurchPrice.Font = new Font(txbPurchPrice.Font, FontStyle.Italic);
            }
        }

        private void txbTotDeposit_Enter(object sender, EventArgs e)//When txb is "entered" , this empties txb if default text is present, so user may enter their value
        {
            if (txbTotDeposit.Text == "Total Deposit")
            {
                txbTotDeposit.Text = "";

                txbTotDeposit.Font = new Font(txbTotDeposit.Font, FontStyle.Regular);
            }
        }

        private void txbTotDeposit_Leave(object sender, EventArgs e)//sets textbox text to a default value if user leaves textbox and has not entered their value
        {
            if (txbTotDeposit.Text == "")
            {
                txbTotDeposit.Text = "Total Deposit";

                txbTotDeposit.Font = new Font(txbTotDeposit.Font, FontStyle.Italic);
            }
        }

        private void txbInterestPrem_Enter(object sender, EventArgs e)//When txb is "entered" , this empties txb if default text is present, so user may enter their value
        {
            if (txbInsurancePrem.Text == "Insurance Premium")
            {
                txbInsurancePrem.Text = "";

                txbInsurancePrem.Font = new Font(txbInsurancePrem.Font, FontStyle.Regular);
            }
        }

        private void txbInterestPrem_Leave(object sender, EventArgs e)//sets textbox text to a default value if user leaves textbox and has not entered their value
        {
            if (txbInsurancePrem.Text == "")
            {
                txbInsurancePrem.Text = "Insurance Premium";

                txbInsurancePrem.Font = new Font(txbInsurancePrem.Font, FontStyle.Italic);
            }
        }

        private void txbMake_TextChanged(object sender, EventArgs e)
        {
            if (txbMake.Text!= "")//checks if txb input is appropriate and assigns output to check variable
            {
                make = true;
            }
        }

        private void txbModel_TextChanged(object sender, EventArgs e)
        {
            if (txbMake.Text != "")//checks if txb input is appropriate and assigns output to check variable
            {
                model = true;
            }
        }

        private void txbPurchPrice_TextChanged(object sender, EventArgs e)
        {
            purchPrice = Validation.validateCurrency(pnlPurchPrice, txbPurchPrice.Text, backColour);//checks if txb input is appropriate and assigns output to check variable
        }

        private void txbInterestPrem_TextChanged(object sender, EventArgs e)
        {
            interestPrem = Validation.validateCurrency(pnlInterestPrem, txbInsurancePrem.Text, backColour);//checks if txb input is appropriate and assigns output to check variable
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (UserBudget.currentBudget.UserExpenses.containsType(vehicle) == false)//if there does not already exist a vehicle expense
            {
                if (checkNull()) //if all inputs are not null
                {
                    string make = txbMake.Text;
                    string model = txbModel.Text;
                    double purchasePrice = double.Parse(Validation.alterCurrency(txbPurchPrice.Text));
                    double totDeposit = double.Parse(Validation.alterCurrency(txbTotDeposit.Text));
                    double interestRate = double.Parse(numericUpDownInterestRate.Value + "");
                    double insurancePrem = double.Parse(Validation.alterCurrency(txbInsurancePrem.Text));
                    //get inputs for a vehicle expense
                    VehicleExpense newVehicle = new VehicleExpense(make, model, purchasePrice, totDeposit, interestRate, insurancePrem);
                    //make vehicle expense
                    UserBudget.currentBudget.UserExpenses.addExpense(newVehicle);
                    //add vehcle expense to expense list
                    txbOutput.Text = newVehicle.displayExpenses();
                    //set outbut txb text to string display for vehicle expense just made
                    btnDelete.Visible = true;
                    //show delete as there is now an expense to delete
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
            else
            {
                MessageBox.Show("You already have a Vehicle expense. Please delete your current one first and try again",
                    "Vehicle Expense already exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            UserBudget.currentBudget.UserExpenses.deleteExpense(vehicle);//deletes expense of type vehicle from list of expenses
            BudgetForm current = (BudgetForm)BudgetForm.ActiveForm;
            current.setLiveIncome();
            //as an expense was deleted the remaining money has changed thus we call setLiveIncome to update this on the BudgetForm
            txbOutput.Text = "";
            // there is no longer an expense to display so set txb text to nothing
            resetInputs();
            //resetInputs to ensure inputs are appropriate for a user to enter a new generic expense
            btnDelete.Visible = false;// there is no longer an expense of generic to delete so the delete button must be unaccessible
        }
    }
}
