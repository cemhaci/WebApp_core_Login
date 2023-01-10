using Microsoft.EntityFrameworkCore;

namespace WebApp_core_Login.Models
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) 
            {

            }
        public virtual DbSet<User> Users { get; set; }

        
    }
}
