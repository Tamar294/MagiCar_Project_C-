using Bl.DTO;
using Dal.Api;
using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bl.Api
{
    public interface IAddressService : IRepository<AddressDTO>
    {
    }
}
