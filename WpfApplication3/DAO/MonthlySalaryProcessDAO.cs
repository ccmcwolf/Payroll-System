using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace payroll.DAO
{
    class MonthlySalaryProcessDAO
    {

        public Boolean saveMonthlySalaryProcess(Payroll_Monthly_Salary_Process_Detail salprocess)
        {
            Boolean status = false;


            try
            {
                using (var db = new PayrollModel())
                {

                    db.Payroll_Monthly_Salary_Process_Detail.Add(salprocess);
                    db.SaveChanges();
                    status = true;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Salary process save error "+ex.InnerException);
            }
            return status;
        }
    }
}
