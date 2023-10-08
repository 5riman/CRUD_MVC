using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
namespace CRUD_MVC.Models
{
    public class EmployeeModel
    {
        public int Empid { set; get; }
        public string  Ename { set; get; }
        public string  Designation { set; get; }
        public double  Salary { set; get; }
    }
    public class EmpOperations
    {
        SqlConnection Con = new SqlConnection("Server = 40.76.121.111; user id = sa; password=NetScore@Integrations; Database=DotNetTraining");
        SqlCommand Cmd;
        public int AddEmployee(EmployeeModel Emp)
        {
            string Query = "Insert into Empdetails values(@P1,@P2,@P3,@P4)";
            Cmd = new SqlCommand(Query, Con);
            Cmd.Parameters.AddWithValue("@P1", Emp.Empid);
            Cmd.Parameters.AddWithValue("@P2", Emp.Ename);
            Cmd.Parameters.AddWithValue("@P3", Emp.Designation);
            Cmd.Parameters.AddWithValue("@P4", Emp.Salary);
            Con.Open();
            int i = Cmd.ExecuteNonQuery();
            Con.Close();
            return i;
        }
        public int UpdateEmployee(EmployeeModel Emp)
        {
            string Query = "Update Empdetails set Ename=@P1,Designation=@P2,Salary=@P3 where Empid=@P4";
            Cmd = new SqlCommand(Query, Con);
            Cmd.Parameters.AddWithValue("@P4", Emp.Empid);
            Cmd.Parameters.AddWithValue("@P1", Emp.Ename);
            Cmd.Parameters.AddWithValue("@P2", Emp.Designation);
            Cmd.Parameters.AddWithValue("@P3", Emp.Salary);
            Con.Open();
            int i = Cmd.ExecuteNonQuery();
            Con.Close();
            return i;
        }
        public int DeleteEmployee(int Id)
        {
            string Query = "Delete from Empdetails where Empid=@P1";
            Cmd = new SqlCommand(Query, Con);
            Cmd.Parameters.AddWithValue("@P1", Id);
            Con.Open();
            int i = Cmd.ExecuteNonQuery();
            Con.Close();
            return i;
        }
    }


}