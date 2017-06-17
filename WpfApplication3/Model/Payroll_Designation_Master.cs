namespace payroll
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Payroll_Designation_Master
    {
        [Key]
        public int Designation_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Designation_Name { get; set; }

        public int Department_ID { get; set; }

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
