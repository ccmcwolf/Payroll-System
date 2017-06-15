namespace WpfApplication3
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        [Key]
        public int Cust_ID { get; set; }

        [StringLength(12)]
        public string Cust_Code { get; set; }

        [StringLength(60)]
        public string Cust_Display_Name { get; set; }

        [StringLength(100)]
        public string Cust_Add_1 { get; set; }

        [StringLength(100)]
        public string Cust_Add_2 { get; set; }

        [StringLength(200)]
        public string Cust_Desc { get; set; }

        [StringLength(150)]
        public string Cust_Primary_Cont_Name { get; set; }

        [StringLength(20)]
        public string Cust_Primary_Cont_Num { get; set; }

        [StringLength(150)]
        public string Cust_Sec_Cont_Name { get; set; }

        [StringLength(20)]
        public string Cust_Sec_Cont_Num { get; set; }

        [StringLength(1)]
        public string Active_Status { get; set; }

        public DateTime? Created_Date { get; set; }

        public DateTime? Updated_Date { get; set; }

        public int? Updated_User_ID { get; set; }

        [StringLength(1)]
        public string Delete_Flag { get; set; }
    }
}
