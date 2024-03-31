using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CarService.Data.Entities;


namespace CarService.Data.Entities
{
    
        public class ApplicationContext : DbContext

        {
        internal object autoParts;

        public DbSet<AutoParts> AutoParts { get; set; }

            public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
            { }



        }
}
