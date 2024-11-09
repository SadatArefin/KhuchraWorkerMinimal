﻿namespace KhuchraWorkerMinimal.Data.Entities
{
    public class Gig
    {
        public int Id { get; set; }

        public string? Title { get; set; }

        public string? Description { get; set; }

        public decimal PriceRangeStart { get; set; }

        public decimal PriceRangeEnd { get; set; }

        public bool IsAvailable { get; set; }
    }
}