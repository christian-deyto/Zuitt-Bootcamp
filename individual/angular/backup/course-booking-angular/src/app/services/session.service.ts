import { Injectable, Output, EventEmitter } from '@angular/core';

@Injectable({
  providedIn: 'root'
})

// We created this service using
// ng generate service services/session
export class SessionService {

  @Output() hasToken: EventEmitter<boolean> = new EventEmitter();

  constructor() {
      if(localStorage.getItem('token') !== null) {
        this.hasToken.emit(true);
      } else {
        this.hasToken.emit(false);
      }
   }

   getToken(): string {
      return localStorage.getItem('token')!;
   }

   getEmail(): string {
      return localStorage.getItem('email')!;
   }

   getIsAdmin(): boolean {
      return localStorage.getItem('isAdmin')! === 'true';
   }

   setToken(value: string): void {
      this.hasToken.emit(true);
      localStorage.setItem('token', value);
   }

  setEmail(value: string): void {
      localStorage.setItem('email', value);
  }   

  setIsAdmin(value: string): void {
    localStorage.setItem('isAdmin', value);
  }

  clear(): void {
    localStorage.clear();
    this.hasToken.emit(false);
  }


}
