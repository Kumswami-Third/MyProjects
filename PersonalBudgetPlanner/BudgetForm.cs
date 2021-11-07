using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalBudgetPlanner
{
    public partial class BudgetForm : Form
    {
        public BudgetForm()
        {
            InitializeComponent();
            lblTotIncLeftLive.Text = "";//set text for live income to nothing when form loads
            lblCurrentMonth.Text = "";//set text for current month to nothing when form loads
            ExpenseList newList = new ExpenseList();// create an empty list
            UserBudget.currentBudget = new Budget("",0, newList);// set currentBudget to instance of Budget object to avoid 
            // NullReferenceException for the Budget object itself and for ExpenseList of Budget
            openChildForm(new IncomeAndMonth());//opens income and month form in label
        }
        //GUI References https://www.youtube.com/watch?v=JP5rgXO_5Sk
        // Author RJ Code Advance EN
        //Date Accessed: 27 May
        public bool checkUserBudgetNull() //checks if there is no current budget made by user yet
        {
            bool output = false;
            if (UserBudget.currentBudget.Month == "")// if month has no characters then user has not made an income and month yet
            {
                output = true;
            }
            return output;
        }

        public void setLiveIncome()// sets value to total income left live txb 
        {
            double remMoney = UserBudget.currentBudget.remMoney();// store remaining money of current user budget to a variable
            lblTotIncLeftLive.Text = remMoney + ""; // set this remaining money to text of roral income left txb
            if (remMoney<0)//if remaining money is less than 0 make txb text colour red
            {
                lblTotIncLeftLive.ForeColor = Color.Red;
            } else
            {
                if (remMoney==0)//make txb text colour orange if remaining money is 0
                {
                    lblTotIncLeftLive.ForeColor = Color.Orange;
                }
            }
          
        }                                                                          

        public void setMonth()//sets txbMonth text to users current Budget month
        {
            lblCurrentMonth.Text = UserBudget.currentBudget.Month ;
        }
 
        private void customizeDesign()
        {


        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnGeneric_Click(object sender, EventArgs e)
        {
            if (checkUserBudgetNull() == false)//opens generic expense form or displays error if user hasnt entered income and month yet
            {
                openChildForm(new GenericExpenseForm());
            }
            else
            {
                MessageBox.Show("You have not selected a Month and income. Please do so before making an expense", "No Income and Month made", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
           
        }
        private Form activeForm = null; // create form 
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) // if the form is null
                activeForm.Close(); //close the form
            activeForm = childForm; //set the form to the gicen child form
            //perform styling edits to the childform
            childForm.TopLevel = false; 
            childForm.FormBorderStyle = FormBorderStyle.None; 
            childForm.Dock = DockStyle.Fill; 
            pnlChildForm.Controls.Add(childForm);// open child form in panel
            pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show(); 
            //GUI References https://www.youtube.com/watch?v=JP5rgXO_5Sk

        }

        private void pnlChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProperty_Click(object sender, EventArgs e)//opens Property(Buy or rent) expense form or displays error if user hasnt entered income and month yet
        {
            if (checkUserBudgetNull() == false)
            {
                openChildForm(new PropertyExpense());
            }
            else
            {
                MessageBox.Show("You have not selected a Month and income. Please do so before making an expense", "No Income and Month made", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnVehicle_Click(object sender, EventArgs e)//opens Vehicle expense form or displays error if user hasnt entered income and month yet
        {
            if (checkUserBudgetNull() == false)
            {
                openChildForm(new VehicleExpenseForm());
            }
            else
            {
                MessageBox.Show("You have not selected a Month and income. Please do so before making an expense", "No Income and Month made", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnReport_Click(object sender, EventArgs e)//opens Report form or displays error if user hasnt entered income and month yet
        {
            if (checkUserBudgetNull() == false)
            {
                openChildForm(new BudgetReport());
            }
            else
            {
                MessageBox.Show("You have not selected a Month and income. Please do so before making an expense", "No Income and Month made", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void pnlTotal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnIncAndMon_Click(object sender, EventArgs e)//opens income and month form
        {
            openChildForm(new IncomeAndMonth());
        }

        private void lblHeading_Click(object sender, EventArgs e)
        {

        }

        private void lblTotIncLeft_Click(object sender, EventArgs e)
        {

        }
    }
}
