﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class B : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var s1 = Request.QueryString["s1"].ToString();
        var s2 = Request.QueryString["s2"].ToString();
        label1.Text=s1+","+s2;
  
    }
}