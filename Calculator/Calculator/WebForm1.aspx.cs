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
        {
            int sum = Int32.Parse(TxtNumber1.Text) + Int32.Parse(TxtNumber2.Text);
            ResultBox.Text = Convert.ToString(sum);

        }

        protected void ButtonMinus_Click(object sender, EventArgs e)
        {
            int minus = Int32.Parse(TxtNumber1.Text) - Int32.Parse(TxtNumber2.Text);
            ResultBox.Text = Convert.ToString(minus);
        }

        protected void ButtonMult_Click(object sender, EventArgs e)
        {
            int mult = Int32.Parse(TxtNumber1.Text) * Int32.Parse(TxtNumber2.Text);
            ResultBox.Text = Convert.ToString(mult);
        }

        protected void ButtonDivide_Click(object sender, EventArgs e)
        {
            int divide = Int32.Parse(TxtNumber1.Text) / Int32.Parse(TxtNumber2.Text);
            ResultBox.Text = Convert.ToString(divide);
        }

        protected void ButtonClear_Click(object sender, EventArgs e)
        {
            string _null = "";
            ResultBox.Text = _null;
            TxtNumber1.Text = _null;
            TxtNumber2.Text = _null;

        }
    }
}