using Infrastructure.Core;
using System;

namespace Innocellence.DXYDataTransfer.Models
{
    public class Lilly_TC_Data_CourseChapter_Temp : KwEntityBase<int>
    {
        public override int Id { get; set; }
        public override Int64 Rid { get; set; }
        public virtual Int64 Course_id { get; set; }
        public virtual string Chapter_name { get; set; }
        public virtual string Chapter_memo { get; set; }
        public virtual int Sort { get; set; }
        public virtual string Img { get; set; }
        public virtual string Thumbnail { get; set; }
        public virtual int Is_valid { get; set; }
        public virtual DateTime Updated { get; set; }
        public virtual DateTime Created { get; set; }
        public override DateTime CreatedUtc { get; set; }
        public override DateTime UpdatedUtc { get; set; }
    }
}