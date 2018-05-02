﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentationApp.ClinicalForms.UserControl
{
    public partial class UserControlKNH_VitalSign : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtWeight.Attributes.Add("onblur", "fnSetBMI('" + txtWeight.ClientID + "','" + txtHeight.ClientID + "','" + txtBMI.ClientID + "')");
        }
    }
}