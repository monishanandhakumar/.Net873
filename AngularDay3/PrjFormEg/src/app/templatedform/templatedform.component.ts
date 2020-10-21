import { Component, OnInit } from '@angular/core';
import {  NgForm } from '@angular/forms';
import{Customer} from 'src/models/customer.model'
//import { Customer } from 'src/models/customer.model';

@Component({
  selector: 'app-templatedform',
  templateUrl: './templatedform.component.html',
  styleUrls: ['./templatedform.component.css']
})
export class TemplatedformComponent implements OnInit {

  domain:string[]=["Angular","React","Node.js","Java"]
  cust:Customer;
  constructor() {
    this.cust={
      cname:"",
      age:0,
      phno:"",
      mailid:"",
      gender:"",
      newsletter:false,
    }
   }

   onRegister(customerform:NgForm)
   {
       console.log(customerform.value)
   }
  
  ngOnInit() {
  }

}
