using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeTest_JulioOrtiz
{
    public partial class EmployeeList : System.Web.UI.Page
    {
        EmployeeData objEmployeeData = new EmployeeData();

        protected void Page_Load(object sender, EventArgs e)
        {
            //Load all the Employees into the GridEmployees

            List<Employee> EmployeeList = objEmployeeData.getEmployees();

            if (EmployeeList.Count == 0)
            {
                lblMessage.Text = "There are not employees to show";
            }
            else
            {
                GridEmployees.DataSource = EmployeeList;
                GridEmployees.DataBind();
            }


        }

        protected void btnCreateEmp_Click(object sender, EventArgs e)
        {
            if (txtEmpID.Text != "" && txtEmplFirstName.Text != "" && txtEmplLastName.Text != "" && txtEmplPhone.Text != "" && txtEmpZip.Text != "" && txtHireDate.Text != "")
            {
                Employee emp = new Employee();
                //Assign the value from the textbox to the variable
                emp.EmployeeFirstName = txtEmplFirstName.Text;
                emp.EmployeeLastName = txtEmplLastName.Text;
                emp.EmployeePhone = txtEmplPhone.Text;
                emp.EmployeeZip = int.Parse(txtEmpZip.Text);
                emp.HireDate = DateTime.Parse(txtHireDate.Text);

                //Adding the Employee
                bool add = objEmployeeData.AddEmployee(emp);

                //Evaluating if the process was successful or not
                if (add)
                {
                    lblMessage.Text = "The employee was added";
                    Clean();
                }
                else
                {
                    lblMessage.Text = objEmployeeData.error;
                }
            }
            else
            {
                lblMessage.Text = "Please fill all the text areas";
            }
        }

        protected void Clean()
        {
            txtEmplFirstName.Text = "";
            txtEmplLastName.Text = "";
            txtEmplPhone.Text = "";
            txtEmpZip.Text = "";
            txtHireDate.Text = "";
        }

        protected void btnGet_Click(object sender, EventArgs e)
        {
            if (txtEmpID.Text != "")
            {
                int ID = int.Parse(txtEmpID.Text);
                Employee emp = objEmployeeData.SearchEmployee(ID);
                if (emp != null)
                {
                    txtEmplFirstName.Text = emp.EmployeeFirstName;
                    txtEmplLastName.Text = emp.EmployeeLastName;
                    txtEmplPhone.Text = emp.EmployeePhone;
                    txtEmpZip.Text = Convert.ToString(emp.EmployeeZip);
                    txtHireDate.Text = Convert.ToString(emp.HireDate);
                }
                else
                {
                    lblMessage.Text = "This employee doesn't exist";
                }
            }
            else
            {
                lblMessage.Text = "Please fill the EmployeeID text area";
            }
        }

        protected void btnUpdateEmp_Click(object sender, EventArgs e)
        {
            if (txtEmpID.Text != "" && txtEmplFirstName.Text != "" && txtEmplLastName.Text != "" && txtEmplPhone.Text != "" && txtEmpZip.Text != "" && txtHireDate.Text != "")
            {
                Employee emp = new Employee();
                //Assign the value from the textbox to the variable
                emp.EmployeeID = int.Parse(txtEmpID.Text);
                emp.EmployeeFirstName = txtEmplFirstName.Text;
                emp.EmployeeLastName = txtEmplLastName.Text;
                emp.EmployeePhone = txtEmplPhone.Text;
                emp.EmployeeZip = int.Parse(txtEmpZip.Text);
                emp.HireDate = DateTime.Parse(txtHireDate.Text);

                //Updating the Employee
                bool update = objEmployeeData.UpdateEmployee(emp);

                //Evaluating if the process was successful or not
                if (update)
                {
                    lblMessage.Text = "The employee was updated";
                    Clean();
                }
                else
                {
                    lblMessage.Text = objEmployeeData.error;
                }
            }
            else
            {
                lblMessage.Text = "Please fill all the text areas";
            }
        }

        protected void btnDeleteEmp_Click(object sender, EventArgs e)
        {
            if (txtEmpID.Text != "")
            {
                int ID = int.Parse(txtEmpID.Text);
                Employee emp = new Employee();
                //Assign the value from the textbox to the variable
                emp.EmployeeID = int.Parse(txtEmpID.Text);

                //Deleting the Employee
                bool delete = objEmployeeData.DeleteEmployee(ID);

                //Evaluating if the process was successful or not
                if (delete)
                {
                    lblMessage.Text = "The employee was deleted";
                    Clean();
                }
                else
                {
                    lblMessage.Text = objEmployeeData.error;
                }
            }
            else
            {
                lblMessage.Text = "Please fill all the text areas";
            }
        }
    }
}