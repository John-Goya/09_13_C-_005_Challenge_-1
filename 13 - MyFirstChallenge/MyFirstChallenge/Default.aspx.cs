﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstChallenge
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string age = ageTextBox.Text;
            string amount = pocketMoneyTextBox.Text;

            string result = "At " + age + " years old, I would have expected you" +
                    " to have more than $" + amount + " in your pocket.";

            resultLabel.Text = result;
        }
    }
}