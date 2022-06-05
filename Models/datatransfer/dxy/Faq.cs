using Infrastructure.Core;
using System;

namespace Innocellence.DXYDataTransfer.Models
{
    public class Lilly_DXY_Data_Faq : DxyEntityBase<int>
    {
        public override int Id { get; set; }
        public override int Rid { get; set; }
        public virtual string First_category { get; set; }
        public virtual string Second_category { get; set; }
        public virtual string Third_category { get; set; }
        public virtual string Fourth_category { get; set; }
        public virtual string Question { get; set; }
        public virtual string Answer { get; set; }
        public virtual string Keywords { get; set; }
        public override DateTime CreatedUtc { get; set; }
        // 2017-10-13 Add Start ------>
        public virtual string Deleted { get; set; }
        // 2017-10-13 Add End   ------<
        // 2018-03-15 Add Start ------>
        public virtual int? Updated { get; set; }
        public override DateTime UpdatedUtc { get; set; }
        // 2018-03-15 Add End   ------<
        // 2018-11-29 Add Start ------>
        public virtual int? Created { get; set; }
        // 2018-11-29 Add End   ------<
    }
}