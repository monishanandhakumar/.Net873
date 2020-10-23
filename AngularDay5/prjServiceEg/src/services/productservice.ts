import { Injectable } from '@angular/core';
import { element } from 'protractor';
import { Products } from 'src/models/product.model';

@Injectable()
export class ProductService
{
    product:Products[];
    cart:Products[];
    constructor()
    {
        this.product=[
           {pid:1001,pname:'Pencil',price:5,quantity:100,info:"Good Quality",image:'assets/images/pencil.png'},
           {pid:1002,pname:'Bag',price:200,quantity:70,info:"New Arrival 10% offer",image:'assets/images/bag.jpg'},
           {pid:1003,pname:'Chocolate',price:50,quantity:50,info:"No offer",image:'assets/images/chocolate.jpg'},
           {pid:1004,pname:'Ball',price:100,quantity:25,info:"Limited Stock",image:'assets/images/ball1.jpg'}

        ];
        this.cart=[];
    }

   //fetching all the product information
    getProducts()
    {
        return this.product;
    }
    //by passing pid fetch the paricular product details

    getProductInfo(proid)
    {
        let productinfo;
        this.product.forEach(element=>{
            if(element.pid==proid)
            {
                productinfo=element;
            }
        });

        return productinfo
    }

    
    //adding to cart
  public addToCartService(product:Products)
  {
    //If the product already exist in cart adding quantity alone
    let flag=0;
    for (let index = 0; index <this.cart.length; index++) {
        if(this.cart[index].pid == product.pid)
        {
           flag = 1;
           this.cart[index].quantity++;
           break;
        }  
    }
  
    //If Product not exist in cart add the product to cart
    if(flag ==0)
    this.cart.push(product);

    //to reduce the original quantity in products array
for (let index = 0; index <this.product.length; index++) {
    if(this.product[index].pid == product.pid)
    {
        this.product[index].quantity--;
    }  
}
//below is the end of add to cart method
  }   




//Removing Item from Cart
  removeItemfromCartservice(prod)
  {
    console.log("service:remove item",prod);
    for(let i=0;i<this.cart.length;i++)
    {
      if(this.cart[i].pid==prod.pid)
      {
        
        if(prod.quantity>1)
        {
          this.cart[i].quantity--;
        }
        else if(prod.quantity==1)
        {
          this.cart.splice(i,1);
        }
      }
    }

    //incrementing quantity to the list
    for(let index=0;index<this.product.length;index++)
    {
      if(this.product[index].pid==prod.pid)
      {
        this.product[index].quantity++;
        console.log("after remove quantity"+this.product[index].quantity)
      }
    }

  }








   //Adding new Products
   addProduct(product:Products){
    console.log("inside service add Products");
    for (let index = 0; index < this.product.length; index++) {
        if(this.product[index].pid == product.pid)
        {
            return false;
        }  
    }
    this.product.push(product);
    return true;
}


 //Deleting Product

 deleteProduct(productid:number)
 {
     console.log("inside service delete Products:"+productid);

     
//Passing Id
     for (let index = 0; index < this.product.length; index++) {
         console.log("inside service for ");
         if(this.product[index].pid==productid)  //when particular product id not exist
         {
             console.log('service id:'+this.product[index].pid);
             this.product.splice(index,1);   //when particular product id  exist
             return true;
         }  
     }
     return false;


 }

}