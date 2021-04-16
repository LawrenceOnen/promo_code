using System;
using Xunit;

namespace Promo_code.Test
{
    public class ServiceTests
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            //Create an instance of the Service class
            var myservice = new Service(
                1, "test1", "Describing test1", "A0001"
                );

            

            //Act
            var result = myservice.createPromoCode();


            //Assert

        }
    }
}
