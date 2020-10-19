import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-datatype',
  templateUrl: './datatype.component.html',
  styleUrls: ['./datatype.component.css']
})
export class DatatypeComponent implements OnInit {

  //Declaring variables
 name:string="Sanmugan";
 age:number;
 hobbies:string[];
 marks:Array<number>;
 Istrue:boolean;
 student:object;
 tupleval:[string,number,boolean];
 dynamicvalue:any;

 picture="assets/images/ball.jpg";

 //Initilazing values for variables
  constructor() { 
    this.age=25;
    this.hobbies=["Playing","Singing"];
    this.marks=[89,90,78];
    this.Istrue=false;
    this.tupleval=["Sanmugam",25,true];
    this.student={fathername:"Kumar",City:"Pune"}
    this.dynamicvalue="Hi!!";
    this.dynamicvalue=true;
  }
  

  ngOnInit() {
  }

}
