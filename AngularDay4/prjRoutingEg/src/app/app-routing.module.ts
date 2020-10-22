import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AdminComponent } from './admin/admin.component';
import { DepartmentsComponent } from './departments/departments.component';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import { PagenotfoundComponent } from './pagenotfound/pagenotfound.component';
import { ProductcrudComponent } from './productcrud/productcrud.component';
import { StockdetailsComponent } from './stockdetails/stockdetails.component';


const routes: Routes = [
  //default route
  {path:'',redirectTo:'home',pathMatch:'full'},
  {path:'home',component:HomeComponent},
  {path:'department',component: DepartmentsComponent},
  {path:'login',component:LoginComponent},
 {path:'admin',component:AdminComponent,
 children:[{
  path:'productcrud',component:ProductcrudComponent
},
{
path:'stock',component:StockdetailsComponent
}]
},
//Error page
{path:'**',component:PagenotfoundComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
