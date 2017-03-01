using System;
using System.Collections.Generic;

namespace Carmel.Models
{
    public class Component
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatorName { get; set; }
        public ICollection<Sample> Samples { get; set; }
        public List<ComponentTag> ComponentTags { get; set; }
    }
}