namespace payroll
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Payment_Sub_Catagory
    {
        [Key]
        public int Pay_Sub_Cat_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }

        [Required]
        [StringLength(10)]
        public string Nature_Code { get; set; }

        [Required]
        [StringLength(1)]
        public string Active_Status { get; set; }

        [Required]
        [StringLength(1)]
        public string Delete_Flag { get; set; }
    }
}
