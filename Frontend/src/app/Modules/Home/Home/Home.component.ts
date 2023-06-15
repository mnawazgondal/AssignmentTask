import { Component, OnInit } from '@angular/core';
import { HomeService } from '../Services/home.service';

@Component({
  selector: 'app-Home',
  templateUrl: './Home.component.html',
  styleUrls: ['./Home.component.css']
})
export class HomeComponent implements OnInit {
  id:any;
  balance: any;
  constructor(private service:HomeService) { }

  ngOnInit() {
   this.id =localStorage.getItem('Id');
   this.getBalance();
  }

  getBalance(){
    this.service.getBalance(this.id).subscribe((c:any)=>{
      console.log(c);
      localStorage.setItem("Balance",c);
      this.balance =c;
    })
  }

}
