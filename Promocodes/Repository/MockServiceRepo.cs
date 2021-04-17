using System;
using System.Collections.Generic;
using Promocodes.Models;

namespace Promocodes.Repository
{
    public class MockServiceRepo : IServicesRepo
    {

        public void CreateService(Service aservice)
        {
            throw new NotImplementedException();
        }

        public void DeleteService()
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Service> GetAllServices()
        {
            var services = new List<Service>()
            {
                new Service{ 
                Id=1,
                Name = "Service 1",
                Description = "Description of Service 1",
                Code = "0001A",
                IsActivated = true
                },

                new Service{ 
                Id=2,
                Name = "Service 2",
                Description = "Description of Service 2",
                Code = "0002A",
                IsActivated = true
                },

                new Service{ 
                Id=3,
                Name = "Service 3",
                Description = "Description of Service 3",
                Code = "0003A",
                IsActivated = true
                }
            };
            return services;
        }

        public Service GetServiceById(int id)
        {
            return new Service{ 
                Id=1,
                Name = "Service 1",
                Description = "Description of Service 1",
                Code = "0001A",
                IsActivated = true
                };
        }
        public void UpdateService(Service aService)
        {
            throw new NotImplementedException();
        }
    }
}