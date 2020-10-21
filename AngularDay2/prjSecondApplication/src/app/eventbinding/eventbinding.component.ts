import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventbinding',
  templateUrl: './eventbinding.component.html',
  styleUrls: ['./eventbinding.component.css']
})
export class EventbindingComponent implements OnInit {

  //Eg4
  like:number;
  //Eg5
  togglestar:boolean;
  clsName:string;
  constructor() { 
  //like :Eg4
  this.like=0;

  //Star:Eg5
  this.togglestar=false;
  this.clsName='glyphicon glyphicon-star-empty'
  }

  ngOnInit() {
  }
//Eg1
  welcomeMsg()
  {
    alert("Welcome All!!");
  }
  //Eg2
   fname;
  displayfullname(uname:HTMLInputElement)
  {
      this.fname=uname.value+"Selvi"
  }
//Eg3
  incrementedsalary:number;
  incrementSalary(sal:HTMLInputElement)
  {
   // console.log("inside ince sal",sal.value);
   this.incrementedsalary=parseInt(sal.value)+4000;
 //  console.log(this.incrementedsalary) ;
  }
//Eg4
  thumbsUp(){
      this.like+=1; //this.like=this.like+1
      
  }
  //Eg5
  changeStar()
  {
    this.togglestar=!this.togglestar;
    if(this.togglestar)
    {
      this.clsName="glyphicon glyphicon-star";
    }
      else
      {
        this.clsName="glyphicon glyphicon-star-empty";
      }
  }
}
