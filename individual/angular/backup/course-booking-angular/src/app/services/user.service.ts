import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '@environments/environment';
import { Observable } from 'rxjs';

import { User } from '@models/user';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  private baseUrl: string = 'https://localhost:7289/api/users'

  constructor(
    private http: HttpClient
  ) { }

  login(email: string, password: string): Observable<Object> {  
    return this.http.post(this.baseUrl + '/login', {email
    , password});
  }

  register(user: User): Observable<any> {
    return this.http.post<any>(this.baseUrl + '/register', user);
  }
  
  enroll(courseId: number): void {}
}
