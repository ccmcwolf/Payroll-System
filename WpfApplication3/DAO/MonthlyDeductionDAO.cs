using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace payroll.DAO
{
    class MonthlyDeductionDAO
    {
        public Boolean addMonthlyDeduction(Payroll_Monthly_Deduction_Transaction deduction)
        {
            Boolean status = false;
            try
            {
                using (var db = new PayrollModel())
                {

                    db.Payroll_Monthly_Deduction_Transaction.Add(deduction);
                    db.SaveChanges();
                    status = true;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Payroll_Monthly_Deduction_Transaction add error " + ex.InnerException);
            }
            return status;
        }

        public Boolean updateMonthlyDeduction(Payroll_Monthly_Deduction_Transaction deduction)
        {
            Boolean status = false;
            try
            {
                using (var db = new PayrollModel())
                {
                    Console.WriteLine("payroll monthly deduction updated");
                    db.Payroll_Monthly_Deduction_Transaction.AddOrUpdate(deduction);
                    db.SaveChanges();
                    status = true;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Update payroll Payroll_Monthly_Deduction_Transaction problem " + ex.InnerException);
            }
            return status;
        }

        public Payroll_Monthly_Deduction_Transaction findByMonthlyDeductionId(int deductionId)
        {
            Payroll_Monthly_Deduction_Transaction deduction = null;
            try
            {
                using (var db = new PayrollModel())
                {

                    deduction = db.Payroll_Monthly_Deduction_Transaction.Find(deductionId);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("find monthly Payroll_Monthly_Deduction_Transaction error" + ex.InnerException);
            }
            return deduction;
        }

        public Boolean deleteAllowancebyId(int id)
        {
            Boolean status = false;

            try
            {
                using (var db = new PayrollModel())
                {
                    Payroll_Monthly_Deduction_Transaction deduction = db.Payroll_Monthly_Deduction_Transaction.First(b => b.DeductionTran_ID == id);

                    db.Payroll_Monthly_Deduction_Transaction.Remove(deduction);
                    db.SaveChanges();
                    status = true;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("delete monthly Payroll_Monthly_Deduction_Transaction error " + ex.InnerException);
            }
            return status;
        }

        public List<Payroll_Monthly_Deduction_Transaction> loadallMonthlyDeductions()
        {
            List<Payroll_Monthly_Deduction_Transaction> deductions = null;
            try
            {
                using (var db = new PayrollModel())
                {
                    deductions = db.Set<Payroll_Monthly_Deduction_Transaction>().ToList();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("findall Payroll_Monthly_Deduction_Transaction error " + ex.InnerException);
            }
            return deductions;

        }
        public List<Payroll_Monthly_Deduction_Transaction> loadallMonthlyDeductionsByMonth(int month, int year)
        {
            List<Payroll_Monthly_Deduction_Transaction> deductions = null;
            try
            {
                using (var db = new PayrollModel())
                {
                    deductions = db.Payroll_Monthly_Deduction_Transaction
                       .Where(b => b.Tran_Date.Month == month && b.Tran_Date.Year == year)
                       .ToList();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("findall monthly deduction by month error " + ex.InnerException);
            }
            return deductions;

        }

        public List<Payroll_Monthly_Deduction_Transaction> loadAllMonthlyPaymentDeductionsByMonthByEmployee(int month, int year, int empID)
        {

            List<Payroll_Monthly_Deduction_Transaction> deductions = null;
            try
            {
                using (var db = new PayrollModel())
                {
                    deductions = db.Payroll_Monthly_Deduction_Transaction
                       .Where(b => b.Tran_Date.Month == month && b.Tran_Date.Year == year && b.Employee_ID == empID)
                       .ToList();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("find monthly allowance for emp error " + ex.InnerException);
            }
            return deductions;

        }



    }
}
