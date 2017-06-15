namespace WpfApplication3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Payroll_Emp_Type_Master
    {
        [Key]
        public int Employee_Type_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Type_Name { get; set; }

        [Required]
        [StringLength(1)]
        public string Active_Status { get; set; }

        public DateTime Created_Date { get; set; }

        public DateTime? Updated_Date { get; set; }

        public int? Updated_User_ID { get; set; }

        [Required]
        [StringLength(1)]
        public string Delete_Flag { get; set; }
    }
}
