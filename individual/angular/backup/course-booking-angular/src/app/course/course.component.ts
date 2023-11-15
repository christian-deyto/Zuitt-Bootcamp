import { Component, OnInit, Input } from '@angular/core';
import { Router } from '@angular/router';
import Swal from 'sweetalert2';

import { Course } from '@models/course';
import { CourseService } from '@services/course.service';
import { SessionService } from '@services/session.service';

@Component({
  selector: 'app-course',
  templateUrl: './course.component.html',
  styleUrls: ['./course.component.css']
})
export class CourseComponent implements OnInit {

  @Input() course!: Course;
  @Input() deleteFromView!: Function;

  isAdmin: boolean = false;
  hasToken: boolean = (localStorage.getItem('token') !== null);


  constructor(
    private courseService: CourseService,
    private sessionService: SessionService,
    private router: Router
  ) {
    this.isAdmin = sessionService.getIsAdmin();
  }

  ngOnInit(): void {
    
  }

  enroll(): void { };

  edit(): void { 
    this.router.navigate(['/edit-course/' + this.course.id])
  };

  archive(course: Course): void { 
    Swal.fire({
      title: 'Confirm Action',
      text: 'Do you really want to archive this course?',
      icon: 'warning'
    }).then((result) => {
      if(result.isConfirmed) {
        this.courseService.archive(this.course.id!).subscribe((response: Record<string, any>) => {
            Swal.fire('Archived Successfully', 'The course has been successfully archived.', 'success');
            this.deleteFromView(course);
        })
      }
    })
  };


}
