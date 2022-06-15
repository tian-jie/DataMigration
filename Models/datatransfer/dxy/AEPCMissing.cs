using Infrastructure.Core;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Innocellence.DXYDataTransfer.Models
{
    [Table("lilly_dxy_data_aepcmissing")]
    public class Lilly_DXY_Data_AEPCMissing : DxyEntityBase<int>
    {
        [Column("date")]
        public virtual string Date { get; set; }
        [Column("if_missing")]
        public virtual int? If_Missing { get; set; }
        [Column("deleted")]
        public virtual string Deleted { get; set; }
        [Column("updated")]
        public virtual int? Updated { get; set; }
        [Column("signid")]
        public virtual int? SignId { get; set; }
        [Column("created")]
        public virtual int? Created { get; set; }
    }
}