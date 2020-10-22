import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { DepartmentsComponent } from './departments/departments.component';
import { LoginComponent } from './login/login.component';
import{ReactiveFormsModule} from '@angular/forms';
import { ProductcrudComponent } from './productcrud/productcrud.component';
import { StockdetailsComponent } from './stockdetails/stockdetails.component';
import { AdminComponent } from './admin/admin.component';
import { PagenotfoundComponent } from './pagenotfound/pagenotfound.component'

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    DepartmentsComponent,
    LoginComponent,
    ProductcrudComponent,
    StockdetailsComponent,
    AdminComponent,
    PagenotfoundComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
