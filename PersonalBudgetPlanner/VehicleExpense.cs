using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalBudgetPlanner
{
    class VehicleExpense: Expenses
    {
        //class for Vehicle expense

        //create variables for a Vehicle expense
        string model;
        string make;
        double purchasePrice;
        double totDeposit;
        double interestRate;
        double estInsurancePrem;

        //Constructor for class
        public VehicleExpense(string model, string make, double purchasePrice, double totDeposit, double interestRate, double estInsurancePrem)
        {
            this.model = model;
            this.make = make;
            this.purchasePrice = purchasePrice;
            this.totDeposit = totDeposit;
            this.interestRate = interestRate;
            this.estInsurancePrem = estInsurancePrem;
            TotalExpenses = monRepayment();// set total Expenses of parent to the Vehicle loan, when object is made, as this is the only expense for Vehicle expense
        }

        private double VehicleRep() // calculates vehicle repayment per month
        {
            int yearToRepay = 5; // variable to store years to pay over, as per POE
            int monToRepay = yearToRepay * 12; // changes years to number of months
            //calculates vehicle repayment using simple interest as Home Loan is calculated using simple interest
            double vehicleRepayment = ((purchasePrice - totDeposit) * (1 + (interestRate / 100) * yearToRepay)) / monToRepay;
            
            return Math.Round(vehicleRepayment, 2);// return value rounded to 2 decimal places as every currency value has 2 decimal places
        }
        public double monRepayment() // returns the total monthly repayment with vehicle loan and insurance per month
        {
            return estInsurancePrem + VehicleRep();
        }

        public string displayExpenses() // return a string display of the appropriate total expenses for a Vehicle expense
        {
            return $"Vehicle Expenses: {TotalExpenses}\r\n\t Model: {model}\r\n\t  Make: {make}" ;
        }
        public double TotExpenses() //return total expense for Vehicle expense 
        {
            return TotalExpenses;
        }
    }
}
