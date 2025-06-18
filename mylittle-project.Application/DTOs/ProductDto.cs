using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mylittle_project.Application.DTOs
{
    public class ProductDto
    {
       
        public string productname  { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Status { get; set; }
        public string Portal { get; set; } // Optional: the portal it's assigned to

        // Optional: For display purposes
        public string Description { get; set; }

        public Guid TenantId { get; set; } // internal use only, can be excluded from API surface

    }
}

