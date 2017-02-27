using Carmel.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Carmel.ViewModels
{
    public class SampleViewModel
    {
        [Required]
        [StringLength(40, MinimumLength = 5)]
        public string Name { get; set; }

        public int Id { get; set; }

        [Required]
        public int Order { get; set; }

        public List<SampleTag> sampleTags { get; set; }
    }
}
