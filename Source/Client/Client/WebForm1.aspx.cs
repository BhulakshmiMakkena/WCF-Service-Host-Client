﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Client
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGetEmployee_Click(object sender, EventArgs e)
        {
            EmployeeService.EmployeeServiceClient client = new
                EmployeeService.EmployeeServiceClient();

            EmployeeService.Employee employee =
                client.GetEmployee(Convert.ToInt32(txtID.Text));

            txtName.Text = employee.Name;
            

            lblMessage.Text = "Employee retrieved";
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            EmployeeService.Employee employee = new EmployeeService.Employee();
            employee.Id = Convert.ToInt32(txtID.Text);
            employee.Name = txtName.Text;
            EmployeeService.EmployeeServiceClient client = new
       EmployeeService.EmployeeServiceClient();
            client.SaveEmployee(employee);

            lblMessage.Text = "Employee saved";

        } 
    }
}