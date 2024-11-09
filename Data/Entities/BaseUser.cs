namespace KhuchraWorkerMinimal.Data.Entities
{
    public class BaseUser
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public required string Email { get; set; }
    }
}