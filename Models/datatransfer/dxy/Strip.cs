using Infrastructure.Core;
using System;

namespace Innocellence.DXYDataTransfer.Models
{
    public class Lilly_DXY_Data_Strip : DxyEntityBase<int>
    {
        public override int Id { get; set; }
        public override int Rid { get; set; }
        public virtual int? Pid { get; set; }
        public virtual int? Type { get; set; }
        public virtual string Batch { get; set; }
        public virtual int? Created { get; set; }
        public virtual int? Updated { get; set; }
        public virtual string Province { get; set; }
        public virtual string City { get; set; }
        public virtual string County { get; set; }
        public virtual string Deleted { get; set; }
        public override DateTime CreatedUtc { get; set; }
        public override DateTime UpdatedUtc { get; set; }
        // 2018-11-29 Add Start ------>
        public virtual string Goods { get; set; }
        public virtual int? Number { get; set; }
        // 2018-11-29 Add End   ------<
        
        public virtual int? Source { get; set; }//2019-05-22
    }
}