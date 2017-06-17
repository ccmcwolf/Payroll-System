// A Hello World! program in C#.

using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  WpfApplication3.Controller
{
    class PaymentController 
    {
        public Boolean AddPayment(Payment payment)
        {
            Boolean status = false;
            try
            {
                using (var db = new PayrollModel())
                {

                    db.Payments.Add(payment);
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
        
        public Boolean updatePayment(Payment payment)
        {
            Boolean status = false;
            try
            {
                using (var db = new PayrollModel())
                {
                    Console.WriteLine("Department updated");
                    db.Payments.AddOrUpdate(payment);
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
        
        public Department_Master findByDepartment_Master(int departmentID)
        {
            Department_Master department = null;
            try
            {
                using (var db = new PayrollModel())
                {

                    department = db.Department_Master.Find(departmentID);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("find Department Error" + ex.InnerException);
            }
            return employee;
        }
        
         public List<Department_Master> loadAllDepartments()
        {
            List<Department_Master> departments = null;

            try
            {
                using (var db = new PayrollModel())
                {

                    departments = db.Set<Department_Master>().ToList();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Load all departments error"+ex.InnerException);
            }
            return employees;
        }
        
        
    }
}