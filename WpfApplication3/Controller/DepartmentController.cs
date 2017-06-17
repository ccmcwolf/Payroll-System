// A Hello World! program in C#.

using payroll;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  WpfApplication3.Controller
{
    class DepartmentController 
    {
        public Boolean AddDepartment(Department_Master department)
        {
            Boolean status = false;
            try
            {
                using (var db = new PayrollModel())
                {

                    db.Department_Master.Add(department);
                    db.SaveChanges();
                    status = true;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("deparment add error"+ex.InnerException);
            }
            return status;
        }
        
        public Boolean updateDepartment(Department_Master department)
        {
            Boolean status = false;
            try
            {
                using (var db = new PayrollModel())
                {
                    Console.WriteLine("Department updated");
                    db.Department_Master.AddOrUpdate(department);
                    db.SaveChanges();
                    status = true;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Update Department problem " + ex.InnerException);
            }
            return status;
        }

        public List<Department_Master> loadallDepartments()
        {
            List<Department_Master> departments= null;
            try
            {
                using (var db = new PayrollModel())
                {
                    departments  = db.Set<Department_Master>().ToList();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("load departments error " + ex.InnerException);
            }
            return departments;

        }


        public Boolean deleteDepartmentbyId(int id)
        {
            Boolean status = false;

            try
            {
                using (var db = new PayrollModel())
                {
                    Department_Master department = db.Department_Master.First(b => b.Department_ID == id);

                    db.Department_Master.Remove(department);
                    db.SaveChanges();
                    status = true;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("delete department error " + ex.InnerException);
            }
            return status;
        }
    }
}