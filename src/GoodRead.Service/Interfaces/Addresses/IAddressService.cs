using GoodRead.Domain.Entities.Addresses;
using GoodRead.Service.DTOs.Addresses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodRead.Service.Interfaces.Addresses
{
    public interface IAddressService
    {
        Task<bool> CreateAsync(AddressCreateDto addressCreateDto);
        Task<bool> UpdateAsync(AddressCreateDto addressCreateDto);
        Task<bool> DeleteAsync(long id);
    }
}
