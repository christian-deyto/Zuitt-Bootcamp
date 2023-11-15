import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

import { Course } from '@models/course';
import { SessionService } from './session.service';


@Injectable({
  providedIn: 'root'
})
export class CourseService {

  private baseUrl: string = 'https://localhost:7289/api/courses'; 

  private httpHeaders: HttpHeaders = new HttpHeaders({
    'Authorization': `Bearer ${this.sessionService.getToken()}`
  })


  constructor(
    private http: HttpClient,
    private sessionService: SessionService
  ) { }

  getCourses(): Observable<Course[]> {
    return this.http.get<Course[]>(this.baseUrl);
  } 

  getOne(id: number): Observable<Object> {
    return this.http.get<Course[]>(`${this.baseUrl}/${id}`)
  };

  add(course: Course): void {}

  update(course: Course): Observable<Object> {
    return this.http.put(this.baseUrl + `/${course.id}`, course, {headers: this.httpHeaders});
  };

  archive(id: number): Observable<Object> {
    return this.http.delete(this.baseUrl + `/${id}`, {headers: this.httpHeaders});
  }



}
