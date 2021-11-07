using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalBudgetPlanner
{
    abstract class Expenses //abstract class expenses from which all expense types inherit
    {
        //create variables which every expense will have
        private double totalExpenses;//total expenses to store total expenses of child

        protected double TotalExpenses { get => totalExpenses; set => totalExpenses = value; }
        //gets and sets for total expenses that can only be called in child classes as its a protected method

      
        public int CompareTo(Expenses y)//custom comparison for Expenses
        {
            // A null value means that this object is greater.
            if (this.TotalExpenses< y.TotalExpenses)
                return 1;

            else
                return -1;
            //https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.sort?view=net-5.0
            // Author: Microsoft
            // Date accessed: 27 May 2021
        }

    }
}
