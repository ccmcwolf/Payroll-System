using payroll;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication3.Controller
{
    class EmployeeAttendanceController
    {
        public Boolean addEmployeeAttendance(Emp_Attendance attendance)
        {
            Boolean status = false;
            try
            {
                using (var db = new PayrollModel())
                {

                    db.Emp_Attendance.Add(attendance);
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

        public Boolean updateAttendance(Emp_Attendance attendance)
        {
            Boolean status = false;
            try
            {
                using (var db = new PayrollModel())
                {
                    Console.WriteLine("Employee attendance updated");
                    db.Emp_Attendance.AddOrUpdate(attendance);
                    db.SaveChanges();
                    status = true;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Update employee problem error" + ex.InnerException);
            }
            return status;
        }

        public Emp_Attendance findEmployeeAttendanceById(int employeeId)
        {
            Emp_Attendance attendance = null;
            try
            {
                using (var db = new PayrollModel())
                {

                    attendance = db.Emp_Attendance.Find(employeeId);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("find employee Type error" + ex.InnerException);
            }
            return attendance;
        }

        public Emp_Attendance findEmployeeAttendanceByDate(DateTime date)
        {
            Emp_Attendance attendance = null;
            try
            {
                using (var db = new PayrollModel())
                {

                    attendance = db.Emp_Attendance.Where(employee=>employee.Atten_Date==date).First();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("find employee Type error" + ex.InnerException);
            }
            return attendance;
        }

        public Emp_Attendance findEmployeeAtendanceByEmployeeID(int employeeId)
        {
            Emp_Attendance attendance = null;
            try
            {
                using (var db = new PayrollModel())
                {

                    attendance = db.Emp_Attendance.Where(employee => employee.Employee_ID == employeeId).First();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("find employee Type error" + ex.InnerException);
            }
            return attendance;
        }

        public Boolean deleteAttendance(int id,DateTime date)
        {
            Boolean status = false;

            try
            {
                using (var db = new PayrollModel())
                {
                    Emp_Attendance attendance = db.Emp_Attendance.First(b => b.Employee_ID==id & b.Atten_Date==date);

                    db.Emp_Attendance.Remove(attendance);
                    db.SaveChanges();
                    status = true;

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("attendance deleted error" + ex.InnerException);
            }
            return status;
        }




    }
}
