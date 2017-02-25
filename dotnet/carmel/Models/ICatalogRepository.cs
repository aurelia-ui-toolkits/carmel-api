using System.Collections.Generic;

namespace Carmel.Models
{
    public interface ICatalogRepository
    {
        IEnumerable<Component> GetAllComponents();
        IEnumerable<Component> GetAllComponentsWithSamples();
    }
}