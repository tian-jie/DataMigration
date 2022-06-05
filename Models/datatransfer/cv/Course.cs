using Infrastructure.Core;
using System;

namespace Innocellence.DXYDataTransfer.Models
{
    public class Lilly_TC_Data_Course_Temp : KwEntityBase<int>
    {
        public override int Id { get; set; }
        public override Int64 Rid { get; set; }
        public virtual int? Type { get; set; } //20210120 DataModeling delete
        public virtual int Course_type { get; set; }
        public virtual string Name { get; set; }
        public virtual string Memo { get; set; }
        public virtual string Img { get; set; }
        public virtual string Surface_img { get; set; }
        public virtual string Thumbnail { get; set; }
        public virtual string Grade { get; set; }
        public virtual int Chapter { get; set; }
        public virtual string Chapter_memo { get; set; }
        public virtual string Apply_crowd { get; set; }
        public virtual string Apply_crowd_content { get; set; }
        public virtual int Is_valid { get; set; }
        public virtual DateTime Updated { get; set; }
        public virtual DateTime Created { get; set; }

        public virtual string Show_status { get; set; }
        public virtual int? Check_status { get; set; }
        public virtual DateTime? Publish_dt { get; set; }

        public override DateTime CreatedUtc { get; set; }
        public override DateTime UpdatedUtc { get; set; }

        public virtual string Opinion_one { get; set; }
        public virtual string Opinion_two { get; set; }
        public virtual string Watermark { get; set; }
        public virtual string Required { get; set; }
    }
}