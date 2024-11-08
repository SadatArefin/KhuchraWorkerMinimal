import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, ReactiveFormsModule } from '@angular/forms';
import { UserService } from '../../services/user.service';
import { User } from '../../models/user.model';
import { ActivatedRoute, Router } from '@angular/router';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-user-form',
  standalone: true,
  imports: [CommonModule, ReactiveFormsModule],
  templateUrl: './user-form.component.html',
  styleUrl: './user-form.component.css',
})
export class UserFormComponent implements OnInit {
  userForm: FormGroup;
  isEditMode = false;
  userId: number | null = null;

  constructor(
    private fb: FormBuilder,
    private userService: UserService,
    private route: ActivatedRoute,
    private router: Router
  ) {
    this.userForm = this.fb.group({
      name: [''],
      email: [''],
    });
  }

  ngOnInit(): void {
    this.userId = Number(this.route.snapshot.paramMap.get('id'));
    if (this.userId) {
      this.isEditMode = true;
      this.userService.getUserById(this.userId).subscribe((user) => {
        this.userForm.patchValue(user);
      });
    }
  }

  onSubmit(): void {
    const user: User = this.userForm.value;
    if (this.isEditMode && this.userId) {
      this.userService.updateUser(this.userId, user).subscribe(() => {
        this.router.navigate(['/users']);
      });
    } else {
      this.userService.createUser(user).subscribe(() => {
        this.router.navigate(['/users']);
      });
    }
  }
}
