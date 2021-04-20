using System.Collections.Generic;
using Promocodes.Models;

namespace Promocodes.Repository
{
   public interface IPromotionCode
   {
       IEnumerable<PromotionCode> GetServices();
       PromotionCode GetServicesById(int id);
       PromotionCode CreateAService(PromotionCode pcService);

       PromotionCode UpdateAService(PromotionCode pcService);
       PromotionCode DeleteAService(int id);
   }
}