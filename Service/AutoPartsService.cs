using CarService.Data.Entities;
using CarService.Models;
using CarService.Repository;
using CarService.Repository.Interface;
using CarService.Service.Interface;

namespace CarService.Service
{
    public class UserService : IAutoPartstService
    {
        private readonly IAutoPartstRepository autopartsRepository;

        public UserService (IAutoPartstRepository autopartsRepository) 
        {
        
        this.autopartsRepository= autopartsRepository;
        
        
        }



        public void Add(CreateAutoPartsViewModel autoparts)
        {
            var autopartsEntity = new AutoParts(autoparts.Name,autoparts.Price, autoparts.Stock );
            autopartsRepository.Add(autopartsEntity);
        }
    }
}
