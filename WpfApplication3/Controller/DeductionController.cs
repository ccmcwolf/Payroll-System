using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace payroll.Controller
{
    class DeductionController
    {
        public Boolean addDeductionMaster(Payroll_Deduction_Master deduction)
        {
            Boolean status = false;
            try
            {
                using (var db = new PayrollModel())
                {

                    db.Payroll_Deduction_Master.Add(deduction);
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

        public Boolean updateDeductionMaster(Payroll_Deduction_Master deduction)
        {
            Boolean status = false;
            try
            {
                using (var db = new PayrollModel())
                {
                    Console.WriteLine("Deduction updated");
                    db.Payroll_Deduction_Master.AddOrUpdate(deduction);
                    db.SaveChanges();
                    status = true;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Update deduction master error " + ex.InnerException);
            }
            return status;
        }

        public Payroll_Deduction_Master findByDeductionMasterId(int deductionId)
        {
            Payroll_Deduction_Master deduction = null;
            try
            {
                using (var db = new PayrollModel())
                {

                    deduction = db.Payroll_Deduction_Master.Find(deduction);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("find employee" + ex.InnerException);
            }
            return deduction;
        }

        public Boolean deleteMasterDeductionbyId(int id)
        {
            Boolean status = false;

            try
            {
                using (var db = new PayrollModel())
                {
                    Payroll_Deduction_Master dedctionMaster = db.Payroll_Deduction_Master.First(b => b.Deduction_ID== id);

                    db.Payroll_Deduction_Master.Remove(dedctionMaster);
                    db.SaveChanges();
                    status = true;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("delete deduction master " + ex.InnerException);
            }
            return status;
        }

        public List<Payroll_Deduction_Master> loadallMasterDeductions()
        {
            List<Payroll_Deduction_Master> deductions = null;
            try
            {
                using (var db = new PayrollModel())
                {
                    deductions  = db.Set<Payroll_Deduction_Master>().ToList();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("load all deductions master error " + ex.InnerException);
            }
            return deductions;

        }


    }
}
