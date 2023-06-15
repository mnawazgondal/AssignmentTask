
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { RegisterComponent } from './Register/Register.component';

const routes: Routes = [
  {
    path:"",
    pathMatch:"full",
    component:RegisterComponent,
    data:{breadCrumb:"Login"}
  },
  {
    path:"Regsiter",
    component:RegisterComponent,
    data:{breadCrumb:"Login"}
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class RegisterRoutingModule { }
