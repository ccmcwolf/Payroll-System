namespace WpfApplication3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Vehicle")]
    public partial class Vehicle
    {
        [Key]
        public int Vehiclet_ID { get; set; }

        [StringLength(25)]
        public string Vehicle_Display_Name { get; set; }

        public int? YOM { get; set; }

        public int? YOR { get; set; }

        public float? Purchase_Value { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public DateTime? Created_Date { get; set; }

        [StringLength(1)]
        public string Active_Status { get; set; }

        public DateTime? Updated_Date { get; set; }

        public int? Updated_User_ID { get; set; }

        [StringLength(1)]
        public string Delete_Flag { get; set; }
    }
}
