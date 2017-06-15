namespace WpfApplication3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Receipt")]
    public partial class Receipt
    {
        [Key]
        public int Receipt_ID { get; set; }

        public DateTime Receipt_Date { get; set; }

        [StringLength(250)]
        public string Rec_Description { get; set; }

        [Required]
        [StringLength(12)]
        public string Rec_Pay_Mode { get; set; }

        public float Rec_Amount { get; set; }

        public DateTime? Created_Date { get; set; }

        [StringLength(1)]
        public string Active_Status { get; set; }

        public DateTime? Updated_Date { get; set; }

        public int? Updated_User_ID { get; set; }

        [StringLength(1)]
        public string Delete_Flag { get; set; }
    }
}
