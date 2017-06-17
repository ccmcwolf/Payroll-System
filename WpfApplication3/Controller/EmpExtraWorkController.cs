using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace payroll.Controller
{
    class EmpExtraWorkController
    {
        public Boolean addExtraWork(Emp_Extra_Work extrawork)
        {
            Boolean status = false;
            try
            {
                using (var db = new PayrollModel())
                {

                    db.Emp_Extra_Work.Add(extrawork);
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

        public Boolean updateEmpExtraWork(Emp_Extra_Work extrawork)
        {
            Boolean status = false;
            try
            {
                using (var db = new PayrollModel())
                {
                    Console.WriteLine("Employee Extrawork updated");
                    db.Emp_Extra_Work.AddOrUpdate(extrawork);
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

        public Emp_Extra_Work findByEmployeeExtraWorkByID(int employeeId)
        {
            Emp_Extra_Work emp_extrawork = null;
            try
            {
                using (var db = new PayrollModel())
                {

                    emp_extrawork = db.Emp_Extra_Work.Find(employeeId);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("find extra work error" + ex.InnerException);
            }
            return emp_extrawork;
        }

        //send month as int from DateTime.Month
        public List<Emp_Extra_Work> getExtraWorkForMonth(int employeeId,int month)
        {
            List<Emp_Extra_Work> emp_extraworks = null;
            
            try
            {
                using (var db = new PayrollModel())
                {
                    
                    emp_extraworks = db.Emp_Extra_Work.Where(extra => extra.Employee_ID ==employeeId && month == extra.Work_Date.Month).ToList();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("find extra work error" + ex.InnerException);
            }
            return emp_extraworks;
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

    }
}
