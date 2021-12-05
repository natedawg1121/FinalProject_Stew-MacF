using Microsoft.EntityFrameworkCore;

namespace FinalProject_Stew_MacF
{
    public class BaseControllerDBContext : DbContext
    {
        public DbSet<GroupInformation> GroupInformation { get; set; }
        public BaseControllerDBContext(DbContextOptions<BaseControllerDBContext> options) : base(options)
        {

        }
    }
}