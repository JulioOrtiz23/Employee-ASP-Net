using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace EmployeeTest_JulioOrtiz
{
    public class EmployeeData
    {

        public SqlConnection connection;
        public SqlTransaction transaction;
        public string error;

        public EmployeeData()
        {
            this.connection = Connection.getConnection();
        }

        public bool AddEmployee(Employee obj)
        {
            bool add = false;
            SqlCommand sql = new SqlCommand();
            sql.Connection = connection;
            sql.CommandText = "insert into Employee values (@EmpFirstName,@EmpLastName, @EmpPhone, @EmpZip, @HireDate)";
            sql.Parameters.AddWithValue("@EmpFirstName", obj.EmployeeFirstName);
            sql.Parameters.AddWithValue("@EmpLastName", obj.EmployeeLastName);
            sql.Parameters.AddWithValue("@EmpPhone", obj.EmployeePhone);
            sql.Parameters.AddWithValue("@EmpZip", obj.EmployeeZip);
            sql.Parameters.AddWithValue("@HireDate", obj.HireDate);

            try
            {
                sql.ExecuteNonQuery();
                add = true;
            }
            catch (SqlException ex)
            {
                this.error = ex.Message;
            }

            return add;
        }
        public List<Employee> getEmployees()
        {
            List<Employee> EmployeeList = new List<Employee>();
            SqlCommand sql2 = new SqlCommand();
            sql2.Connection = connection;
            sql2.CommandText = "select * from Employee";
            SqlDataReader data = sql2.ExecuteReader();
            while (data.Read())
            {
                Employee emp = new Employee();
                emp.EmployeeID = data.GetInt32(0);
                emp.EmployeeFirstName = data.GetString(1);
                emp.EmployeeLastName = data.GetString(2);
                emp.EmployeePhone = data.GetString(3);
                emp.EmployeeZip = data.GetInt32(4);
                emp.HireDate = data.GetDateTime(5);
                EmployeeList.Add(emp);
            }
            data.Close();
            return EmployeeList;
        }

        public Employee SearchEmployee(int EmployeeID)
        {
            SqlCommand sql3 = new SqlCommand();
            sql3.Connection = connection;
            sql3.CommandText = "select * from Employee where EmployeeID=@EmpID";
            sql3.Parameters.AddWithValue("@EmpID",EmployeeID);
            SqlDataReader search = sql3.ExecuteReader();
            if (search.Read())
            {
                Employee emp = new Employee();
                emp.EmployeeID = search.GetInt32(0);
                emp.EmployeeFirstName = search.GetString(1);
                emp.EmployeeLastName = search.GetString(2);
                emp.EmployeePhone = search.GetString(3);
                emp.EmployeeZip = search.GetInt32(4);
                emp.HireDate = search.GetDateTime(5);
                search.Close();
                return emp;
            }
            else
            {
                search.Close();
                return null;
            }

        }

        public bool UpdateEmployee(Employee obj)
        {
            bool update = false;
            SqlCommand sql = new SqlCommand();
            sql.Connection = connection;
            sql.CommandText = "update Employee set EmployeeFirstName=@EmpFirstName, EmployeeLastName=@EmpLastName, EmployeePhone=@EmpPhone, EmployeeZip=@EmpZip, HireDate=@HireDate where EmployeeID=@EmpID";
            sql.Parameters.AddWithValue("@EmpID", obj.EmployeeID);
            sql.Parameters.AddWithValue("@EmpFirstName", obj.EmployeeFirstName);
            sql.Parameters.AddWithValue("@EmpLastName", obj.EmployeeLastName);
            sql.Parameters.AddWithValue("@EmpPhone", obj.EmployeePhone);
            sql.Parameters.AddWithValue("@EmpZip", obj.EmployeeZip);
            sql.Parameters.AddWithValue("@HireDate", obj.HireDate);

            try
            {
                sql.ExecuteNonQuery();
                update = true;
            }
            catch (SqlException ex)
            {
                this.error = ex.Message;
            }

            return update;
        }
        
        public bool DeleteEmployee(int EmployeeID)
        {
            bool delete = false;
            SqlCommand sql4 = new SqlCommand();
            sql4.Connection = connection;
            sql4.CommandText = "delete from Employee where EmployeeID=@EmpID";
            sql4.Parameters.AddWithValue("@EmpID", EmployeeID);

            try
            {
                sql4.ExecuteNonQuery();
                delete = true;
            }
            catch (SqlException ex)
            {
                this.error = ex.Message;
            }

            return delete;

        }

    }
}