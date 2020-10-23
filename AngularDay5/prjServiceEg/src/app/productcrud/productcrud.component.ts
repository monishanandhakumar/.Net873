import { Component, OnInit } from '@angular/core';
import { Products } from 'src/models/product.model';
import { ProductService } from 'src/services/productservice';

@Component({
  selector: 'app-productcrud',
  templateUrl: './productcrud.component.html',
  styleUrls: ['./productcrud.component.css']
})
export class ProductcrudComponent implements OnInit {
  pro:Products[];

  createProduct:Products;
  message;
  constructor(private proservice:ProductService)
   { 
     //adding product 
   this.createProduct=new Products();
   }

  ngOnInit() {
    this.fetchproductdetails()
  }

 fetchproductdetails()
  {
    this.pro=this.proservice.getProducts();
  }

  
  //Adding Products details to array in service - Calling addProduct method from Service

addProducts()
{
  console.log("inside productclient add Products");
  if( this.proservice.addProduct(this.createProduct))
  {

   this.message='Product Added!!!';

  }
  else{
    this.message='Product Not Added!! ProductId Exists or Some other Error please check !!!';

  }
 
}
//
deleteProducts(id)
{
  console.log('client:'+id);
  if(this.proservice.deleteProduct(id))
  {
    this.message='Product Deleted!!'
  }
  else{
    this.message='Product not deleted!!'
  }
}



 }






