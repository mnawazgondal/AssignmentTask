import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { HomeComponent } from './Home/Home.component';
import { HomeRoutingModule } from './home.routing.module';
import { HomeService } from './Services/home.service';

@NgModule({
  declarations: [HomeComponent],
  imports: [
    HttpClientModule,
    ReactiveFormsModule,
    FormsModule,
    CommonModule,
    HomeRoutingModule
    ],
  providers: [HomeService],
  bootstrap: [],
})
export class HomeModule {}
