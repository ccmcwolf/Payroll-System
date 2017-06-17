using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace payroll.DAO
{
    class MonthlyAllowanceDAO
    {
        public Boolean addMonthlyAllowance(Payroll_Monthly_Allowances_Transaction allowance)
        {
            Boolean status = false;
            try
            {
                using (var db = new PayrollModel())
                {

                    db.Payroll_Monthly_Allowances_Transaction.Add(allowance);
                    db.SaveChanges();
                    status = true;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Allowance add error " + ex.InnerException);
            }
            return status;
        }

        public Boolean updateMonthlyAllowance(Payroll_Monthly_Allowances_Transaction allowance)
        {
            Boolean status = false;
            try
            {
                using (var db = new PayrollModel())
                {
                    Console.WriteLine("payroll monthly allowances updated");
                    db.Payroll_Monthly_Allowances_Transaction.AddOrUpdate(allowance);
                    db.SaveChanges();
                    status = true;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Update payroll monthly allowance problem " + ex.InnerException);
            }
            return status;
        }

        public Payroll_Monthly_Allowances_Transaction findByMonthlyAllowanceId(int allowanceId)
        {
            Payroll_Monthly_Allowances_Transaction allowance = null;
            try
            {
                using (var db = new PayrollModel())
                {

                    allowance = db.Payroll_Monthly_Allowances_Transaction.Find(allowanceId);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("find monthly allowance error" + ex.InnerException);
            }
            return allowance;
        }

        public Boolean deleteAllowancebyId(int id)
        {
            Boolean status = false;

            try
            {
                using (var db = new PayrollModel())
                {
                    Payroll_Monthly_Allowances_Transaction allowance = db.Payroll_Monthly_Allowances_Transaction.First(b => b.Allowance_ID == id);

                    db.Payroll_Monthly_Allowances_Transaction.Remove(allowance);
                    db.SaveChanges();
                    status = true;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("delete monthly allowance error " + ex.InnerException);
            }
            return status;
        }

        public List<Payroll_Allowances_Master> loadallMonthlyAllowance()
        {
            List<Payroll_Allowances_Master> allowances = null;
            try
            {
                using (var db = new PayrollModel())
                {
                    allowances = db.Set<Payroll_Allowances_Master>().ToList();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("findall allowances error " + ex.InnerException);
            }
            return allowances;

        }
        public List<Payroll_Monthly_Allowances_Transaction> loadallMonthlyAllowanceForMonthly(int month, int year)
        {
            List<Payroll_Monthly_Allowances_Transaction> allowances = null;
            try
            {
                using (var db = new PayrollModel())
                {
                    allowances = db.Payroll_Monthly_Allowances_Transaction
                       .Where(b => b.Tran_Date.Month == month && b.Tran_Date.Year == year)
                       .ToList();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("findall monthly allowance error " + ex.InnerException);
            }
            return allowances;

        }

        public List<Payroll_Monthly_Allowances_Transaction> loadallMonthlyAllowanceForEmployee(int month, int year, int empID)
        {
                        
            List<Payroll_Monthly_Allowances_Transaction> allowances = null;
            try
            {
                using (var db = new PayrollModel())
                {
                    allowances = db.Payroll_Monthly_Allowances_Transaction
                       .Where(b => b.Tran_Date.Month == month && b.Tran_Date.Year == year && b.Employee_ID == empID)
                       .ToList();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("find all monthly allowance error " + ex.InnerException);
            }
            return allowances;

        }

        

                
    }
}
