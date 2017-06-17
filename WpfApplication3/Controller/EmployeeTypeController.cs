using payroll;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication3.Controller
{
    class EmployeeTypeController
    {
        public Boolean addEmployeeType(Employee_Type employeeType)
        {
            Boolean status = false;
            try
            {
                using (var db = new PayrollModel())
                {

                    db.Employee_Type.Add(employeeType);
                    db.SaveChanges();
                    status = true;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
            }
            return status;
        }

        public Boolean updateEmployeeType(Employee_Type employeeType)
        {
            Boolean status = false;
            try
            {
                using (var db = new PayrollModel())
                {
                    Console.WriteLine("Employee detail updated");
                    db.Employee_Type.AddOrUpdate(employeeType);
                    db.SaveChanges();
                    status = true;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Update employeeType problem " + ex.InnerException);
            }
            return status;
        }

        public Employee_Type findEmployeeType(int employeeTypeId)
        {
            Employee_Type employeeType = null;
            try
            {
                using (var db = new PayrollModel())
                {

                    employeeType = db.Employee_Type.Find(employeeTypeId);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("find employee" + ex.InnerException);
            }
            return employeeType;
        }

        public Boolean deleteMemberType(int id)
        {
            Boolean status = false;

            try
            {
                using (var db = new PayrollModel())
                {
                    Employee_Type employee = db.Employee_Type.First(b => b.Employee_Type_ID == id);

                    db.Employee_Type.Remove(employee);
                    db.SaveChanges();
                    status = true;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("delete employeeID " + ex.InnerException);
            }
            return status;
        }
    }
}
