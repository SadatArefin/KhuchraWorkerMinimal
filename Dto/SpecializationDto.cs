namespace KhuchraWorkerMinimal.Dto
{
    public class SpecializationDto
    {
        public int Id { get; set; }

        public required string Name { get; set; } // e.g., "Web Development", "Graphic Design"

        public string? Description { get; set; }
    }
}
