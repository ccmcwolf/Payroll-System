namespace payroll
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Trans_Job_Assignment
    {
        [Key]
        public int Trans_Assignment_ID { get; set; }

        public DateTime? Assignment_Date { get; set; }

        public int? Cust_ID { get; set; }

        public int? Vehicle_ID { get; set; }

        public int? Driver_ID { get; set; }

        public int? Cleaner_ID { get; set; }

        public int? Start_Meter_R { get; set; }

        public int? End_Meter_R { get; set; }

        public DateTime? Start_Date { get; set; }

        public DateTime? End_Date { get; set; }

        public float? Free_Hours { get; set; }

        public float? Hire_Charge { get; set; }

        public float? Labour_Charge { get; set; }

        public float? Container_Charge { get; set; }

        [StringLength(1)]
        public string Active_Status { get; set; }

        public DateTime? Updated_Date { get; set; }

        public int? Updated_User_ID { get; set; }

        [StringLength(1)]
        public string Delete_Flag { get; set; }

        [StringLength(2)]
        public string Month_lock { get; set; }

        [StringLength(3)]
        public string Payment_Made { get; set; }
    }
}
