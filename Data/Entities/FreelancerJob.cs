namespace KhuchraWorkerMinimal.Data.Entities
{
    public sealed class FreelancerJob
    {
        public int Id { get; set; }

        public DateTime? AcceptedAt { get; set; }

        public DateTime? SubmittedAt { get; set; }

        #region Navigation Properties
        public int FreelancerId { get; set; }

        public Freelancer? Freelancer { get; set; }

        public int JobId { get; set; }

        public Job? Job { get; set; }
        #endregion
    }
}
