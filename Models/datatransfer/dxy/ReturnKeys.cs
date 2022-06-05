using Infrastructure.Core;

namespace Innocellence.DXYDataTransfer.Models
{
    public class ReturnKeysModel : DxyEntityBase<int>
    {
        public override int Id { get; set; }
        public override int Rid { get; set; }
        public string KeyId { get; set; }
        public string PublicKey { get; set; }
    }
}