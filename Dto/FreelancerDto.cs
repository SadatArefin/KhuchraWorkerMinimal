using KhuchraWorkerMinimal.Data.Entities;

namespace KhuchraWorkerMinimal.Dto
{
    public class FreelancerDto
    {
        public string? PortfolioUrl { get; set; }

        public ICollection<GigDto>? Gigs { get; set; }

        public ICollection<Specialization>? Specializations { get; set; }
    }
}
