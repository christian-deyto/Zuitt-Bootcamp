import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import Swal from 'sweetalert2';

import { Course } from '@models/course';
import { SessionService } from './session.service';

@Injectable({
  providedIn: 'root'
})
export class CourseService {

  private baseUrl: string = 'https://localhost:7289/api/courses';

  private httpHeaders: HttpHeaders = new HttpHeaders({
    'Authorization': `Bearer ${this.sessionService.getToken()}`
  });

  constructor(
    private http: HttpClient,
    private sessionService: SessionService
  ) { }

  getCourses(): Observable<Course[]> {
    return this.http.get<Course[]>(this.baseUrl);
  }

  addCourse(course: Course): Observable<Course> {
    return this.http.post<Course>(this.baseUrl, course, { headers: this.httpHeaders });
  }

  getOne(id: number): Observable<Object> {
    return this.http.get<Course[]>(`${this.baseUrl}/${id}`);
  }

  add(course: Course): Observable<Course> {
    return this.http.post<Course>(this.baseUrl, course, { headers: this.httpHeaders });
  }

  update(course: Course): Observable<Object> {
    return this.http.put(`${this.baseUrl}/${course.id}`, course, { headers: this.httpHeaders });
  }

  archive(id: number): Observable<Object> {
    return this.http.delete(`${this.baseUrl}/${id}`, { headers: this.httpHeaders });
  }

  addCourseWithAlert(course: Course): void {
    this.add(course).subscribe(
      (newCourse) => {
        Swal.fire('Course Added', 'The course has been added successfully', 'success');
      },
      (error) => {
        console.error('Error adding course:', error);
        Swal.fire('Error', 'Failed to add the course. Please try again later.', 'error');
      }

      
    );
  }
}
