import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AuthGuardGuard } from './Auth/auth-guard.guard';
import { LoginComponent } from './Modules/Login/login/login.component';
import { SiteLayoutComponent } from './_Layouts/Site-Layout/Site-Layout.component';
import { RegisterComponent } from './Modules/Register/Register/Register.component';
import { HomeComponent } from './Modules/Home/Home/Home.component';

const routes: Routes = [
  {
    path:'',
    component:LoginComponent,
    data:{breadCrumb:"Login"},
    loadChildren:()=>import('../app/Modules/Login/login.module').then(m=>m.LoginModule)
  },
  {
    path:'Login',
    component:LoginComponent,
    data:{breadCrumb:"Login"},
    loadChildren:()=>import('../app/Modules/Login/login.module').then(m=>m.LoginModule)
  },
  {
    path:'Register',
    component:RegisterComponent,
    data:{breadCrumb:"Login"},
    loadChildren:()=>import('../app/Modules/Register/register.module').then(m=>m.RegisterModule)
  },
  {
    path:'Home',
    component:SiteLayoutComponent,
    canActivate:[AuthGuardGuard],
    data:{breadCrumb:"Home"},
    loadChildren:()=>import('../app/Modules/Home/home.module').then(m=>m.HomeModule)
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
