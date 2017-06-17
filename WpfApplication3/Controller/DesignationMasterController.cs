using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace payroll.Controller
{
    class DesignationMasterController
    {
        public Boolean addDesignation(Payroll_Designation_Master designation)
        {
            Boolean status = false;
            try
            {
                using (var db = new PayrollModel())
                {

                    db.Payroll_Designation_Master.Add(designation);
                    db.SaveChanges();
                    status = true;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("designation add error"+ex.InnerException);
            }
            return status;
        }

        public Boolean updateDesignationMaster(Payroll_Designation_Master desingation)
        {
            Boolean status = false;
            try
            {
                using (var db = new PayrollModel())
                {
                    Console.WriteLine("desingation updated");
                    db.Payroll_Designation_Master.AddOrUpdate(desingation);
                    db.SaveChanges();
                    status = true;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Update desingation error" + ex.InnerException);
            }
            return status;
        }

        public Payroll_Designation_Master findByDesingationID(int desinationID)
        {
            Payroll_Designation_Master designation = null;
            try
            {
                using (var db = new PayrollModel())
                {

                    designation = db.Payroll_Designation_Master.Find(desinationID);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("find designation error " + ex.InnerException);
            }
            return designation;
        }

        public Boolean deleteDesignationbyId(int id)
        {
            Boolean status = false;

            try
            {
                using (var db = new PayrollModel())
                {
                    Payroll_Designation_Master designationmaster = db.Payroll_Designation_Master.First(b => b.Designation_ID == id);

                    db.Payroll_Designation_Master.Remove(designationmaster);
                    db.SaveChanges();
                    status = true;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("delete designation " + ex.InnerException);
            }
            return status;
        }

        public List<Payroll_Designation_Master> loadallDesignationMasters()
        {
            List<Payroll_Designation_Master> designations = null;
            try
            {
                using (var db = new PayrollModel())
                {
                    designations = db.Set<Payroll_Designation_Master>().ToList();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("findall designations error " + ex.InnerException);
            }
            return designations;

        }


    }
}
