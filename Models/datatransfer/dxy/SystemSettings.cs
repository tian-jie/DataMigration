using Infrastructure.Core;

namespace Innocellence.DXYDataTransfer.Models
{
    public class Lilly_DXY_Data_SystemSettings : DxyEntityBase<int>
    {
        public override int Id { get; set; }
        public override int Rid { get; set; }
        public virtual string Name { get; set; }
        public virtual string Value { get; set; }
    }
}