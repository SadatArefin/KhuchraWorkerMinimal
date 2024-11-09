using KhuchraWorkerMinimal.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace KhuchraWorkerMinimal.Data
{
    public class KhuchraWorkerContext(DbContextOptions<KhuchraWorkerContext> options) : DbContext(options)
    {
        public DbSet<BaseUser> Users { get; set; }

        public DbSet<Admin> Admins { get; set; }

        public DbSet<Client> Clients { get; set; }

        public DbSet<ClientJob> ClientJobs { get; set; }

        public DbSet<Freelancer> Freelancers { get; set; }

        public DbSet<Gig> Gigs { get; set; }

        public DbSet<Specialization> Specializations { get; set; }

        public DbSet<FreelancerJob> FreelancerJobs { get; set; }

        public DbSet<Bid> JobBids { get; set; }

        public DbSet<Job> Jobs { get; set; }

        public DbSet<Payment> Payment { get; set; }
    }
}