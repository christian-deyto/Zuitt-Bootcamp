import { ComponentFixture, TestBed } from '@angular/core/testing';
import { CoursesComponent } from './courses.component';
import { SessionService } from '@services/session.service';

describe('CoursesComponent', () => {
  let component: CoursesComponent;
  let fixture: ComponentFixture<CoursesComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [CoursesComponent],
      providers: [SessionService] // Include your service dependencies here
    });

    fixture = TestBed.createComponent(CoursesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });

  it('should show "Add Course" button for admin users', () => {
    component.isAdmin = true;
    
    fixture.detectChanges();

    const addButton = fixture.debugElement.nativeElement.querySelector('.btn-success');
    expect(addButton).toBeTruthy();
  });

  it('should not show "Add Course" button for non-admin users', () => {
    component.isAdmin = false;

    fixture.detectChanges();

    const addButton = fixture.debugElement.nativeElement.querySelector('.btn-success');
    expect(addButton).toBeFalsy();
  });
});
