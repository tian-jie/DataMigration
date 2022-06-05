﻿using Infrastructure.Core;
using System;

namespace Innocellence.DXYDataTransfer.Models
{
    public class Lilly_DXY_Data_Event : DxyEntityBase<int>
    {
        public override int Id { get; set; }
        public override int Rid { get; set; }
        public virtual string Call_Reason { get; set; }
        public virtual string Title { get; set; }
        public override DateTime CreatedUtc { get; set; }
        public virtual string Deleted { get; set; }
        // 2018-03-15 Add Start ------>
        public virtual int? Updated { get; set; }
        public override DateTime UpdatedUtc { get; set; }
        // 2018-03-15 Add End   ------<
        // 2018-11-29 Add Start ------>
        public virtual int? Contact_type { get; set; }
        public virtual int? Aepc_id { get; set; }
        public virtual int? Created { get; set; }
        // 2018-11-29 Add End   ------<
    }
}