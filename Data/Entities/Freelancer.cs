namespace KhuchraWorkerMinimal.Data.Entities
{
    public class Freelancer : BaseUser
    {
        public string? PortfolioUrl { get; set; }

        public ICollection<Gig>? Gigs { get; set; }

        public ICollection<Specialization>? Specializations { get; set; }
    }
}
