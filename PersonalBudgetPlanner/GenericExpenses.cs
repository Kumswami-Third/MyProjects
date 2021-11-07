using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonalBudgetPlanner
{
    class GenericExpenses : Expenses
    {
        //class for generic expenses

        //create variables for genericExpenses
        private double taxDed;
        private double groc;
        private double waterLights;
        private double travel;
        private double cellTell;
        private double other;


        public GenericExpenses(double taxDed, double groc, double waterLights, double travel, double cellTell, double other)//class constructor
        {

            this.taxDed = taxDed;
            this.groc = groc;
            this.waterLights = waterLights;
            this.travel = travel;
            this.cellTell = cellTell;
            this.other = other;
            //set total Expenses of parent to the sum of classes variables, when object is made, as this is the only expense for Generic expenses
            TotalExpenses = taxDed + groc + waterLights + travel + cellTell + other;
        }

        public string displayExpenses() // return a string display of the appropriate  expenses for a buying expense
        {
            string output = "";
            double totExpenses = TotalExpenses;
            output += $"Generic Expenses:{TotalExpenses}";
            //store each variable name with a ": " after followed immediately by the variables value. This is the specific format to help with sorting
            List<string> genericExpenses = new List<String>(new string[] { "Tax Deductions: " + taxDed, "Groceries: "+groc,
                "Water&Lights: "+waterLights,"Travel: "+travel ,"CellTell: "+cellTell ,"Other: "+other });

            //sorts string list based on the number amount after the ": "   
            genericExpenses.Sort(delegate (string x, string y) //custom paramter for .Sort for list                                                          
            {                                                   
                double xVal = double.Parse(x.Substring(x.IndexOf(":")+2)); //create double that is the part of the string x after the ": "
                double yVal = double.Parse(y.Substring(y.IndexOf(":")+2)); //create double that is the part of the string y after the ": "
                // returns 1 if y is greater than x and -1 if it is not or 0 if they are =. This return is used by the .Sort of a list
                return yVal.CompareTo(xVal); 
            });
            //https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.sort?view=net-5.0
            // Author: Microsoft
            // Date accessed: 27 May 2021
            foreach (string item in genericExpenses)
            {
                output += "\r\n\t" + item;
            }
            return output;
        }
        public double TotExpenses() //return total expense for Generic expense 
        {
            return TotalExpenses;
        }
    }
}
