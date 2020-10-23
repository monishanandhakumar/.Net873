import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProductlistComponent } from './productlist/productlist.component';
import { ProductService } from 'src/services/productservice';
import { ProductcrudComponent } from './productcrud/productcrud.component';
import{FormsModule} from '@angular/forms';
import { ProductinfoComponent } from './productinfo/productinfo.component';
import { CartComponent } from './cart/cart.component'

@NgModule({
  declarations: [
    AppComponent,
    ProductlistComponent,
    ProductcrudComponent,
    ProductinfoComponent,
    CartComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [ProductService],
  bootstrap: [AppComponent]
})
export class AppModule { }
