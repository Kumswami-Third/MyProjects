using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace PersonalBudgetPlanner
{
    class Budget
    {
        //class for buying expense

        //create variables for a budget
        private string month;
        private double grossMonInc;
        private ExpenseList userExpenses;

        public string Month { get => month; set => month = value; } //getters and setters for month

        internal ExpenseList UserExpenses { get => userExpenses; set => userExpenses = value; }//getter and setters for expenseList
        public double GrossMonInc { get => grossMonInc; set => grossMonInc = value;  }//getters and setters for gross monthly income
       
        public Budget(string month, double grossMonInc, ExpenseList userExpenses)//constructor for class 
        {
            this.month = month;
            this.grossMonInc = grossMonInc;
            this.userExpenses = userExpenses;
        }


 
        public double remMoney()// returns remaining money
        {
            userExpenses.onExpenseMade(grossMonInc);  //call virtual void here as everytime the remaining money is effected, this method is called 
            return grossMonInc - userExpenses.returnTotexpenses();
        }      
         
     }



}
