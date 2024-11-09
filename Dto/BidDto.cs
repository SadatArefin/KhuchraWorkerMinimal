namespace KhuchraWorkerMinimal.Dto
{
    public class BidDto
    {
        public int Id { get; set; }

        public decimal Amount { get; set; }

        public string? Description { get; set; }

        public DateTime BidAt { get; set; }

        public DateTime? AcceptedAt { get; set; }

        public bool IsAccepted { get; set; }

        public bool IsRejected { get; set; }

        public FreelancerDto? Freelancer { get; set; }
    }
}
