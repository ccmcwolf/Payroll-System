// A Hello World! program in C#.

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
        
        
    }
}