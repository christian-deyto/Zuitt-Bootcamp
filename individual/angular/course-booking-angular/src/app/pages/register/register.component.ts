import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import Swal from 'sweetalert2';

import { User } from '@models/user';
import { UserService } from '@services/user.service';



@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {
  
  user: User = new User()
  confirmPassword: string = ''

  constructor(
    private userService: UserService,
    private router: Router
  ){}


  ngOnInit(): void {}

  onRegister() {
    this.userService.register(this.user).subscribe({next: this.successfulRegister.bind(this),
      error: this.failedRegister.bind(this)
    
    })
  }

  successfulRegister(response: Record<string, any>) {
    console.log(response)
    Swal.fire('Registration Successful', 'You can now login using your new account.', 'success')
    this.router.navigate(['/login'])
  }

  failedRegister(result: Record<string, any>) {
    console.log(result)
    Swal.fire('Registration Unsuccessful', 'User already exist. Please use a different email.', 'error')
  }

}


