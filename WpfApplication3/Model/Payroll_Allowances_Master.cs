namespace WpfApplication3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Payroll_Allowances_Master
    {
        [Key]
        public int Allowance_ID { get; set; }

        [Required]
        [StringLength(150)]
        public string Desription { get; set; }

        [Column(TypeName = "money")]
        public decimal All_Amount { get; set; }

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
