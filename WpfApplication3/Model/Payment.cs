namespace payroll
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Payment")]
    public partial class Payment
    {
        [Key]
        public int Payment_ID { get; set; }

        public DateTime Payment_Date { get; set; }

        [StringLength(250)]
        public string Pay_Description { get; set; }

        [Required]
        [StringLength(12)]
        public string Pay_Mode { get; set; }

        public int Pay_Cat_ID { get; set; }

        public float Pay_Amount { get; set; }

        public int Pay_Authorised_By { get; set; }

        public DateTime? Created_Date { get; set; }

        [StringLength(1)]
        public string Active_Status { get; set; }

        public DateTime? Updated_Date { get; set; }

        public int? Updated_User_ID { get; set; }

        [StringLength(1)]
        public string Delete_Flag { get; set; }

        public int? employeeid { get; set; }

        public DateTime? payementmonth { get; set; }
    }
}
