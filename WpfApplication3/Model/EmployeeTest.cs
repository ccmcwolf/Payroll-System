namespace payroll
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmployeeTest")]
    public partial class EmployeeTest
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
    }
}
