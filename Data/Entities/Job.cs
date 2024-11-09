namespace KhuchraWorkerMinimal.Data.Entities
{
    public class Job
    {
        public int Id { get; set; }

        public required string Title { get; set; }

        public string? Description { get; set; }

        #region Navigation Properties
        public int ClientId { get; set; }

        public Client? Client { get; set; }

        public List<Bid>? Bids { get; set; }
        #endregion

    }
}

