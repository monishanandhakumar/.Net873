import { Pipe } from "@angular/core";  
import { PipeTransform } from "@angular/core";  
  
@Pipe({  
    name: 'productfilterpipe' //name of the pipe  
  
})  
// This custom pipe implements the PipeTransform interface  
// as you can see in below code I have provided the custom implementation to the transform method to filter the record   
//based on the character typed in the search textbox  
export class ProductFilterPipe implements PipeTransform {  
    transform(products: any, searchText: any) {  
        if (searchText)  
            return products.filter(x=>x.pname.toLowerCase().startsWith(searchText.toLowerCase()));
              
        return products;  
    }  
  
}  
