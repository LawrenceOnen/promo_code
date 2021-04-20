using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Promocodes.Models;
using Promocodes.Repository;

namespace Promocodes.Services
{
    public class PromotionCodeServices : IPromotionCode
    {
        private readonly PromotionCodeDbContext _db;
         //Obtain the db context through DI
        public PromotionCodeServices(PromotionCodeDbContext dbCtx)
        {
            _db = dbCtx;
        }
        public PromotionCode CreateAService(PromotionCode pcService)
        {
            //Save and return currently added service if it exists
            if (pcService != null)
            {
                _db.PromotionCodes.Add(pcService);
                _db.SaveChanges();
                return pcService;
            }
            return null;
        }

        public PromotionCode DeleteAService(int id)
        {
            var service = _db.PromotionCodes.FirstOrDefault(x => x.Id == id);
            _db.Entry(service).State = EntityState.Deleted;
            _db.SaveChanges();
            return service;
        }

        //Get the list of services
        public IEnumerable<PromotionCode> GetServices()
        {
            var servicesList = _db.PromotionCodes.ToList();
            return servicesList;
        }

        //Get a single serivice for the given Id

        public PromotionCode GetServicesById(int id)
        {
            var service = _db.PromotionCodes.FirstOrDefault(x => x.Id == id);
            return service;
        }

        public PromotionCode UpdateAService(PromotionCode pcService)
        {
            _db.Entry(pcService).State = EntityState.Modified;
            _db.SaveChanges();
            return pcService;;
        }
    }
}