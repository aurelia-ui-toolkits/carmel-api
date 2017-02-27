using AutoMapper;
using Carmel.Models;
using Carmel.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Carmel.Controllers.Api
{
    [Route("/api/components/{componentName}/samples")]
    public class SampleController : Controller
    {
        private ILogger<SampleController> _logger;
        private ICatalogRepository _repository;

        string creatorName = "John Summers";

        public SampleController(ICatalogRepository repository, ILogger<SampleController> logger)
        {
            _repository = repository;
            _logger = logger;

        }

        [HttpGet("")]
        public IActionResult Get(string componentName)
        {
            try
            {
                var component = _repository.GetComponentByName(componentName, creatorName);

                return Ok(Mapper.Map<IEnumerable<SampleViewModel>>(component.Samples.OrderBy(s => s.Order).ToList()));
            }
            catch (Exception ex)
            {
                _logger.LogError("Failed to get samples: {0}", ex);
            }

            return BadRequest("Failed to get samples");

        }

        [HttpPost("")]
        public async Task<IActionResult> Post(string componentName, [FromBody]SampleViewModel vm)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var newSample = Mapper.Map<Sample>(vm);

                    _repository.AddSample(componentName, creatorName, newSample);

                    if (await _repository.SaveChangesAsync())
                    {
                        return Created($"/api/components/{componentName}/samples/{newSample.Name}",
                            Mapper.Map<SampleViewModel>(newSample));
                    }
                }

            }
            catch (Exception ex)
            {
                _logger.LogError("Failed to save new Sample: {0}", ex);
            }
            return BadRequest("Failed to save new Sample");
        }
    }
}
