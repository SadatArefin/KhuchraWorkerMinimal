using KhuchraWorkerMinimal.Entities;
using Microsoft.EntityFrameworkCore;

namespace KhuchraWorkerMinimal.Data
{
    public class KhuchraWorkerContext(DbContextOptions<KhuchraWorkerContext> options) : DbContext(options)
    {
        public DbSet<BaseUser> Users { get; set; }
        public DbSet<Job> Jobs { get; set; }
    }
}