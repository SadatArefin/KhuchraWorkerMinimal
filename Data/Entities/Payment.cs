namespace KhuchraWorkerMinimal.Data.Entities
{
    public class Payment
    {
        public int Id { get; set; }

        public string? PaymentMethod { get; set; }

        public string? PaymentType { get; set; }

        public string? PaymentCode { get; set; }

        public decimal Amount { get; set; }

        public BaseUser? PaidBy { get; set; }

        public BaseUser? PaidTo { get; set; }

        public DateTime? PaidAt { get; set; }
    }
}
