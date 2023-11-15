import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouterModule, Routes } from '@angular/router';
import { FormsModule} from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { BannerComponent } from './components/banner/banner.component';
import { NavbarComponent } from './navbar/navbar.component';
import { HighlightComponent } from './highlight/highlight.component';
import { HomeComponent } from './pages/home/home.component';
import { LoginComponent } from './pages/login/login.component';
import { NotfoundcomponentComponent } from './pages/notfoundcomponent/notfoundcomponent.component';
import { RegisterComponent } from './pages/register/register.component';
import { CoursesComponent } from './pages/courses/courses.component';
import { CourseComponent } from './components/course/course.component';
import { EditCourseComponent } from './pages/edit-course/edit-course.component';
import { EnrollmentComponent } from './enrollment/enrollment.component';
import { AddCourseComponent } from './add-course/add-course.component';


const appRoutes: Routes = [
  {path: '', component: HomeComponent},
  {path: 'login', component:LoginComponent},
  {path: 'register', component:RegisterComponent},
  {path: 'courses', component:CoursesComponent},
  {path: 'edit-course/:id', component: EditCourseComponent},
  {path: 'add-course', component: AddCourseComponent},
  {path: '**', component:NotfoundcomponentComponent} 
  
]


@NgModule({
  declarations: [
    AppComponent,
    BannerComponent,
    NavbarComponent,
    HighlightComponent,
    HomeComponent,
    LoginComponent,
    NotfoundcomponentComponent,
    RegisterComponent,
    CourseComponent,
    CoursesComponent,
    EditCourseComponent,
    EnrollmentComponent,
    EditCourseComponent,
    AddCourseComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    RouterModule.forRoot(appRoutes)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
