import { Component, OnInit } from '@angular/core';
import { Products } from 'src/models/product.model';
import { ProductService } from 'src/services/productservice';

@Component({
  selector: 'app-productlist',
  templateUrl: './productlist.component.html',
  styleUrls: ['./productlist.component.css']
})
export class ProductlistComponent implements OnInit {
 
  // to fetch the data reutrn by  displayproductdetails
  pro:Products[];
             //Dependency injection
  constructor(private productservice:ProductService) { 

  }

  ngOnInit() {
    this.displayproductdetails();
  }

  //1 calling the getproducts method from productservice
  displayproductdetails()
  {
    this.pro=this.productservice.getProducts();
  }


  //equal to buy method
addToCart(pid)
{

  console.log(pid);
  //2
  //fetching the product info for the particular pid
  let product:Products
 product  = this.productservice.getProductInfo(pid);
  console.log("add to cart:",product)

  //object of products
  let myProduct = new Products();
  myProduct.pid = product.pid;
  myProduct.pname = product.pname;
  myProduct.price = product.price;
  myProduct.image = product.image;
  myProduct.quantity = 1;
  
  this.productservice.addToCartService(myProduct)
   
}

}
