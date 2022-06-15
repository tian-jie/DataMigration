using Infrastructure.Core;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Innocellence.DXYDataTransfer.Models
{
    [Table("lilly_dxy_doc_data")]
    public class Lilly_DXY_Doc_Data : DxyEntityBase<int>
    {
        [Column("docid")]
        public virtual string DocId { get; set; }
        [Column("docopenid")]
        public virtual string DocOpenid { get; set; }
        [Column("enrollment")]
        public virtual DateTime? Enrollment { get; set; }
        [Column("docname")]
        public virtual string DocName { get; set; }
    }
}