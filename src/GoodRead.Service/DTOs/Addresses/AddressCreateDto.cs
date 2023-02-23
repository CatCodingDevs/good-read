using GoodRead.Domain.Entities.Addresses;

namespace GoodRead.Service.DTOs.Addresses
{
    public class AddressCreateDto
    {
        public string Street { get; set; } = String.Empty;
        public string City { get; set; } = String.Empty;
        public string State { get; set; } = String.Empty;
        public string ZipCode { get; set; } = String.Empty;
        public string Country { get; set; } = String.Empty;

        public static implicit operator Address(AddressCreateDto addressCreateDto)
        {
            return new Address()
            {
                Street = addressCreateDto.Street,
                City = addressCreateDto.City,
                State = addressCreateDto.State,
                ZipCode = addressCreateDto.ZipCode,
                Country = addressCreateDto.Country,
            };
        }
    }
}
