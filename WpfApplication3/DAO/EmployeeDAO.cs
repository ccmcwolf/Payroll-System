using payroll;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication3.Controller
{
    class EmployeeDAO
    {

        public Boolean addEmployee(Employee employee)
        {
            Boolean status = false;
            try
            {
                using (var db = new PayrollModel())
                {

                    db.Employees.Add(employee);
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

        public Boolean updateEmployee(Employee employee)
        {
            Boolean status = false;
            try
            {
                using (var db = new PayrollModel())
                {
                    Console.WriteLine("Employee detail updated");
                    db.Employees.AddOrUpdate(employee);
                    db.SaveChanges();
                    status = true;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Update employee problem " + ex.InnerException);
            }
            return status;
        }

        public Employee findByEmployeeId(int employeeId)
        {
            Employee employee = null;
            try
            {
                using (var db = new PayrollModel())
                {

                    employee = db.Employees.Find(employeeId);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("find employee" + ex.InnerException);
            }
            return employee;
        }

        public Boolean deleteMemberbyId(int id)
        {
            Boolean status = false;

            try
            {
                using (var db = new PayrollModel())
                {
                    Employee employee = db.Employees.First(b => b.Employee_ID == id);

                    db.Employees.Remove(employee);
                    db.SaveChanges();
                    status = true;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("delete employee " + ex.InnerException);
            }
            return status;
        }

        public List<Employee> loadallEmployees() {
            List<Employee> employees = null; 
            try
            {
                using (var db = new PayrollModel())
                {
                    employees = db.Set<Employee>().ToList();
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("findall employee error " + ex.InnerException);
            }
            return employees;

        }

    }
}
