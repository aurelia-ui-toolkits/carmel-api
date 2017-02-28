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
            _logger.LogInformation("Component " + component.Name + " added to the database");
        }

        public void AddSample(string componentName, string creatorName, Sample newSample)
        {
            var component = GetComponentByName(componentName);

            if (component != null)
            {
                // Set the foreign key
                //
                component.Samples.Add(newSample);

                //_context.Samples.Add(newSample);  // This does not seem needed any more with EF core 1.1.0

                _logger.LogInformation("New sample added to the component " + componentName);
            }
        }

        public IEnumerable<Component> GetAllComponents()
        {
            _logger.LogInformation("Getting all Components from database");

            var result =  _context.Components.ToList();
            return result;
        }

        public IEnumerable<Component> GetAllComponentsWithSamples()
        {
            _logger.LogInformation("Getting all Components with Samples from database");

            var result = _context.Components         
                .Include(c => c.Samples)
                .ToList();

            return result;
        }


        public Component GetComponentByName(string name)
        {
            _logger.LogInformation("Getting Component " + name +  " from database");

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
