using System.Collections.Generic;
using System.Threading.Tasks;

namespace Carmel.Models
{
    public interface ICatalogRepository
    {
        IEnumerable<Component> GetAllComponents();
        IEnumerable<Component> GetAllComponentsWithSamples();

        void AddComponent(Component component);
        void AddSample(string componentName, string creatorName, Sample newSample);

        Task<bool> SaveChangesAsync();
        Component GetComponentByName(string name);

    }
}