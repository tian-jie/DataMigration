using Infrastructure.Core;
using System;

namespace Innocellence.DXYDataTransfer.Models
{
    public class Lilly_DXY_Data_Agent : DxyEntityBase<int>
    {
        public override int Id { get; set; }
        public override int Rid { get; set; }
        public virtual string Name { get; set; }
        public virtual int? Gender { get; set; }
        public virtual string Phone_number { get; set; }
        public virtual string Email { get; set; }
        public virtual int? status { get; set; }
        public virtual string Comment { get; set; }
        public virtual int?  Activation_time { get; set; }
        public virtual int? De_activation_time { get; set; }
        public override DateTime CreatedUtc { get; set; }
        // 2017-10-13 Add Start ------>
        public virtual string Deleted { get; set; }
        // 2017-10-13 Add End   ------<
        // 2018-03-15 Add Start ------>
        public virtual int? Updated { get; set; }
        public override DateTime UpdatedUtc { get; set; }
        // 2018-03-15 Add End   ------<
    }
}