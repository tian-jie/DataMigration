using Infrastructure.Core;
using System;

namespace Innocellence.DXYDataTransfer.Models
{
    public class Lilly_DXY_Data_Insulin : DxyEntityBase<int>
    {
        public override int Id { get; set; }
        public override int Rid { get; set; }
        public virtual string Name { get; set; }
        public virtual string Name_pinyin { get; set; }
        public virtual string Name_intials { get; set; }
        public virtual int? Is_lilly_insulin { get; set; }
        public virtual int? Created { get; set; }
        public virtual int? Updated { get; set; }
        public virtual int? Deleted { get; set; }
        public override DateTime CreatedUtc { get; set; }
        public override DateTime UpdatedUtc { get; set; }
    }
}