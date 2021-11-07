using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PersonalBudgetPlanner
{
    public partial class GenericExpenseForm : Form
    {
        public GenericExpenseForm() //form made to specifically handle a useres generic expenses
        {
            InitializeComponent();
            backColour = Color.FromArgb(253, 66, 125);//set rgb value of backcolour theme for form to backcolour
            if (UserBudget.currentBudget.UserExpenses.containsType(generic))//checks if there already exists a generic expenses
            {
                btnDelete.Visible = true; // sets delete button to visible as there is a generic expense to delete
                txbOutput.Text = UserBudget.currentBudget.UserExpenses.returnExpenseDisplay(generic);//output current generic expense for user to see
            }
        }
        Color backColour = new Color();//make object for backcolour theme, to change panel colours back to normal colour scheme for form.Used in validation methods
        Type generic = typeof(GenericExpenses); //create a type for generic expenses to be used in checking if a generic expense already exists
      
        bool taxDed = false; //boolean to check if tax deduxtions has been entered or not
        bool groc = false;//boolean to check if groceries has been entered or not
        bool waterLights = false;//boolean to check if water and lights has been entered or not
        bool travel = false;//boolean to check if travel has been entered or not
        bool cellTell = false;//boolean to check if cellphone and telephonr has been entered or not
        bool other = false;//boolean to check if other has been entered or not
        //all booleans set to false as they are not entered when form loads, only when user enters, thus we assume them to be not entered(false)
        //until checked


        public bool checkNull() //checks that all values needed have been entered by user
        {
            bool output = true;
            List<bool> checks = new List<bool> { taxDed, groc, waterLights, travel,cellTell,other };//stores bools that check inputs in lists
            foreach (bool check in checks)
            {
                if (check == false) //if a bool in lst is false an input is null so we set output to false and end loop
                {
                    output = false;
                    break;
                }

            }
            return output;
        }
        private void GenericExpenseForm_Load(object sender, EventArgs e)
        {

        }
        
        public void resetInputs()// resets input textboxes text and font, and panels color, all to default values
        {
            txbTaxDed.Text = "Tax Deductions";
            txbTaxDed.Font = new Font(txbTaxDed.Font, FontStyle.Italic);
            txbGroceries.Text = "Groceries";
            txbGroceries.Font = new Font(txbGroceries.Font, FontStyle.Italic);
            txbWaterLights.Text = "Water & Lights";
            txbWaterLights.Font = new Font(txbWaterLights.Font, FontStyle.Italic);
            txbTravel.Text = "Travel(inc. Petrol)";
            txbTravel.Font = new Font(txbTravel.Font, FontStyle.Italic);
            txbCellTell.Text = "Cellphone & Telephone";
            txbCellTell.Font = new Font(txbCellTell.Font, FontStyle.Italic);
            txbOther.Text = "Other";
            txbOther.Font = new Font(txbOther.Font, FontStyle.Italic);
            List<Panel> outputPanels = new List<Panel> { pnlTaxDed,pnlGroc,pnlWaterLights, pnlTravel,pnlCellTell,pnlOther};//stores pnl's in list
            foreach (Panel item in outputPanels)
            {
                item.BackColor = backColour;//changes each pnl backcolout ot theme of frame
            }

        }

        private void txbTaxDed_Enter(object sender, EventArgs e) //When txb is "entered" , this empties txb if default text is present, so user may enter their value
        {
            if (txbTaxDed.Text == "Tax Deductions")
            {
                txbTaxDed.Text = "";
                txbTaxDed.Font = new Font(txbTaxDed.Font, FontStyle.Regular);
            }
        }

        private void txbTaxDed_Leave(object sender, EventArgs e) //sets textbox text to a default value if user leaves textbox and has not entered their value
        {
            if (txbTaxDed.Text == "")
            {
                txbTaxDed.Text = "Tax Deductions";

                txbTaxDed.Font = new Font(txbTaxDed.Font, FontStyle.Italic);
            }
        }

        private void txbGroceries_Enter(object sender, EventArgs e)//When txb is "entered" , this empties txb if default text is present, so user may enter their value
        {
            if (txbGroceries.Text == "Groceries")
            {
                txbGroceries.Text = "";

                txbGroceries.Font = new Font(txbGroceries.Font, FontStyle.Regular);
            }
        }

        private void txbGroceries_Leave(object sender, EventArgs e)//sets textbox text to a default value if user leaves textbox and has not entered their value
        {
            if (txbGroceries.Text == "")
            {
                txbGroceries.Text = "Groceries";

                txbGroceries.Font = new Font(txbGroceries.Font, FontStyle.Italic);
            }
        }

        private void txbWaterLights_Enter(object sender, EventArgs e)//When txb is "entered" , this empties txb if default text is present, so user may enter their value
        {
            if (txbWaterLights.Text == "Water & Lights")
            {
                txbWaterLights.Text = "";

                txbWaterLights.Font = new Font(txbWaterLights.Font, FontStyle.Regular);
            }
        }

        private void txbWaterLights_Leave(object sender, EventArgs e)//sets textbox text to a default value if user leaves textbox and has not entered their value
        {
            if (txbWaterLights.Text == "")
            {
                txbWaterLights.Text = "Water & Lights";

                txbWaterLights.Font = new Font(txbWaterLights.Font, FontStyle.Italic);
            }
        }

        private void txbTravel_Enter(object sender, EventArgs e)//When txb is "entered" , this empties txb if default text is present, so user may enter their value
        {
            if (txbTravel.Text == "Travel(inc. Petrol)")
            {
                txbTravel.Text = "";

                txbTravel.Font = new Font(txbTravel.Font, FontStyle.Regular);
            }
        }

        private void txbCellTell_Enter(object sender, EventArgs e)//When txb is "entered" , this empties txb if default text is present, so user may enter their value
        {
            if (txbCellTell.Text == "Cellphone & Telephone")
            {
                txbCellTell.Text = "";

                txbCellTell.Font = new Font(txbCellTell.Font, FontStyle.Regular);
            }
        }

        private void txbOther_Enter(object sender, EventArgs e)//When txb is "entered" , this empties txb if default text is present, so user may enter their value
        {
            if (txbOther.Text == "Other")
            {
                txbOther.Text = "";

                txbOther.Font = new Font(txbOther.Font, FontStyle.Regular);
            }
        }

        private void txbOther_Leave(object sender, EventArgs e)//sets textbox text to a default value if user leaves textbox and has not entered their value
        {
            if (txbOther.Text == "")
            {
                txbOther.Text = "Other";

                txbOther.Font = new Font(txbOther.Font, FontStyle.Italic);
            }
        }

        private void txbTravel_Leave(object sender, EventArgs e)//sets textbox text to a default value if user leaves textbox and has not entered their value
        {
            if (txbTravel.Text == "")
            {
                txbTravel.Text = "Travel(inc. Petrol)";

                txbTravel.Font = new Font(txbTravel.Font, FontStyle.Italic);
            }
        }

        private void txbCellTell_Leave(object sender, EventArgs e)//sets textbox text to a default value if user leaves textbox and has not entered their value
        {
            if (txbCellTell.Text == "")
            {
                txbCellTell.Text = "Cellphone & Telephone";

                txbCellTell.Font = new Font(txbCellTell.Font, FontStyle.Italic);
            }
        }

        private void txbTaxDed_TextChanged(object sender, EventArgs e)
        {
            taxDed = Validation.validateCurrency(pnlTaxDed, txbTaxDed.Text, backColour);//checks if txb input is appropriate and assigns output to check variable
        }

        private void txbGroceries_TextChanged(object sender, EventArgs e)
        {
            groc = Validation.validateCurrency(pnlGroc, txbGroceries.Text, backColour);//checks if txb input is appropriate and assigns output to check variable
        }

        private void txbWaterLights_TextChanged(object sender, EventArgs e)
        {
            waterLights = Validation.validateCurrency(pnlWaterLights, txbWaterLights.Text, backColour);//checks if txb input is appropriate and assigns output to check variable
        }

        private void txbTravel_TextChanged(object sender, EventArgs e)
        {
            travel = Validation.validateCurrency(pnlTravel, txbTravel.Text, backColour);//checks if txb input is appropriate and assigns output to check variable
        }

        private void txbCellTell_TextChanged(object sender, EventArgs e)
        {
            cellTell= Validation.validateCurrency(pnlCellTell, txbCellTell.Text, backColour);//checks if txb input is appropriate and assigns output to check variable
        }

        private void txbOther_TextChanged(object sender, EventArgs e)
        {
            other = Validation.validateCurrency(pnlOther, txbOther.Text, backColour);//checks if txb input is appropriate and assigns output to check variable
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (UserBudget.currentBudget.UserExpenses.containsType(generic) == false) // uses method to check that generic budget does not exist already
            {
                if (checkNull())//if no entered values are null
                {
                    double taxDed = double.Parse(Validation.alterCurrency(txbTaxDed.Text));
                    double groc = double.Parse(Validation.alterCurrency(txbGroceries.Text));
                    double waterLights = double.Parse(Validation.alterCurrency(txbWaterLights.Text));
                    double travel = double.Parse(Validation.alterCurrency(txbTravel.Text));
                    double celltell = double.Parse(Validation.alterCurrency(txbCellTell.Text));
                    double other = double.Parse(Validation.alterCurrency(txbOther.Text));
                    //get inputs for all variables to make a generic expense object. All inputs that call alterCurrency method from validation
                    // do so to ensure the input is in a correct format
                    GenericExpenses newGeneric = new GenericExpenses(taxDed,groc,waterLights,travel,celltell,other);
                    // make generic expense object                   
                    UserBudget.currentBudget.UserExpenses.addExpense(newGeneric);
                    //adds generic expense object to currentBudgets list of expenses
                    txbOutput.Text = newGeneric.displayExpenses();
                    //set outbut txb text to string display for generic expense just made
                    btnDelete.Visible = true;
                    //show delete as there is now an expense to delete
                    resetInputs();
                    //reset inputs to default values
                    BudgetForm current = (BudgetForm)BudgetForm.ActiveForm; //creates a from for current budget form open
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
                MessageBox.Show("You already have a Generic expense. Please delete your current one first and try again",
                    "Generic Expense already exists", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            UserBudget.currentBudget.UserExpenses.deleteExpense(generic);//deletes expense of type generic from list of expenses
            BudgetForm current = (BudgetForm)BudgetForm.ActiveForm;
            current.setLiveIncome();
            //as an expense was deleted the remaining money has changed thus we call setLiveIncome to update this on the BudgetForm
            txbOutput.Text = ""; // there is no longer an expense to display so set txb text to nothing
            resetInputs(); //resetInputs to ensure inputs are appropriate for a user to enter a new generic expense
            btnDelete.Visible = false;// there is no longer an expense of generic to delete so the delete button must be unaccessible
        }

    }

        
}

