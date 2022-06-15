using Infrastructure.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace Innocellence.DXYDataTransfer.Models
{
    [Table("lilly_dxy_data_devices")]
    public class Lilly_DXY_Data_Devices : DxyEntityBase<int>
    {
        [Column("status")]
        public virtual int? Status { get; set; }
        [Column("imei")]
        public virtual string Imei { get; set; }
        [Column("deleted")]
        public virtual string Deleted { get; set; }
        [Column("updated")]
        public virtual int? Updated { get; set; }
        [Column("created")]
        public virtual int? Created { get; set; }
    }
}