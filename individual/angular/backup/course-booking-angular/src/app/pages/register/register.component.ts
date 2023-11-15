import { Component } from '@angular/core';
import { Router } from '@angular/router';
import Swal from 'sweetalert2';
import { UserService } from '@services/user.service';
import { User } from '@models/user';
import { Observable } from 'rxjs'; 

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent {
  user: User = new User(0, '', '', '', ''); 
  confirmPassword: string = '';

  constructor(
    private userService: UserService,
    private router: Router
  ) {}

  onSubmit() {
    // if (this.user.password !== this.confirmPassword) {
    //   Swal.fire('Registration Failed', 'Passwords do not match. Please try again.', 'error');
    //   return;
    // }

    const userData = new User();
    userData.firstName = this.user.firstName;
    userData.lastName = this.user.lastName;
    userData.email = this.user.email;
    userData.password = this.user.password;

    this.userService.register(userData).subscribe({
      next: (response: any) => this.successfulRegister(response),
      error: (error: any) => this.failedRegister(error)
    });
    
  }

  successfulRegister(response: any) {
    console.log(response);
    Swal.fire('Registration Succesful', 'You can now login using your new account.', 'success' );
    this.router.navigate(['login']);
  }

  failedRegister(result: any) {
    let data: any = result['error'];

    if(data['result'] === 'user_already_exist'){
      Swal.fire('Registration Unsuccessful', 'User already exist. Please use a different email.', 'error')
    }
  }
}
