namespace KhuchraWorkerMinimal.Dto;

public class JobDto
{
    public required string Title { get; set; }
    public string? Description { get; set; }
    public int UserId { get; set; }
}