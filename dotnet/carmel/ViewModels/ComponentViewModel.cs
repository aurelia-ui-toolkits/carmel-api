using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Carmel.ViewModels
{
    public class ComponentViewModel
    {
        [Required]
        [StringLength(40, MinimumLength = 5)]
        public string Name { get; set; }

        public DateTime Created { get; set; } = DateTime.UtcNow;

        public IEnumerable<SampleViewModel> Samples { get; set; }
    }
}
