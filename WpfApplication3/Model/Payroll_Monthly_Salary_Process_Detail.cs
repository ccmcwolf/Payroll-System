namespace WpfApplication3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Payroll_Monthly_Salary_Process_Detail
    {
        [Key]
        public int ProcessTran_ID { get; set; }

        public DateTime? Process_Date { get; set; }

        public int Employee_ID { get; set; }

        [Required]
        [StringLength(10)]
        public string Transaction_Type { get; set; }

        public int Deduction_ID { get; set; }

        public int Allowance_ID { get; set; }

        [Column(TypeName = "money")]
        public decimal Trans_Amount { get; set; }

        public DateTime Created_Date { get; set; }

        public int? Processed_User_ID { get; set; }
    }
}
