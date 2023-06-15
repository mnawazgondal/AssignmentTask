import { LoginComponent } from './login/login.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
  {
    path:"",
    pathMatch:"full",
    component:LoginComponent,
    data:{breadCrumb:"Login"}
  },
  {
    path:"Login",
    component:LoginComponent,
    data:{breadCrumb:"Login"}
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class LoginRoutingModule { }
