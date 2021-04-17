using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Promocodes.Models;
using Promocodes.Repository;

namespace Promocodes.Controllers
{
    //api/services
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly IServicesRepo _repository;
        private readonly ServiceContext _dbCtx;

        //Inject the repository
        public ServicesController(IServicesRepo repository, ServiceContext dbCtx)
        {
            _repository = repository;
            _dbCtx = dbCtx;
        }

        //GET api/services
        [HttpGet]
        public ActionResult <IEnumerable<Service>> GetAllServices()
        {
            try
            {
                var servicelist = _dbCtx.services.ToList();
                return new JsonResult(servicelist);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database failed");
            }
           
        }

        //GET api/services/{id}
        [HttpGet("{id}")]
        public ActionResult <Service> GetServiceById(int id)
        {
            return Ok();
        }

        //Create a service
        [HttpPost]
        public ActionResult <Service> CreateService([FromBody]Service aservice)
        {
            try
            {
                //Create a new service
                return Ok();
            }
            catch (Exception)
            {
                
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database failed");
            }
        } 
    }
}