using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Promocodes.Models;
using Promocodes.Repository;

namespace Promocodes.Controllers
{
    //api/services
    [Route("api/services")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly IServicesRepo _repository;

        //Inject the repository
        public ServicesController(IServicesRepo repository)
        {
            _repository = repository;
        }
        //GET api/services
        [HttpGet("")]
        public ActionResult <IEnumerable<Service>> GetAllServices()
        {
            var servicelist = _repository.GetAllServices();
            return Ok(servicelist);
        }

        //GET api/services/{id}
        [HttpGet("{id}")]
        public ActionResult <Service> GetServiceById(int id)
        {
            var serviceItem = _repository.GetServiceById(id);
            
            return Ok(serviceItem);
        }

        //Create a service
        [HttpPost]
        public async Task<ActionResult <Service>> CreateService(Service aservice)
        {
            _repository.CreateService(aservice);
            await _repository.SaveChangesAsync();

            return CreatedAtAction(nameof(CreateService), new {Id = aservice.Id}, aservice);
        }
    }
}