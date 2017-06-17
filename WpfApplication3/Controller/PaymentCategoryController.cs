using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace payroll.Controller
{
    class PaymentCategoryController
    {
        public Boolean addPaymentController(Payment_Catagory paymentcategory)
        {
            Boolean status = false;
            try
            {
                using (var db = new PayrollModel())
                {

                    db.Payment_Catagory.Add(paymentcategory);
                    db.SaveChanges();
                    status = true;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("payemtn category add error "+ex.InnerException);
            }
            return status;
        }

        public Boolean updatePaymentCategory(Payment_Catagory category)
        {
            Boolean status = false;
            try
            {
                using (var db = new PayrollModel())
                {
                    Console.WriteLine("Employee category updated");
                    db.Payment_Catagory.AddOrUpdate(category);
                    db.SaveChanges();
                    status = true;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Update category problem " + ex.InnerException);
            }
            return status;
        }

        public Payment_Catagory findPaymentCategoryByID(int catId)
        {
             Payment_Catagory category = null;
            try
            {
                using (var db = new PayrollModel())
                {

                    category = db.Payment_Catagory.Find(catId);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("find category error" + ex.InnerException);
            }
            return category;
        }

        public Boolean deletecategoryByID(int id)
        {
            Boolean status = false;

            try
            {
                using (var db = new PayrollModel())
                {
                    Payment_Catagory paymmentCat = db.Payment_Catagory.First(b => b.Pay_Cat_ID == id);

                    db.Payment_Catagory.Remove(paymmentCat);
                    db.SaveChanges();
                    status = true;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("delete pay cat error" + ex.InnerException);
            }
            return status;
        }

        public List<Payment_Catagory> loadAllPaymentCategories()
        {
            List<Payment_Catagory> categories= null;
            try
            {
                using (var db = new PayrollModel())
                {
                    categories = db.Set<Payment_Catagory>().ToList();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("load payement categories  error " + ex.InnerException);
            }
            return categories;

        }

    }
}
