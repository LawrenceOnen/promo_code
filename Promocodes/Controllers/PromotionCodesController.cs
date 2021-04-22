using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Promocodes.Models;
using Promocodes.Repository;
using Promocodes.Services;

namespace Promocodes.Controllers
{
    //api/services
    [Route("api/[controller]")]
    [ApiController]
    public class PromotionCodesController : ControllerBase
    {
        private readonly PromotionCodeServices _pcService;

        //Constructor: Inject Service class
        public PromotionCodesController(PromotionCodeServices pcService)
        {
            //inject the Service database context
            _pcService = pcService;
        }

        //GET api/services
        [HttpGet]
        [Authorize]
        [Route("[Controller]")]
        public ActionResult <IEnumerable<PromotionCode>> GetServices()
        {
            var servicesList = _pcService.GetServices();
            return Ok(servicesList);
        }

         //GET api/services/{id}
        [Authorize]
        [HttpGet("{id}")]
        public ActionResult<PromotionCode> GetServicesById(int id)
        {
            var singleService = _pcService.GetServicesById(id);
            return Ok(singleService);
        }

        //Create a Service with Code
        [HttpPost]
        [Authorize]
        [Route("api/PromotionCodes/CreateAService")]
        public PromotionCode CreateAService([FromBody]PromotionCode pcService)
        {
            var newService = _pcService.CreateAService(pcService);
            return newService;
            
        }

        //Update a Service with Code
        [HttpPut]
        [Authorize]
        [Route("[action]")]
        [Route("api/PromotionCodes/UpdateAService")]
        public PromotionCode UpdateAService(PromotionCode pcService)
        {
            return _pcService.UpdateAService(pcService);
        }

        //Delete a Service for given Id
        [HttpDelete]
        [Authorize]
        [Route("[action]")]
        [Route("api/PromotionCodes/DeleteAService")]
        public PromotionCode DeleteAService(int id)
        {
            return _pcService.DeleteAService(id);
        }
        //Return list of serach results that match the search criteria
        [HttpGet("{search}")]
        [Authorize]
        public ActionResult<IEnumerable<PromotionCode>> Search(string code, string name)
        {
            try
            {
                var result = _pcService.Search(code, name);
                if (result.Any())
                {
                    return Ok(result);
                }
                return BadRequest();
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieiving data from the database");
            }
        }
    }
}