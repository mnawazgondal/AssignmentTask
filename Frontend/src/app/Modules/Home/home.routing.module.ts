
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './Home/Home.component';

const routes: Routes = [
  {
    path:"",
    pathMatch:"full",
    component:HomeComponent,
    data:{breadCrumb:"Home"}
  },
  {
    path:"Home",
    component:HomeComponent,
    data:{breadCrumb:"Home"}
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class HomeRoutingModule { }
