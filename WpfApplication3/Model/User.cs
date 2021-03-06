namespace payroll
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [Key]
        public int User_ID { get; set; }

        [Required]
        [StringLength(150)]
        public string User_Name { get; set; }

        [Required]
        [StringLength(150)]
        public string Password { get; set; }

        public DateTime? Created_Date { get; set; }

        public DateTime? Updated_Date { get; set; }

        public int? Updated_User_ID { get; set; }

        [StringLength(1)]
        public string Delete_Flag { get; set; }

        [StringLength(1)]
        public string Active_Status { get; set; }
    }
}
