import { Component } from '@angular/core';
import { EnrollmentService } from '@services/enrollment.service';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-enrollment',
  templateUrl: './enrollment.component.html',
  styleUrls: ['./enrollment.component.css']
})
export class EnrollmentComponent {
  isUserEnrolled: boolean = false; 

  constructor(private enrollmentService: EnrollmentService) {}

  enrollCourse(courseId: number) {
    if (this.isUserEnrolled) {
      Swal.fire('Enrollment Cancelled', 'You are already enrolled in this course', 'error');
    } else {
      this.enrollmentService.enrollInCourse(courseId).subscribe(
        () => {
          // Handle successful enrollment response
          this.isUserEnrolled = true;
          Swal.fire('Enrollment Successful', 'Enjoy the course!', 'success');
        },
        (error) => {
          // Handle error during enrollment
          Swal.fire('Enrollment Error', 'An error occurred during enrollment', 'error');
        }
      );
    }
  }
}
