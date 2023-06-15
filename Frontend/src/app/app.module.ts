import { CommonModule, HashLocationStrategy, LocationStrategy } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { CUSTOM_ELEMENTS_SCHEMA, NgModule } from '@angular/core';
import { FormBuilder, FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { NgxSpinnerModule } from 'ngx-spinner';
import { TreeviewModule } from 'ngx-treeview';
import { NgxUiLoaderModule } from 'ngx-ui-loader';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BreadCrumbComponent } from './_Layouts/BreadCrumb/BreadCrumb.component';
import { FooterComponent } from './_Layouts/Footer/Footer.component';
import { HeaderComponent } from './_Layouts/Header/Header.component';
import { SideNavComponent } from './_Layouts/Side-Nav/Side-Nav.component';
import { SiteLayoutComponent } from './_Layouts/Site-Layout/Site-Layout.component';

@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    FooterComponent,
    BreadCrumbComponent,
    SideNavComponent,
    SiteLayoutComponent
  ],
  imports: [
    HttpClientModule,
    BrowserModule,
    AppRoutingModule,
    TreeviewModule.forRoot(),
    FormsModule,
    CommonModule,
    NgxUiLoaderModule.forRoot({  "bgsColor": "red",
    "bgsOpacity": 0.5,
    "bgsPosition": "bottom-right",
    "bgsSize": 60,
    "bgsType": "ball-spin-clockwise",
    "blur": 5,
    "delay": 0,
    "fastFadeOut": true,
    "fgsColor": "#ffffff",
    "fgsPosition": "center-center",
    "fgsSize": 60,
    "fgsType": "three-strings",
    "gap": 24,
    "logoPosition": "center-center",
    "logoSize": 120,
    "logoUrl": "",
    "masterLoaderId": "master",
    "overlayBorderRadius": "0",
    "overlayColor": "rgba(40, 40, 40, 0.8)",
    "pbColor": "red",
    "pbDirection": "ltr",
    "pbThickness": 3,
    "hasProgressBar": false,
    "text": "",
    "textColor": "#FFFFFF",
    "textPosition": "center-center",
    "maxTime": -1,
    "minTime": 300}),
  ],
  providers: [FormBuilder,
    {
      provide:LocationStrategy,
      useClass:HashLocationStrategy
    }],
  schemas: [ CUSTOM_ELEMENTS_SCHEMA ],
  bootstrap: [AppComponent]
})
export class AppModule { }
