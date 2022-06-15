using Infrastructure.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace Innocellence.DXYDataTransfer.Models
{
    [Table("lilly_dxy_data_callrecords")]
    public class Lilly_DXY_Data_CallRecords : DxyEntityBase<int>
    {
        [Column("pid")]
        public virtual int? Pid { get; set; }
        [Column("call_type")]
        public virtual int? Call_Type { get; set; }
        [Column("starttime")]
        public virtual int? StartTime { get; set; }
        [Column("endtime")]
        public virtual int? EndTime { get; set; }
        [Column("contact_object")]
        public virtual int? Contact_Object { get; set; }
        [Column("remark")]
        public virtual string Remark { get; set; }
        [Column("result")]
        public virtual string Result { get; set; }
        [Column("deleted")]
        public virtual string Deleted { get; set; }
        [Column("event_id")]
        public virtual int? Event_id { get; set; }
        [Column("updated")]
        public virtual int? Updated { get; set; }
        [Column("created")]
        public virtual int? Created { get; set; }
    }
}