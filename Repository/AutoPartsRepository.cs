using CarService.Data.Entities;
using CarService.Repository.Interface;

namespace CarService.Repository
{
    public class AutoPartsRepository : IAutoPartstRepository

    {
        private readonly ApplicationContext context;

        public AutoPartsRepository(ApplicationContext context)
        {

            this.context = context; 


        }    
        

        public void Add(AutoParts autoparts)
        {
            context.AutoParts.Add(autoparts);
            context.SaveChanges();
        }
    }
}
