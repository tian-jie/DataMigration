using Infrastructure.Core;
using System;

namespace Innocellence.DXYDataTransfer.Models
{
    public class Lilly_DXY_Doc_Data : DxyEntityBase<int>
    {
        public override int Id { get; set; }
        public override int Rid { get; set; }
        public virtual string DocId { get; set; }
        public virtual string DocOpenid { get; set; }
        public virtual DateTime? Enrollment { get; set; }
        public virtual string DocName { get; set; }
    }
}