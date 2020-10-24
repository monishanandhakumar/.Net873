import { Component ,OnInit} from '@angular/core';


@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title = 'Welcome to Learn Pipes ';
  employee:object={name:'Nandhini',age:24,gender:'female'}
  public todayDate: Date;  
  public amount: number;  

  public products: any;// this variable holds the list of products 
  public searchText: any;  

  ngOnInit(): void {  
   this.todayDate = new Date();  
   this.amount = 100; 
   this.products = [  
    { Id: 1, pname: "pen", price:10 },  
    { Id: 2, pname: "pencil", price:5 },  
    { Id: 3, pname: "paper", price:10 }  ,
    { Id: 4, pname: "note", price:10 },
    { Id: 5, pname: "bag", price:10 },
    { Id: 6, pname: "Rubber", price:10 }
]; 
  }  

DoCheck():void
{
 
}

add():number     //int add(){return 0;}
{
 return ;
}

name():string{ return ;}
}
