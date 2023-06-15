import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { LoginComponent } from './login/login.component';
import { LoginRoutingModule } from './login.routing.module';
import { LoginService } from './Sercvices/Login.service';

@NgModule({
  declarations: [LoginComponent],
  imports: [
    HttpClientModule,
    ReactiveFormsModule,
    FormsModule,
    CommonModule,
    LoginRoutingModule
    ],
  providers: [LoginService],
  bootstrap: [],
})
export class LoginModule {}
