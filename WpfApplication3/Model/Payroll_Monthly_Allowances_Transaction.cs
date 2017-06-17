namespace payroll
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Payroll_Monthly_Allowances_Transaction
    {
        [Key]
        public int AllowanceTran_ID { get; set; }

        public int Allowance_ID { get; set; }

        public int Employee_ID { get; set; }

        public DateTime Tran_Date { get; set; }

        [Column(TypeName = "money")]
        public decimal All_Amount { get; set; }

        [Required]
        [StringLength(1)]
        public string Active_Status { get; set; }

        public DateTime Created_Date { get; set; }

        public int? Processed_User_ID { get; set; }

        [Required]
        [StringLength(1)]
        public string Delete_Flag { get; set; }

        [Required]
        [StringLength(1)]
        public string Process_Flag { get; set; }
    }
}
