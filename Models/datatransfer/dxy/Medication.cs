using Infrastructure.Core;
using System;

namespace Innocellence.DXYDataTransfer.Models
{
    public class Lilly_DXY_Data_Medication : DxyEntityBase<int>
    {
        public override int Id { get; set; }
        public override int Rid { get; set; }
        public virtual int? Pid { get; set; }
        public virtual int? Medical_Order_Id { get; set; }
        public virtual string Insulin_Type { get; set; }
        public virtual string Insulin_Name { get; set; }
        public virtual float? Dosage { get; set; }
        public virtual string Deleted { get; set; }
        public override DateTime CreatedUtc { get; set; }
        // 2018-03-15 Add Start ------>
        public virtual int? Updated { get; set; }
        public override DateTime UpdatedUtc { get; set; }
        // 2018-03-15 Add End   ------<
        // 2018-11-29 Add Start ------>
        public virtual int? Created { get; set; }
        // 2018-11-29 Add End   ------<
    }
}