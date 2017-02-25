using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Carmel.Models
{
    public class CatalogRepository : ICatalogRepository
    {
        private CatalogContext _context;

        public CatalogRepository(CatalogContext context)
        {
            _context = context;
        }

        IEnumerable<Component> ICatalogRepository.GetAllComponents()
        {
            throw new NotImplementedException();
        }

        IEnumerable<Component> ICatalogRepository.GetAllComponentsWithSamples()
        {
            throw new NotImplementedException();
        }
    }
}
