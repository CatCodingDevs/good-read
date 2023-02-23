using GoodRead.Domain.Common;

namespace GoodRead.Domain.Entities.Addresses
{
    public class Address : Auditable
    {
        public string Street { get; set; } = String.Empty;
        public string City { get; set; } = String.Empty;
        public string State { get; set; } = String.Empty;
        public string ZipCode { get; set; } = String.Empty;
        public string Country { get; set; } = String.Empty;
    }
}
