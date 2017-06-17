namespace payroll
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Emp_Extra_Work
    {
        [Key]
        public int ExtraAttendance_ID { get; set; }

        public int? Employee_ID { get; set; }

        public DateTime? Work_Date { get; set; }

        public float? Work_Hours { get; set; }

        [StringLength(1)]
        public string Active_Status { get; set; }

        [StringLength(1)]
        public string Process_Status { get; set; }

        public DateTime? Updated_Date { get; set; }

        public int? Updated_User_ID { get; set; }

        [StringLength(1)]
        public string Delete_Flag { get; set; }

        [StringLength(2)]
        public string Month_lock { get; set; }
    }
}
