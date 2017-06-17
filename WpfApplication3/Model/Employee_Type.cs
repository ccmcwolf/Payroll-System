namespace payroll
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Employee_Type
    {
        [Key]
        public int Employee_Type_ID { get; set; }

        [Column("Employee_Type")]
        [StringLength(120)]
        public string Employee_Type1 { get; set; }

        [StringLength(1)]
        public string Active_Status { get; set; }

        public DateTime? Created_Date { get; set; }

        public DateTime? Updated_Date { get; set; }

        public int? Updated_User_ID { get; set; }

        [StringLength(1)]
        public string Delete_Flag { get; set; }
    }
}
