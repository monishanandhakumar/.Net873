import { Component, OnInit } from '@angular/core';
import { Products } from 'src/models/product.model';
import { ProductService } from 'src/services/productservice';

@Component({
  selector: 'app-cart',
  templateUrl: './cart.component.html',
  styleUrls: ['./cart.component.css']
})
export class CartComponent implements OnInit {

  products:Products[];
  grandTotal:number;
  //DI
  constructor(private proservice:ProductService) { 
    this.products=this.proservice.cart;
   // console.log(this.products.values)
  }
 
  //calaculate grand total
  ngDoCheck():void{
    this.grandTotal=0;
    this.products.forEach(element=>{
    this.grandTotal+=element.price*element.quantity; //i=i+a;
    } );
    }

    //calling RemoveItem service
    removeItem(prod:Products)
    {
      console.log("in removeiten in cart",prod);
      this.proservice.removeItemfromCartservice(prod);
    }
  ngOnInit() {
  }

}
