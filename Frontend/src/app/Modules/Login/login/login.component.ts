import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { NgxUiLoaderService } from "ngx-ui-loader";
import Swal from 'sweetalert2';
import { LoginService } from '../Sercvices/Login.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  loginForm:FormGroup;
  formSubmitted:boolean=false;
  get f(){return this.loginForm.controls;}
  constructor(
    private formBuilder:FormBuilder,
    private loginService:LoginService,
    private router:Router,
    private ngxService: NgxUiLoaderService
    ) {
    this.loginForm=formBuilder.group({
      Email:['',Validators.required],
      Password:['',Validators.required]
    })
   }

  ngOnInit() {
    if(localStorage.getItem('token')!=null){
      this.router.navigateByUrl('/Home');
    }
  }
  onSubmit(){
    this.formSubmitted=true;
    if(this.loginForm.valid){
      this.ngxService.start();
      this.loginService.login(this.loginForm.value).subscribe((res:any)=>{
        localStorage.setItem('token',res.token);
        localStorage.setItem('Id',res.id);
        localStorage.setItem('UserName', res.userName);//this.model.email));
          Swal.fire({
            position: 'center',
            icon: 'success',
            title: 'Login Successfull',
            showConfirmButton: false,
            timer: 1500
          });
          this.ngxService.stop();
          this.router.navigateByUrl('/Home');
      },error=>{
        if(error.status==404){
          Swal.fire({
            icon: 'error',
            text: 'Not Authorized!',
          });
          this.ngxService.stop();
        }
      });
    }else{
      return;
    }

  }
}
