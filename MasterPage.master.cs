﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.ServiceModel.Security;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    public string show = "";
    protected void Page_Load(object sender, EventArgs e)
    {


        string fileName = "Database.mdf";
        string sql = "select * from [Table] where username = '" + Session["Username"] + "' and IsAdmin = '" + 0 + "'";

        DataTable table = MyAdoHelper.ExecuteDataTable(fileName, sql);
        int length = table.Rows.Count;

        if (length == 0)
            show = "<a href='ManagerPage.aspx' style='margin: 0 10px;'>Manage</a>";
        else
            show = "";
    }
}
