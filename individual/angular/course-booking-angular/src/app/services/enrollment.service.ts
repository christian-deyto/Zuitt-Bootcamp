import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from '@environments/environment';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class EnrollmentService {

  private baseUrl: string = 'https://localhost:7289/api/enrollment';

  constructor(private http: HttpClient) {}

  enrollInCourse(courseId: number): Observable<any> {
    return this.http.post<any>(`${this.baseUrl}/enroll`, { courseId });
  }
}
