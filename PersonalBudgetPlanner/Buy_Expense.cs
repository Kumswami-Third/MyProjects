using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace PersonalBudgetPlanner
{
    class Buy_Expense : Expenses
    {
        //class for buying expense

        //create variables for a buying expense
        private double propPrice;
        private double totDeposit;
        private double interestRate;
        private double monRepay; // repayment months is a double to help with eliminating errors with dividing that may occur with an int
        


        public Buy_Expense(double propPrice, double totDeposit, double interestRate, double monRepay)//constructor for class
        {
            this.propPrice = propPrice;
            this.totDeposit = totDeposit;
            this.interestRate = interestRate;
            this.monRepay = monRepay;
            TotalExpenses = monRepayment();// set total Expenses of parent to the Home loan, when object is made, as this is the only expense for buying expense
        }

        public double monRepayment() // calculates the monthly repayment for a HomeLoan
        {
            double numYears = monRepay / 12; // converts the number of months to years
            double HomeLoanRepayment = ((propPrice - totDeposit)*(1+(interestRate/100)* numYears))/monRepay; // calculates HomeLoan using simple
                                                                                                             // interest as per POE Document
            // return value rounded to 2 decimal places as every currency value has 2 decimal places
            return Math.Round(HomeLoanRepayment,2);                                                        
          
        }
        public void homeLoanWarning(double grossMonInc)//return appropriate message based on repayment amount
        {
            double checkVal = (double)1/3; // make fraction value to be used to check if Expenses exceeds a fraction of income
            double totVal = checkVal * grossMonInc;          
            if (TotalExpenses> totVal) // if Home Loan is greater than the fraction of totalIncome
            {

                MessageBox.Show("Please note that your monthly expenses exceed a third of your gross monthly income. Approval of " +
                    "Home Loan is unlikely T " + totVal, "Excessive expenses", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        public string displayExpenses() // return a string display of the appropriate total expenses for a buying expense
        {
            string output = "";
            output += "Monthly Home Loan Expense: " + TotalExpenses;
            return output;

        }
        public double TotExpenses() //return total expense for buying expense 
        {
            return TotalExpenses;
        }

    }
}
