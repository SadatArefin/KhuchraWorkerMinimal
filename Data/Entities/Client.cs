namespace KhuchraWorkerMinimal.Data.Entities
{
    public sealed class Client : BaseUser
    {
        public string? CompanyName { get; set; }

        public List<ClientJob>? ClientJobs { get; set; }
    }
}
