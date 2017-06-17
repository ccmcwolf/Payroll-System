using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace payroll.DAO
{
    class AllowancesMasterDAO
    {
        public Boolean addAllowanceMaster(Payroll_Allowances_Master allowances)
        {
            Boolean status = false;
            try
            {
                using (var db = new PayrollModel())
                {

                    db.Payroll_Allowances_Master.Add(allowances);
                    db.SaveChanges();
                    status = true;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Allowance add ereor "+ex.InnerException);
            }
            return status;
        }

        public Boolean updateAllowanceMaster(Payroll_Allowances_Master allowance)
        {
            Boolean status = false;
            try
            {
                using (var db = new PayrollModel())
                {
                    Console.WriteLine("Allowance updated");
                    db.Payroll_Allowances_Master.AddOrUpdate(allowance);
                    db.SaveChanges();
                    status = true;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Update allowances problem " + ex.InnerException);
            }
            return status;
        }

        public Payroll_Allowances_Master findByAllowanceId(int allowanceId)
        {
            Payroll_Allowances_Master allowance = null;
            try
            {
                using (var db = new PayrollModel())
                {

                    allowance = db.Payroll_Allowances_Master.Find(allowanceId);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("find allowance error" + ex.InnerException);
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
                    Payroll_Allowances_Master allowance = db.Payroll_Allowances_Master.First(b => b.Allowance_ID == id);

                    db.Payroll_Allowances_Master.Remove(allowance);
                    db.SaveChanges();
                    status = true;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("delete allowances " + ex.InnerException);
            }
            return status;
        }

        public List<Payroll_Allowances_Master> loadallAllowances()
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

    }
}
