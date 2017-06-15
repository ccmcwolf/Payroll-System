namespace WpfApplication3
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PayrollModel : DbContext
    {
        public PayrollModel()
            : base("name=PayrollModel")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Department_Master> Department_Master { get; set; }
        public virtual DbSet<Emp_Attendance> Emp_Attendance { get; set; }
        public virtual DbSet<Emp_Extra_Work> Emp_Extra_Work { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Employee_Type> Employee_Type { get; set; }
        public virtual DbSet<EmployeeTest> EmployeeTests { get; set; }
        public virtual DbSet<Payment> Payments { get; set; }
        public virtual DbSet<Payment_Catagory> Payment_Catagory { get; set; }
        public virtual DbSet<Payment_Sub_Catagory> Payment_Sub_Catagory { get; set; }
        public virtual DbSet<Payroll_Allowances_Master> Payroll_Allowances_Master { get; set; }
        public virtual DbSet<Payroll_Deduction_Master> Payroll_Deduction_Master { get; set; }
        public virtual DbSet<Payroll_Designation_Master> Payroll_Designation_Master { get; set; }
        public virtual DbSet<Payroll_Emp_Type_Master> Payroll_Emp_Type_Master { get; set; }
        public virtual DbSet<Payroll_Monthly_Allowances_Transaction> Payroll_Monthly_Allowances_Transaction { get; set; }
        public virtual DbSet<Payroll_Monthly_Deduction_Transaction> Payroll_Monthly_Deduction_Transaction { get; set; }
        public virtual DbSet<Payroll_Monthly_Salary_Process_Detail> Payroll_Monthly_Salary_Process_Detail { get; set; }
        public virtual DbSet<Receipt> Receipts { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Trans_Job_Assignment> Trans_Job_Assignment { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(e => e.Active_Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Customer>()
                .Property(e => e.Delete_Flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Department_Master>()
                .Property(e => e.Department_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Department_Master>()
                .Property(e => e.Active_Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Department_Master>()
                .Property(e => e.Delete_Flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Emp_Attendance>()
                .Property(e => e.Process_Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Emp_Attendance>()
                .Property(e => e.Active_Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Emp_Attendance>()
                .Property(e => e.Delete_Flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Emp_Attendance>()
                .Property(e => e.Month_lock)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Emp_Extra_Work>()
                .Property(e => e.Active_Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Emp_Extra_Work>()
                .Property(e => e.Process_Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Emp_Extra_Work>()
                .Property(e => e.Delete_Flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Emp_Extra_Work>()
                .Property(e => e.Month_lock)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.NIC_Num)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Active_Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Delete_Flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Employee_Type>()
                .Property(e => e.Active_Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Employee_Type>()
                .Property(e => e.Delete_Flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmployeeTest>()
                .Property(e => e.NIC_Num)
                .IsUnicode(false);

            modelBuilder.Entity<Payment>()
                .Property(e => e.Pay_Mode)
                .IsUnicode(false);

            modelBuilder.Entity<Payment>()
                .Property(e => e.Active_Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Payment>()
                .Property(e => e.Delete_Flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Payment_Catagory>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Payment_Catagory>()
                .Property(e => e.Active_Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Payment_Catagory>()
                .Property(e => e.Delete_Flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Payment_Sub_Catagory>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Payment_Sub_Catagory>()
                .Property(e => e.Nature_Code)
                .IsUnicode(false);

            modelBuilder.Entity<Payment_Sub_Catagory>()
                .Property(e => e.Active_Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Payment_Sub_Catagory>()
                .Property(e => e.Delete_Flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Payroll_Allowances_Master>()
                .Property(e => e.Desription)
                .IsUnicode(false);

            modelBuilder.Entity<Payroll_Allowances_Master>()
                .Property(e => e.All_Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Payroll_Allowances_Master>()
                .Property(e => e.Active_Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Payroll_Allowances_Master>()
                .Property(e => e.Delete_Flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Payroll_Deduction_Master>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Payroll_Deduction_Master>()
                .Property(e => e.Dedu_Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Payroll_Deduction_Master>()
                .Property(e => e.Active_Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Payroll_Deduction_Master>()
                .Property(e => e.Delete_Flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Payroll_Designation_Master>()
                .Property(e => e.Designation_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Payroll_Designation_Master>()
                .Property(e => e.Active_Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Payroll_Designation_Master>()
                .Property(e => e.Delete_Flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Payroll_Emp_Type_Master>()
                .Property(e => e.Type_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Payroll_Emp_Type_Master>()
                .Property(e => e.Active_Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Payroll_Emp_Type_Master>()
                .Property(e => e.Delete_Flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Payroll_Monthly_Allowances_Transaction>()
                .Property(e => e.All_Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Payroll_Monthly_Allowances_Transaction>()
                .Property(e => e.Active_Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Payroll_Monthly_Allowances_Transaction>()
                .Property(e => e.Delete_Flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Payroll_Monthly_Allowances_Transaction>()
                .Property(e => e.Process_Flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Payroll_Monthly_Deduction_Transaction>()
                .Property(e => e.Deduc_Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Payroll_Monthly_Deduction_Transaction>()
                .Property(e => e.Active_Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Payroll_Monthly_Deduction_Transaction>()
                .Property(e => e.Process_Flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Payroll_Monthly_Salary_Process_Detail>()
                .Property(e => e.Transaction_Type)
                .IsUnicode(false);

            modelBuilder.Entity<Payroll_Monthly_Salary_Process_Detail>()
                .Property(e => e.Trans_Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Receipt>()
                .Property(e => e.Rec_Pay_Mode)
                .IsUnicode(false);

            modelBuilder.Entity<Receipt>()
                .Property(e => e.Active_Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Receipt>()
                .Property(e => e.Delete_Flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Active_Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Supplier>()
                .Property(e => e.Delete_Flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Trans_Job_Assignment>()
                .Property(e => e.Active_Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Trans_Job_Assignment>()
                .Property(e => e.Delete_Flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Trans_Job_Assignment>()
                .Property(e => e.Month_lock)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Trans_Job_Assignment>()
                .Property(e => e.Payment_Made)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Delete_Flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Active_Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.Vehicle_Display_Name)
                .IsUnicode(false);

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.Active_Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.Delete_Flag)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
