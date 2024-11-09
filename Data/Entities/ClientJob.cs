namespace KhuchraWorkerMinimal.Data.Entities
{
    public class ClientJob
    {
        public int Id { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? ReceivedAt { get; set; }

        #region Navigation Properties
        public int ClientId { get; set; }

        public Client? Client { get; set; }

        public int JobId { get; set; }

        public Job? Job { get; set; }
        #endregion
    }
}
