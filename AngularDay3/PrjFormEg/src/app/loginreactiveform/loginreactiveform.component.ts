import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-loginreactiveform',
  templateUrl: './loginreactiveform.component.html',
  styleUrls: ['./loginreactiveform.component.css']
})
export class LoginreactiveformComponent implements OnInit {
  //to represent form group elements
  loginForm:FormGroup;
  constructor() {

    this.loginForm=new FormGroup({
      mailid:new FormControl(null,[Validators.required,Validators.email]),
      password:new FormControl(null,Validators.required)
    });


   }

  ngOnInit() {
  }

}
