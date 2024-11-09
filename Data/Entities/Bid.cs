namespace KhuchraWorkerMinimal.Data.Entities
{
    public class Bid
    {
        public int Id { get; set; }

        public decimal Amount { get; set; }

        public string? Description { get; set; }

        public DateTime BidAt { get; set; }

        public DateTime? AcceptedAt { get; set; }

        public bool IsAccepted { get; set; }

        public bool IsRejected { get; set; }

        #region Navigation Properties
        public int FreelancerId { get; set; }

        public Freelancer? Freelancer { get; set; }
        #endregion
    }
}
