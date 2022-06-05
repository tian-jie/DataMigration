using Infrastructure.Core;
using System;

namespace Innocellence.DXYDataTransfer.Models
{
    public class Lilly_DXY_Data_PatientAccessDetails : DxyEntityBase<int>
    {
        public override int Id { get; set; }
        public override int Rid { get; set; }
        public virtual int Pid { get; set; }
        public virtual string Access_month { get; set; }
        public virtual int? Month_count { get; set; }
        public virtual int? Month_stay_second { get; set; }
        public virtual int? Ninety_day_count { get; set; }
        public virtual int? Ninety_day_stay_second { get; set; }

        public override DateTime CreatedUtc { get; set; }
        public virtual int? Created { get; set; }
        public override DateTime UpdatedUtc { get; set; }
        // 2018-03-14 Add End   ------<
    }
}