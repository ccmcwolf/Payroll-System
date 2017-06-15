namespace WpfApplication3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Payment_Catagory
    {
        [Key]
        public int Pay_Cat_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }

        public int Pay_Sub_Cat_ID { get; set; }

        [Required]
        [StringLength(1)]
        public string Active_Status { get; set; }

        [Required]
        [StringLength(1)]
        public string Delete_Flag { get; set; }
    }
}
