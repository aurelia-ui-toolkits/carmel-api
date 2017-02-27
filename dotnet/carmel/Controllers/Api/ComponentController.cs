using AutoMapper;
using Carmel.Models;
using Carmel.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Carmel.Controllers.Api
{
    [Route("api/components")]
    public class ComponentController: Controller
    {
        private ICatalogRepository _repository;
        private ILogger _logger;

        public ComponentController(ICatalogRepository repository, ILogger<ComponentController> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            try
            {
                var results = _repository.GetAllComponentsWithSamples();

                return Ok(Mapper.Map<IEnumerable<ComponentViewModel>>(results));
            }
            catch (Exception ex)
            {
                _logger.LogError($"Failed to get all Components: {ex}");

                return BadRequest("Error ocurred");
            }
        }

        [HttpPost("")]
        public async Task<IActionResult> Post([FromBody]ComponentViewModel theComponent)
        {
            if (ModelState.IsValid)
            {
                //
                //Save to database
                //
                var newComponent = Mapper.Map<Component>(theComponent);
                _repository.AddComponent(newComponent);

                if (await _repository.SaveChangesAsync())
                {
                    return Created($"api/components/{theComponent.Name}", Mapper.Map<ComponentViewModel>(newComponent));
                }
            }
            return BadRequest($"Failed to save the component: {theComponent.Name}");
        }
    }
}
