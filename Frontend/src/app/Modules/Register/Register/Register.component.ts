import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { NgxUiLoaderService } from 'ngx-ui-loader';
import { LoginService } from '../../Login/Sercvices/Login.service';
import { RegisterService } from '../Service/Register.service';
import { takeUntil } from 'rxjs/operators';
import { Subject } from 'rxjs';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-Register',
  templateUrl: './Register.component.html',
  styleUrls: ['./Register.component.css']
})
export class RegisterComponent implements OnInit {
  registerForm:FormGroup;
  formSubmitted:boolean=false;
  subscribe:Subject<boolean>=new Subject();
  get f(){return this.registerForm.controls;}
  constructor(
    private formBuilder:FormBuilder,
    private router:Router,
    private service:RegisterService,
    private ngxService: NgxUiLoaderService
  ) {
    this.registerForm=formBuilder.group({
      id:[0],
      firstName:['',Validators.required],
      lastName:['',Validators.required],
      email:['',Validators.required],
      userName:['',Validators.required],
      address:['',Validators.required],
      password:['',Validators.required],
      device:['123123213',Validators.required],
      browser:[this.detectBrowserName(),Validators.required],
      ipAddress:['12.12.121',Validators.required],
      status:[true,Validators.required]
    })
  }

  ngOnInit() {
  }

  onSubmit(){
    this.formSubmitted=true;
    if(this.registerForm.get('id')?.value==0){
      this.addUser();
    }
  }

  addUser(){
    if(this.registerForm.invalid){
      return;
    }
    this.registerForm.patchValue({id:0});
    this.service.addUser(this.registerForm.value).pipe(takeUntil(this.subscribe)).subscribe((res:any)=>{
      Swal.fire({
        position: 'center',
        icon: 'success',
        title: 'User Added Successfully',
        showConfirmButton: false,
        timer: 1500
      });
      this.formSubmitted=false;
      this.registerForm.patchValue({status:false});
      this.router.navigateByUrl("/Login");
    })
  }
  detectBrowserName() { 
    const agent = window.navigator.userAgent.toLowerCase()
    switch (true) {
      case agent.indexOf('edge') > -1:
        return 'edge';
      case agent.indexOf('opr') > -1 && !!(<any>window).opr:
        return 'opera';
      case agent.indexOf('chrome') > -1 && !!(<any>window).chrome:
        return 'chrome';
      case agent.indexOf('trident') > -1:
        return 'ie';
      case agent.indexOf('firefox') > -1:
        return 'firefox';
      case agent.indexOf('safari') > -1:
        return 'safari';
      default:
        return 'other';
    }
  }

}
