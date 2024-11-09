namespace KhuchraWorkerMinimal.Dto
{
    public class PaymentDto
    {
        public int Id { get; set; }

        public string? PaymentMethod { get; set; }

        public string? PaymentType { get; set; }

        public string? PaymentCode { get; set; }

        public required decimal Amount { get; set; }

        public BaseUserDto? PaidBy { get; set; }

        public BaseUserDto? PaidTo { get; set; }

        public DateTime? PaidAt { get; set; }
    }
}
