import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { RegisterComponent } from './Register/Register.component';
import { RegisterRoutingModule } from './register.routing.module';
import { RegisterService } from './Service/Register.service';
@NgModule({
  declarations: [RegisterComponent],
  imports: [
    HttpClientModule,
    ReactiveFormsModule,
    FormsModule,
    CommonModule,
    RegisterRoutingModule
    ],
  providers: [RegisterService],
  bootstrap: [],
})
export class RegisterModule {}
