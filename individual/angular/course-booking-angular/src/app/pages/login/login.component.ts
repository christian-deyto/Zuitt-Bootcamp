import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import Swal from 'sweetalert2';

import { UserService } from '@services/user.service';
import { SessionService } from '@services/session.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit{

    email: string = '';
    password: string = '';

  constructor(
    private sessionService: SessionService,
    private userService: UserService,
    private router: Router
  ) {}
  
  ngOnInit(): void {
    
  }

  onSubmit() {
    this.userService.login(this.email, this.password).subscribe({next: this.successfulLogin.bind(this),
      error: this.failedLogin.bind(this)  
    });
  }

  successfulLogin(response: Record<string, any>) {

    this.sessionService.setEmail(response['email']);
    this.sessionService.setIsAdmin(response['isAdmin']);
    this.sessionService.setToken(response['token']);
    this.router.navigate(['']).then(() => {
      //Full page reload to ensure cache of the localStorage is removed.
      window.location.href = "/";
    })
    // console.log(response);
    // this.router.navigate(['']);
  };

  failedLogin(result: Record<string, any>) {
    let data: Record<string, any> = result['error'];

    if(data['result'] === 'incorrect_credentials') {
      Swal.fire('Login Failed', 'You have entered an incorrect credentials, please try again.', 'error');
    } else if (data['result'] === 'user_not_found') {
      Swal.fire('Login Failed', 'User does not exist, please try again.', 'error');
    }

  };




  // onSubmit(): void {

  //   this.userService.login(this.email, this.password).subscribe((response: Record<string, any>) => {
  //     console.log(response);
  //   })

  //   // console.log(this.email);
  //   // console.log(this.password);
  // }


}
