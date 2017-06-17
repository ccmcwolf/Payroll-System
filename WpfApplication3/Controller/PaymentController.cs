

using payroll;
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
        
        public Payment findByPaymentID(int id)
        {
            Payment payment= null;
            try
            {
                using (var db = new PayrollModel())
                {

                    payment = db.Payments.Find(id);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("find Payment Error" + ex.InnerException);
            }
            return payment;
        }

        public List<Payment> findPaymentforEmployee(int employeeid)
        {
            List<Payment> payments = null;
            try
            {
                using (var db = new PayrollModel())
                {

                    payments = db.Payments.Where(payment => payment.employeeid == employeeid ).ToList();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("find Payment Error" + ex.InnerException);
            }
            return payments;
        }



        public List<Payment> loadAllPayments()
        {
            List<Payment> payments= null;

            try
            {
                using (var db = new PayrollModel())
                {

                    payments  = db.Set<Payment>().ToList();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Load all payments error"+ex.InnerException);
            }
            return payments;
        }
        
        
    }
}