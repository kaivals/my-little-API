using mylittle_project.Application.DTOs;
using mylittle_project.Application.Interfaces;
using mylittle_project.Domain.Entities;
using mylittle_project.infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mylittle_project.infrastructure.Services
{
    public class BusinessService : IBusinessService
    {
        private readonly DealerDbContext _context;

        public BusinessService(DealerDbContext context)
        {
            _context = context;
        }

        public async Task<int> CreateBusinessInfoAsync(BusinessInfoDto dto)
        {
            var business = new BusinessInfo
            {
                DealerName = dto.DealerName,
                BusinessName = dto.BusinessName,
                BusinessNumber = dto.BusinessNumber,
                BusinessEmail = dto.BusinessEmail,
                BusinessAddress = dto.BusinessAddress,
                ContactEmail = dto.ContactEmail,
                PhoneNumber = dto.PhoneNumber,
                Website = dto.Website,
                TaxId = dto.TaxIdOrGstNumber,
                Country = dto.Country,
                State = dto.State,
                City = dto.City,
                Timezone = dto.Timezone
            };

            _context.BusinessInfos.Add(business);
            await _context.SaveChangesAsync();
            return business.Id;
        }
    }
}
