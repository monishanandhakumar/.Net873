import { Component, OnInit } from '@angular/core';
//importing department.model.ts from models folder
import{Department} from '../models/department.model'
//import { Department } from '../models/department.model';

@Component({
  selector: 'app-cruddepartment',
  templateUrl: './cruddepartment.component.html',
  styleUrls: ['./cruddepartment.component.css']
})
export class CruddepartmentComponent implements OnInit {

  
   dept:Department[]=[
     {deptid:1001,dname:"UX",location:"Pune"},
     {deptid:1002,dname:"Development",location:"Pune"},
     {deptid:1003,dname:"Sales",location:"Mumbai"},
     {deptid:1004,dname:"HR",location:"Chennai"},
   ];

   getdeptinfo:any={};

   constructor() { }

   addDepartment()
   {
     this.dept.push(this.getdeptinfo);
     this.getdeptinfo={};

   }

   deleteDepartment(i)
   {
     console.log(i);
     this.dept.splice(i,1);
   }
      err;
   deleteDepartmentbyid(did:number)
   {
    for (let index = 0; index < this.dept.length; index++) {
      console.log("inside service for ",did);
      if(this.dept[index].deptid==did)  //when particular product id not exist
      {
          console.log('service id:'+this.dept[index].deptid);
          this.dept.splice(index,1);   //when particular product id  exist
          this.err="Record Deleted!!!"
      }  
      else
      {
        this.err="Record not deleted!!"
      }
    }
  
   }



  
  indexvalue;
   editDepartment(i)
   {
     this.getdeptinfo.deptid=this.dept[i].deptid;
     this.getdeptinfo.dname=this.dept[i].dname;
     this.getdeptinfo.location=this.dept[i].location;
     this.indexvalue=i;

   }
   upateDepartment()
   {
     let k=this.indexvalue;
     for(let i=0;i<this.dept.length;i++)
     {
       if(k==i)
       {
         this.dept[i]=this.getdeptinfo;
         this.getdeptinfo={};
       }
     }

   }

  ngOnInit() {
  }

}
