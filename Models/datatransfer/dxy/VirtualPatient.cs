using Infrastructure.Core;
using System;

namespace Innocellence.DXYDataTransfer.Models
{
    public class Lilly_DXY_Data_VirtualPatient : DxyEntityBase<int>
    {
        public override int Id { get; set; }
        public override int Rid { get; set; }
        public virtual int PatientId { get; set; }
        public virtual string PatientCardId { get; set; }
        public virtual string HcpCardId { get; set; }
        public override DateTime CreatedUtc { get; set; }
    }
}