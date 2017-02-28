using Carmel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Carmel.ViewModels
{
    public class SampleViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string Name { get; set; }

        public DateTime Created { get; set; } = DateTime.UtcNow;
        public string gist { get; set; }
        public List<SampleTag> sampleTags { get; set; }
    }
}
