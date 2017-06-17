using payroll.Util;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace payroll.DAO
{
    class UserController
    {
        public Boolean addUserDetail(User user)
        {
            Boolean status = false;


            try
            {
                using (var db = new PayrollModel())
                {

                    string passencripted = EncryptionUtil.ToSHA256(user.Password);
                    Console.WriteLine(passencripted);
                    user.Password = passencripted;
                    db.Users.Add(user);
                    db.SaveChanges();
                    status = true;

                }
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var entityValidationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in entityValidationErrors.ValidationErrors)
                    {
                        Console.Write("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
            }
            return status;
        }

        public Boolean checkUserLogin(string username, string password)
        {
            Console.Write("username " + username + " password " + password);

            string encrypted = EncryptionUtil.ToSHA256(password);
            Console.Write("encrypted " + encrypted);

            User userdetail = null;
            Boolean user_status = false;
            try
            {
                using (var db = new PayrollModel())
                {
                    Console.Write("user detail" + db.Users.FirstOrDefault());
                    userdetail = db.Users.Where(u => u.User_Name== username && u.Password== encrypted).FirstOrDefault();
                    Console.Write("user detail " + userdetail);
                    if (userdetail != null)
                    {
                        user_status = true;
                    }
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.Write(ex.StackTrace);
            }

            return user_status;
        }

    }

}

