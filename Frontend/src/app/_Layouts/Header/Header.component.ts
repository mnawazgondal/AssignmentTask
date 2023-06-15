import { Router } from '@angular/router';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-Header',
  templateUrl: './Header.component.html',
  styleUrls: ['./Header.component.css']
})
export class HeaderComponent implements OnInit {

  constructor(private router:Router) { }
  userName:any;
  balance:any;
  ngOnInit() {
     this.userName=localStorage.getItem('UserName');
     this.balance=localStorage.getItem('Balance');
  }

  logout(){
    localStorage.clear();
    this.router.navigateByUrl('/Login');
  }

}
