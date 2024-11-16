export interface Gig {
  id: number;
  title?: string;
  description?: string;
  priceRangeStart: number;
  priceRangeEnd: number;
  isAvailable: boolean;
}
