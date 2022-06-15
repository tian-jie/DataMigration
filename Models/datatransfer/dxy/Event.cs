using Infrastructure.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace Innocellence.DXYDataTransfer.Models
{
    [Table("lilly_dxy_data_event")]
    public class Lilly_DXY_Data_Event : DxyEntityBase<int>
    {
        [Column("call_reason")]
        public virtual string Call_Reason { get; set; }
        [Column("title")]
        public virtual string Title { get; set; }
        [Column("deleted")]
        public virtual string Deleted { get; set; }
        [Column("updated")]
        public virtual int? Updated { get; set; }
        [Column("contact_type")]
        public virtual int? Contact_type { get; set; }
        [Column("aepc_id")]
        public virtual int? Aepc_id { get; set; }
        [Column("created")]
        public virtual int? Created { get; set; }
    }
}