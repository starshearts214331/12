﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace wk12
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          TextBox1.Text = "Hello 1";
          TextBox2.Text = System.DateTime.Now.ToShortTimeString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}