import { Gig } from './gig.model';
import { Specialization } from './Specialization.model';
import { User } from './user.model';

export interface Freelancer extends User {
  portfolioUrl?: string;
  gigs?: Gig[];
  specializations?: Specialization[];
}
