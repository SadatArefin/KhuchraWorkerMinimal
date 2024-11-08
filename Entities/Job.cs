namespace KhuchraWorkerMinimal.Entities
{
    public class Job
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public string? Description { get; set; }

        #region Navigation
        public int UserId { get; set; }
        public BaseUser? User { get; set; }
        #endregion

    }
}

