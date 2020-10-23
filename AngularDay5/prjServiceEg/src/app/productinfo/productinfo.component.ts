import { Component, OnInit } from '@angular/core';
import { ProductService } from 'src/services/productservice';
import{ActivatedRoute,ParamMap} from '@angular/router'

@Component({
  selector: 'app-productinfo',
  templateUrl: './productinfo.component.html',
  styleUrls: ['./productinfo.component.css']
})
export class ProductinfoComponent implements OnInit {

  proid;
  selectedinfo;
  constructor(private proservice:ProductService,private route:ActivatedRoute) { }

  ngOnInit() :void{
    //getting id from url
  
    //getting id from route
    this.route.paramMap.subscribe((params:ParamMap) =>{
      this.proid=parseInt(params.get('id'));
      console.log(this.proid);
 
    });
    
    this.callSelectedProduct();
  }

callSelectedProduct()
{
 this.selectedinfo= this.proservice.getProductInfo(this.proid);
}

}
