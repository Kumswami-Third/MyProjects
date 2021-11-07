using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PersonalBudgetPlanner
{
    class ExpenseList
    {
        //class for list of expense

        //create list variable for expenses
        private List<Expenses> expenseList = new List<Expenses>();

        public ExpenseList() // constructor for list
        {
            ExpenseListMade += TotExpensesHighMessage; 
            //ExpenseList is made with no values in List and will then be added to as different expenses are made, thus here a constructor
            //is made specifically to add the warning message to the event of delegate, when a list is made 
        }
        public int size() // returns the size of the list i.e how many elements are in the list
        {
          return expenseList.Count; //calls count method to return number of elements in list
        }
        private delegate void warningMessages(double grossMonInc); // delegate made for expenses exceed 75% of income warning
        private event warningMessages ExpenseListMade; //event made for warningMessages delegate



        public Expenses returnSingleExpense(int index) // returns an Expense at a given index of the list
        {
            return expenseList[index]; 
        }
        public string returnExpense(int index) // returns string display for a given index of the list
        {
            string output = ""; //set default output
            Expenses temp = expenseList[index];// store expense at given index into temp        
                switch (temp) // switch to check what child type the expense at given index is 
                {
                    //if its a generic expense, add that display to the output string
                    case GenericExpenses g:
                        output += (g.displayExpenses());                         
                        break;

                    //if its a buy expense, add that display to the output string
                    case Buy_Expense b:                    
                        output += (b.displayExpenses());
                        break;

                    //if its a Rent expense, add that display to the output string
                    case Rent_Expense r:                  
                        output += (r.displayExpenses());
                        break;

                    //if its a Vehicle expense, add that display to the output string
                    case VehicleExpense v:          
                        output += (v.displayExpenses());
                        break;

                    //Adapted from: https://stackoverflow.com/questions/4774820/how-to-find-the-child-class-name-from-base-class
                    // Author: tvanfosson
                    // Date accessed: 3 April 2021
                    // Adapted from: https://stackoverflow.com/questions/7252186/switch-case-on-type-c-sharp
                    // Author: steve
                    // Date accessed: 4 May 2021
                    default:
                        break;              
            }
            return output;
        }

        public void addExpense(Expenses newExpense)//adds an expense to list of expenses
        {
            expenseList.Add(newExpense);
            Type currentType = newExpense.GetType();
        }
        public string returnExpenseDisplay(Type childType) // returns string display for a given type of expense in the list.Since the program 
        {                                                  //only allows for one type of each expense to be stored at a time, no errors will occur
            string output = "";
            //loop through all expenses to find expense of given type
            for (int i = 0; i < expenseList.Count; i++)//for loop to loop through list as we need the i index
            {
                Expenses temp = expenseList[i];//set expense at i to a temp expense
                Type currentType = temp.GetType();// gets type of expense at i
                if (currentType == childType) // if current type is the same as the child type call switch to get string display for expense at i
                {
                    switch (temp)
                    {

                        case GenericExpenses g:
                            //add generic to output
                            output += g.displayExpenses();

                            break;

                        case Buy_Expense b:
                            //add buy to output
                            output += b.displayExpenses();

                            break;

                        case Rent_Expense r:
                            //add rent to output
                            output += r.displayExpenses();
                            break;

                        case VehicleExpense v:
                            //add vehicle to output
                            output += v.displayExpenses();
                            break;

                        default:
                            break;
                    }
                }
               
            }
            return output;

        }
        public void deleteExpense(Type childType) // deletes an expense from the list based on a given type
        {
            for (int i = 0; i < expenseList.Count; i++) //for loop to run through expenses in list as we need i
            {
                Expenses temp = expenseList[i];//pass expense at i to a temp expense
                switch (temp) // checks type of expense at index i
                {

                    case GenericExpenses g:
                        if (g.GetType() == childType)// if given type is the type of the expense at i 
                        {
                            expenseList.RemoveAt(i);// deletes expense at i
                            break;
                        }

                        break;

                    case Buy_Expense b:
                        if (b.GetType() == childType)// if given type is the type of the expense at i 
                        {
                            expenseList.RemoveAt(i);// deletes expense at i
                            break;
                        }

                        break;

                    case Rent_Expense r:
                        if (r.GetType() == childType)// if given type is the type of the expense at i 
                        {
                            expenseList.RemoveAt(i);// deletes expense at i
                            break;
                        }
                        break;

                    case VehicleExpense v:
                        if (v.GetType() == childType)// if given type is the type of the expense at i 
                        {
                            expenseList.RemoveAt(i);// deletes expense at i
                            break;
                        }
                        break;

                    default:
                        break;
                }
            }
        }


        public bool containsType(Type childType)//checks if an expense of given type exists in list
        {
            bool output = false;//default return bool 
            foreach (Expenses temp in expenseList) //run through each expense in list
            {
                switch (temp) //gets type of expense for each element in list
                {

                    case GenericExpenses g:
                        if (g.GetType() == childType) //if given type is the same as type of one of the elements in the list
                        {
                            output = true;//output is true as the given type exists in list
                            break;
                        }
                        break;

                    case Buy_Expense b:
                        if (b.GetType() == childType)
                        {
                            output = true;
                            break;
                        }
                        break;

                    case Rent_Expense r:
                        if (r.GetType() == childType)
                        {
                            output = true;
                            break;
                        }
                        break;

                    case VehicleExpense v:
                        if (v.GetType() == childType)
                        {
                            output = true;
                            break;
                        }
                        break;

                    default:
                        break;

                }

               
            }
            return output;
        }
        public virtual void onExpenseMade(double grossMonInc) //virtual void for delegate event
        {
            if (ExpenseListMade != null)
            {
                ExpenseListMade(grossMonInc);
            }
        }

        private void TotExpensesHighMessage(double grossMonInc) //checks if the total expenses exceed 75% of the gross monthly income
        {
            if (returnTotexpenses() > 0.75 * grossMonInc)
            {
                MessageBox.Show("Please note that your total expenses Exceed 75% of your gross Monthly Income" ,
                    "Excessive expenses", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        private int sortComparison(Expenses x, Expenses y) // custom comparison for sort of expenseList
        {
            // method made for using a Comparison<T> generic delegate representing this method, in a .sort of list of expenses
            if (x == null)
            {
                if (y == null)
                {
                    // If x is null and y is null, they're
                    // equal.
                    return 0;
                }
                else
                {
                    // If x is null and y is not null, y
                    // is greater.
                    return -1;
                }
            }
            else
            {
                // If x is not null...
                //
                if (y == null)
                // ...and y is null, x is greater.
                {
                    return 1;
                }
                else
                {
                    // ...and y is not null, compare the
                    // totalExpenses of x and y.
                    //
                    int retval = x.CompareTo(y);

                    if (retval != 0)
                    {
                        // If the totalExpenses are not of equal value,
                        // the greater value is returned 
                        //
                        return retval;
                    }
                    else
                    {
                        // If the totalExpenses are of equal value,
                        // 
                        return 0;
                    }
                }
            }
            //Adapted from: https://docs.microsoft.com/en-us/dotnet/api/system.comparison-1?view=net-5.0
            // Author: Microsoft
            // Date accessed: 27 May 2021

        }
        public double returnTotexpenses() // adds all expenses in list
        {
            double output = 0;//default double to return
           
            foreach (Expenses temp in expenseList)//run through list
            {
              
                switch (temp) //cast each Expense to its child class then calls child classes totalExpenses method and adds to output
                {

                    case GenericExpenses g:
                        output += g.TotExpenses() ;

                        break;

                    case Buy_Expense b:
                        //add buy to string
                        output += b.TotExpenses();
                       
                        break;

                    case Rent_Expense r:
                        //add rent to output
                        output += r.TotExpenses();
                        break;

                    case VehicleExpense v:
                        //add vehicle to output
                        output += v.TotExpenses();
                        break;
                    //Adapted from: https://stackoverflow.com/questions/4774820/how-to-find-the-child-class-name-from-base-class
                    // Author: tvanfosson
                    // Date accessed: 3 April 2021
                    // Adapted from: https://stackoverflow.com/questions/7252186/switch-case-on-type-c-sharp
                    // Author: steve
                    // Date accessed: 4 May 2021
                    default:
                        break;

                }
               
            }
            return output;
        }

        public void sortExpenses()
        {
            expenseList.Sort(sortComparison);//sorts list
        }
     


     
    }
}
