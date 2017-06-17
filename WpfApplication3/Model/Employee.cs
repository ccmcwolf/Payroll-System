namespace payroll
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Employee")]
    public partial class Employee
    {
        [Key]
        public int Employee_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string First_Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Second_Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Third_Name { get; set; }

        public DateTime? DOB { get; set; }

        public DateTime? Join_Date { get; set; }

        [StringLength(15)]
        public string NIC_Num { get; set; }

        [StringLength(20)]
        public string Contact_Home { get; set; }

        [StringLength(20)]
        public string Contact_Mobile { get; set; }

        [StringLength(20)]
        public string Contact_Other { get; set; }

        [StringLength(200)]
        public string Add_Home_1 { get; set; }

        [StringLength(100)]
        public string Add_Home_2 { get; set; }

        public int? Employee_Type_ID { get; set; }

        public DateTime? Employee_Type_Eff_Date { get; set; }

        public int? Department_ID { get; set; }

        public DateTime? Department_Eff_Date { get; set; }

        public DateTime? Resigned_Date { get; set; }

        [StringLength(1)]
        public string Active_Status { get; set; }

        public double? BasicSalary { get; set; }

        public double? Incentive { get; set; }

        public double? Att_Allowance { get; set; }

        public DateTime? Created_Date { get; set; }

        public DateTime? Updated_Date { get; set; }

        public int? Updated_User_ID { get; set; }

        [StringLength(1)]
        public string Delete_Flag { get; set; }
    }
}
