import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { environment } from '@environments/environment';
import { Observable } from 'rxjs';
import { User } from '@models/user';
import { CourseEnrollment } from '@models/course-enrollment';
import { SessionService } from './session.service';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  private baseUrl: string = 'https://localhost:7289/api/users'
  private httpHeaders: HttpHeaders = new HttpHeaders({
    'Authorization': `Bearer ${this.sessionService.getToken()}`
  })
  courseEnrollment: CourseEnrollment = new CourseEnrollment();

  constructor(
    private http: HttpClient,
    private sessionService: SessionService
  ) { }

  login(email: string, password: string): Observable<Object> {
    return this.http.post(`${this.baseUrl}/login`, {email, password});
  }

  register(user: User): Observable<Object> {
    return this.http.post(`${this.baseUrl}/register`, user);
  }

  enroll(courseId: number): Observable<Object> {
    this.courseEnrollment.courseId = courseId;
    return this.http.post(`${this.baseUrl}/enroll`, this.courseEnrollment, {headers: this.httpHeaders});
  }
}