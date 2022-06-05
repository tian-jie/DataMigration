using Infrastructure.Core;

namespace Innocellence.DXYDataTransfer.Models
{
    public class DXYDataModel
    {
        public string timestamp { get; set; }
        public string nonce { get; set; }
        public string sign { get; set; }
        public string tableName { get; set; }
        public string file { get; set; }
        public string key { get; set; }
        public string keyId { get; set; }
        public string appId { get; set; }
    }

    public class KeyModel
    {
        public string appId { get; set; }
        public string sign { get; set; }
        public string timestamp { get; set; }
        public string nonce { get; set; }
    }
}