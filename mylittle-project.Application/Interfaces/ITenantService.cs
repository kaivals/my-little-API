using mylittle_project.Application.DTOs;
using mylittle_project.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace mylittle_project.Application.Interfaces
{
    public interface ITenantService
    {
        Task<IEnumerable<Tenant>> GetAllAsync();
        Task<Tenant> CreateAsync(FullTenantDto dto);

        // ✅ New: Get tenant including its feature settings
        Task<Tenant?> GetTenantWithFeaturesAsync(Guid tenantId);

        // ✅ New: Just get feature settings
        Task<FeatureSettingsDto?> GetFeatureTogglesAsync(Guid tenantId);

        // ✅ New: Update feature settings
        Task<bool> UpdateFeatureTogglesAsync(Guid tenantId, FeatureSettingsDto dto);
        Task<bool> UpdateStoreAsync(Guid tenantId, StoreDto dto);

<<<<<<< HEAD
        Task<IEnumerable<ProductDto>> GetProductListingsByTenantAsync(Guid tenantId);
=======
>>>>>>> 00dbda0da5a79de1b8ac5b8d7df47caf7d11e375

    }
}


