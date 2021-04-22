using System;
using System.Collections.Generic;
using Promocodes.Models;
using Promocodes.Repository;
using Promocodes.Services;
using Xunit;

namespace Promo_code.Test
{
    public class PromotionCodeTests
    {
        private readonly PromotionCodeDbContext _context;
        private readonly PromotionCodeServices _services;

        public PromotionCodeTests(PromotionCodeDbContext context, PromotionCodeServices scv)
        {
            _context = context;
            _services = scv;
        }
        [Fact]
        public void TestGetServices()
        {
            //Arrange
            var services = new List<PromotionCode> 
            {
                new PromotionCode{Id=1, Name="Substitute.io", Description="Description1", Code="A0001", IsActivated=false},
                new PromotionCode{Id=1, Name="Technugget.com", Description="Description2", Code="A0002", IsActivated=false},
                new PromotionCode{Id=1, Name="Dempsey John", Description="Description3", Code="A0003", IsActivated=false},
                new PromotionCode{Id=1, Name="Harveys' College", Description="Description4", Code="A0004", IsActivated=false}
            };

            //Act

            //Assert

        }
    }
}
