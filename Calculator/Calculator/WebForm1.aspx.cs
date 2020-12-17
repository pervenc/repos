using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Calculator
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSum_Click(object sender, EventArgs e)
        {   //Convert inserted number from string to float
            float sum = float.Parse(TxtNumber1.Text) + float.Parse(TxtNumber2.Text);
            //Change result box text based on result and convert it to string
            ResultBox.Text = Convert.ToString(sum);

        }

        protected void ButtonMinus_Click(object sender, EventArgs e)
        {   //Convert inserted number from string to float
            float minus = float.Parse(TxtNumber1.Text) - float.Parse(TxtNumber2.Text);
            //Change result box text based on result and convert it to string
            ResultBox.Text = Convert.ToString(minus);
        }

        protected void ButtonMult_Click(object sender, EventArgs e)
        {   //Convert inserted number from string to float
            float mult = float.Parse(TxtNumber1.Text) * float.Parse(TxtNumber2.Text);
            //Change result box text based on result and convert it to string
            ResultBox.Text = Convert.ToString(mult);
        }

        protected void ButtonDivide_Click(object sender, EventArgs e)
        {   //Convert inserted number from string to float
            float divide = float.Parse(TxtNumber1.Text) / float.Parse(TxtNumber2.Text);
            //Change result box text based on result and convert it to string
            ResultBox.Text = Convert.ToString(divide);
        }

        protected void ButtonClear_Click(object sender, EventArgs e)
        {   //Set all input boxes to null upon clicking on clear button
            string _null = "";
            ResultBox.Text = _null;
            TxtNumber1.Text = _null;
            TxtNumber2.Text = _null;

        }

        protected void ResultBox_TextChanged(object sender, EventArgs e)
        {
            //Result text box changed to read only
        }

        protected void TxtNumber1_TextChanged(object sender, EventArgs e)
        {

         
        }

        protected void TxtNumber2_TextChanged(object sender, EventArgs e)
        {

         
        }
    }
}