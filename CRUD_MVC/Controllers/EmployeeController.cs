using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUD_MVC.Models;


namespace CRUD_MVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        [HttpGet]
        public ActionResult EmpOperations()
        { 
            return View();
        }
        [HttpPost]
        public ActionResult EmpOperations(string B1,EmployeeModel E)
        {
            EmpOperations EOP = new EmpOperations();
            if(B1.Equals("INSERT"))
            {
                int i = EOP.AddEmployee(E);
                if (i == 1)
                    ViewBag.Message = "Employee Added Successfully";
                else
                    ViewBag.Message = "Error Occurred";
            }
            else if(B1.Equals("UPDATE"))
            {
                int i = EOP.UpdateEmployee(E);
                if (i == 1)
                    ViewBag.Message = "Employee details Updated Successfully";
                else
                    ViewBag.Message = "Error Occurred";
            }
            else
            {
                int i = EOP.DeleteEmployee(E.Empid);
                if (i == 1)
                    ViewBag.Message = "Employee details Deleted Successfully";
                else
                    ViewBag.Message = "Error Occurred";
            }
            return View();
        }
    }
}