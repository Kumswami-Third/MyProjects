using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PersonalBudgetPlanner
{
    class Validation
    {
        public static bool validateCurrency(Panel output, string input,Color pnlNormalColour)//checks that input from label is a currency in real time
        {
            bool value = false;
            double temp;
            input.Replace(" ",""); //eliminates spaces so we  can parse to double
            string edited = input.Replace(".", ",");//replaces . with , so we can parse to double
            ToolTip tool1 = new ToolTip();
           
            if (edited!="")
            {
                if (Double.TryParse(edited, out temp)) //checks input is double
                {
                    if (temp>=0) // checks that value is not negative as you do not get a negative currency
                    {
                        if (edited.Contains(","))// displays correct if no decimal. Runs if where theres a decimal point
                        {
                            if ((edited.Substring(edited.IndexOf(",")).Length <= 3) && !(edited.IndexOf(",") == edited.Length))
                            //makes sure decimal place is either 1,2 or none
                            {
                               
                                output.BackColor = pnlNormalColour;//changes colour to normal to indicate to user input is correct                               
                                //Line 25 Adapted from: https://stackoverflow.com/questions/15906090/change-color-of-label-in-c-sharp/15906135
                                //Author: musefan
                                //Date accessed: 15 March 2021
                                value = true;
                            }
                            else
                            {
                                output.BackColor = System.Drawing.Color.Red;
                                tool1.SetToolTip(output, "");//deletes all tool tips for panel                                
                                tool1.SetToolTip(output, "Max 2 decimal Places!");
                                //https://docs.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-set-tooltips-for-controls-on-a-windows-form-at-design-time?view=netframeworkdesktop-4.8
                                // Author: Microsoft
                                //Date accessed 28 May 2021
                            }
                        }
                        else
                        {
                            
                            output.BackColor = pnlNormalColour; //changes colour to normal to indicate to user input is correct
                            value = true;
                        }
                    }
                    else
                    {
                        output.BackColor = System.Drawing.Color.Red;
                        tool1.SetToolTip(output, "");//deletes all tool tips for panel
                        tool1.SetToolTip(output, "Value must be greater than or equal to 0");//sets tool tip to appropriate message
                    }
                }
                else
                {
                    output.BackColor = System.Drawing.Color.Red;
                    tool1.SetToolTip(output, "");//deletes all tool tips for panel
                    tool1.SetToolTip(output, "Value is not a valid number");//sets tool tip to appropriate message

                }
            }
            else
            {
                output.BackColor = System.Drawing.Color.Red;
                tool1.SetToolTip(output, "");//deletes all tool tips for panel
                tool1.SetToolTip(output, "Please enter a value!");//sets tool tip to appropriate message
            }
           
            
            return value;

        }

        public static string alterCurrency(string input)//Alters input from label so its format can be parsed to a string without error
        {
            input.Replace(".", ",");
            input.Replace(" ", "") ;
            return input;
        }   
      

    }
}
