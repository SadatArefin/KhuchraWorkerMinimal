namespace KhuchraWorkerMinimal.Data.Entities
{
    public class Specialization
    {
        public int Id { get; set; }

        public required string Name { get; set; } // e.g., "Web Development", "Graphic Design"

        public string? Description { get; set; }
    }
}
