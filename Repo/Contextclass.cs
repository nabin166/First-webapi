using Domain;
using Microsoft.EntityFrameworkCore;

namespace Repo
{
    public class Contextclass : DbContext
    {
     

        public Contextclass(DbContextOptions<Contextclass> options) : base(options)
        {
    
        }

        public virtual DbSet<User> Users { get; set; } = null!;
    }
}
