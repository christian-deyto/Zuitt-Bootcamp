import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {
  hasToken: boolean = false;

  constructor() {}
  
  ngOnInit(): void {}

  logout(): void {
    console.log('Logout button has been clicked.')
  }

}
