using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ABPMPA.Demo.Authorization.Roles;
using ABPMPA.Demo.Authorization.Users;
using ABPMPA.Demo.MultiTenancy;
using ABPMPA.Demo.PhoneBooks.Persons;
using ABPMPA.Demo.PhoneBooks.PhoneNumbers;

namespace ABPMPA.Demo.EntityFrameworkCore
{
    public class DemoDbContext : AbpZeroDbContext<Tenant, Role, User, DemoDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
            

        public DemoDbContext(DbContextOptions<DemoDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Phones> Phones { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().ToTable("Person", "PB");
            modelBuilder.Entity<Phones>().ToTable("Phone", "PB");
            base.OnModelCreating(modelBuilder);
        }
    }
}
