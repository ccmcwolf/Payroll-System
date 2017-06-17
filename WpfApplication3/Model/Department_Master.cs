namespace payroll
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Department_Master
    {
        [Key]
        public int Department_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Department_Name { get; set; }

        public int Head_ID { get; set; }

        [Required]
        [StringLength(1)]
        public string Active_Status { get; set; }

        public DateTime Created_Date { get; set; }

        public DateTime? Updated_Date { get; set; }

        public int? Updated_User_ID { get; set; }

        [StringLength(1)]
        public string Delete_Flag { get; set; }
    }
}
