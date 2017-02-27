using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Carmel.Models
{
    public class CatalogRepository : ICatalogRepository
    {
        private CatalogContext _context;
        private ILogger<CatalogRepository> _logger;

        public CatalogRepository(CatalogContext context, ILogger<CatalogRepository> logger)
        {
            _context = context;
            _logger = logger;
        }

        public void AddComponent(Component component)
        {
            _context.Add(component);
        }

        public void AddSample(string componentName, string creatorName, Sample newSample)
        {
            var component = GetComponentByName(componentName, creatorName);

            if (component != null)
            {
                // Set the foreign key
                //
                component.Samples.Add(newSample);

                _context.Samples.Add(newSample);
            }
        }

        public IEnumerable<Component> GetAllComponents()
        {
            _logger.LogInformation("Getting all Components from database");

            return _context.Components.ToList();
        }

        public IEnumerable<Component> GetAllComponentsWithSamples()
        {
            return _context.Components
                .Include(c => c.Samples)
                .OrderBy(c => c.Name)
                .ToList();
        }

        public Component GetComponentByName(string componentName, string creatorName)
        {
            return _context.Components
                .Include(s => s.Samples)
                .Where(s => s.Name == componentName && s.Name == creatorName)
                .FirstOrDefault();
        }

        public object GetComponentByName(string name)
        {
            return _context.Components
                .Include(s => s.Samples)
                .Where(s => s.Name == name)
                .FirstOrDefault();
        }

        public async Task<bool> SaveChangesAsync()
        {
            //
            // If the save was successful, it will return the number of affected rows
            // which should be greater than 0
            //
            return (await _context.SaveChangesAsync()) > 0;
        }

    }
}
