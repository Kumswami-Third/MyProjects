using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalBudgetPlanner
{
    class Rent_Expense: Expenses
    {
        //class for rent expenses

        //create variables for a rent expense
        private double monRent;

        public Rent_Expense(double monrent)// constructor for class
                             
        {
            monRent = monrent;
            TotalExpenses = monRent;// set total expenses of parent to monthly rental amount,when object is made, as this is the only expense for this class
        }

        public string displayExpenses()//return a string display of the appropriate total expenses for a rent expense
        {
            string output = "";
            output += "Monthly Rental Amount: " + TotalExpenses;
            return output;
        }
        public double TotExpenses()//return total expenses for a rent expense
        {
            return TotalExpenses;
        }

    }
}
