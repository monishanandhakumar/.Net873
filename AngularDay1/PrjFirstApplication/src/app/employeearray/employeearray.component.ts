import { Component, OnInit } from '@angular/core';

//Component directive
@Component({
  selector: 'app-employeearray',
  templateUrl: './employeearray.component.html',
  styleUrls: ['./employeearray.component.css']
})
export class EmployeearrayComponent implements OnInit {

   people:any[]=[
     {"name":"Sai","age":22,"dept":"HR"},
     {"name":"Ravi","age":25,"dept":"HR"},
     {"name":"Ammu","age":23,"dept":"Fianance"},
     {"name":"Banu","age":24,"dept":"Development"}

   ];


  constructor() { }


  ngOnInit() {
  }

}
