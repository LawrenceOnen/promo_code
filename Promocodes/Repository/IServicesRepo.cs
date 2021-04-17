using System.Collections.Generic;
using Promocodes.Models;

namespace Promocodes.Repository
{
    //Definitions of service methods for API CRUD methods
    public interface IServicesRepo
    {
        //Get a list of all services
        IEnumerable<Service> GetAllServices();

        //Get a service by ID
        Service GetServiceById(int id);

        // Create a service
        void CreateService(Service aservice);

        // Update a service
        void UpdateService(Service aService);

        // Delete a service
        void DeleteService();
    }
}