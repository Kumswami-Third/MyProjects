using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PersonalBudgetPlanner
{
    public partial class IncomeAndMonth : Form
    {
        public IncomeAndMonth()
        {
            InitializeComponent();
            backColour = Color.FromArgb(251, 98, 81);  //set rgb value of backcolour theme for form to backcolour        
        }
        bool allCorrect = true; // bool to check that all inputs are correct. Only one is needed here as there is one txb value to enter
        Color backColour = new Color();//make object for backcolour theme, to change panel colours back to normal colour scheme for form.Used in validation methods

        public void resetInputs()// resets input textboxes text and font, and panels color, all to default values
        {
          txbIncome.Text =  "Income";
          txbIncome.Font = new Font(txbIncome.Font, FontStyle.Italic);
          pnlIncome.BackColor = backColour;
          cmbMonth.SelectedIndex = -1;
          cmbMonth.Text = "Month";
          //https://www.codeproject.com/Questions/1043701/How-to-reset-the-combobox-after-save-the-data
          cmbMonth.Font = new Font(cmbMonth.Font, FontStyle.Italic);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (allCorrect & cmbMonth.SelectedIndex>-1)//all values entered are correct and combobox item has been selected
            {
                double grossMonInc = double.Parse(Validation.alterCurrency(txbIncome.Text));//gets income from txb
                string month = cmbMonth.SelectedItem + "";//gets month from cmb
                UserBudget.currentBudget.GrossMonInc = grossMonInc;//set static classes income to income user has entered
                UserBudget.currentBudget.Month = month;//set static classes month to month selected
                BudgetForm current = (BudgetForm)BudgetForm.ActiveForm;
                resetInputs();//resets input to default values
                current.setLiveIncome(); // set live income as the income was changed 
                current.setMonth();// set month as month was changed
            }
            else
            {
                if (!allCorrect)
                {
                    MessageBox.Show("Incorrect currency  format", "Input incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //Adapted from: https://stackoverflow.com/questions/2109441/how-to-show-error-warning-message-box-in-net-how-to-customize-messagebox
                    //Author: Tides
                    //Date accessed: 29 April 2021
                }
                if (!(cmbMonth.SelectedIndex > -1))
                {
                    MessageBox.Show("You have not selected a Month. Please select a month for your budget", "No Month Selected",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }

        }

        private void txbIncome_TextChanged(object sender, EventArgs e)
        {
            
            allCorrect = Validation.validateCurrency(pnlIncome,txbIncome.Text,backColour);//checks if txb input is appropriate and assigns output to check variable

        }

        private void txbIncome_Enter(object sender, EventArgs e)//When txb is "entered" , this empties txb if default text is present, so user may enter their value
        {
            if (txbIncome.Text == "Income")
            {
                txbIncome.Text = "";

                txbIncome.Font = new Font(txbIncome.Font, FontStyle.Regular); 
            }
        }

        private void txbIncome_Leave(object sender, EventArgs e)//sets textbox text to a default value if user leaves textbox and has not entered their value
        {
            if (txbIncome.Text == "" )
            {
                txbIncome.Text = "Income";

                txbIncome.Font = new Font(txbIncome.Font, FontStyle.Italic);
            }
        }

        private void cmbMonth_Enter(object sender, EventArgs e) //When txb is "entered" , this empties txb if default text is present, so user may enter their value
        {
            cmbMonth.Font = new Font(cmbMonth.Font, FontStyle.Regular);
        }

        private void cmbMonth_Leave(object sender, EventArgs e)//sets textbox text to a default value if user leaves textbox and has not entered their value
        {
            cmbMonth.Font = new Font(cmbMonth.Font, FontStyle.Italic);
        }

        private void cmbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
