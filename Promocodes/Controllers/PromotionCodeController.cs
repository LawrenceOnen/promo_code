using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    public class PromotionCodeController : ControllerBase
    {
        private readonly PromotionCodeServices _pService;

        //Inject the repository
        public PromotionCodeController(PromotionCodeServices pcService)
        {
            //inject the Service database context
            _pService = pcService;
        }

        //GET api/services
        [HttpGet]
        [Route("[action]")]
        [Route("api/PromotionCode/GetServices")]
        public IEnumerable<PromotionCode> GetServices()
        {
            return _pService.GetServices();
        }

         //GET api/services/{id}
        [HttpGet]
        [Route("[action]")]
        [Route("api/PromotionCode/GetServicesById")]
        public PromotionCode GetServicesById(int id)
        {
            return _pService.GetServicesById(id);
        }

        //Create a Service with Code
        [HttpPost]
        [Route("[action]")]
        [Route("api/PromotionCode/CreateAService")]
        public PromotionCode CreateAService(PromotionCode pcService)
        {
            return _pService.CreateAService(pcService);
        }

        //Update a Service with Code
        [HttpPut]
        [Route("[action]")]
        [Route("api/PromotionCode/UpdateAService")]
        public PromotionCode UpdateAService(PromotionCode pcService)
        {
            return _pService.UpdateAService(pcService);
        }

        //Delete a Service for given Id
        [HttpDelete]
        [Route("[action]")]
        [Route("api/PromotionCode/DeleteAService")]
        public PromotionCode DeleteAService(int id)
        {
            return _pService.DeleteAService(id);
        }
    }
}