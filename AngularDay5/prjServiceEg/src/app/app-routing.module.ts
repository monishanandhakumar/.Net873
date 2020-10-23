import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CartComponent } from './cart/cart.component';
import { ProductcrudComponent } from './productcrud/productcrud.component';
import { ProductinfoComponent } from './productinfo/productinfo.component';
import { ProductlistComponent } from './productlist/productlist.component';


const routes: Routes = [
  {path:"productlist",component:ProductlistComponent},
  {
    path:"productcrud",component:ProductcrudComponent
  },
  {
    path:'productinfo/:id',component: ProductinfoComponent
  },
  {
    path:'cart',component:CartComponent

  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
