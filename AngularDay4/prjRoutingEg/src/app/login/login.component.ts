import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import {Router} from '@angular/router'

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  //to represent form group elements
  loginForm:FormGroup;
             //router helps for navigation
  constructor(private router:Router) {

    this.loginForm=new FormGroup({
      mailid:new FormControl(null,[Validators.required,Validators.email]),
      password:new FormControl(null,Validators.required)
    });


   }

   //Below get methods helps us to fetch mailid and password from login form
  get mailid()
  {
    return this.loginForm.get('mailid')
  }

  get password()
  {
    return this.loginForm.get('password')
  }
 err;
   doLogin()
   {
     
    if(this.mailid.value=="admin@gmail.com" && this.password.value=="admin")
    {
         this.router.navigate(['admin']);
       
       //  localStorage.setItem('email',this.mailid.value)
       sessionStorage.setItem('email',this.mailid.value)
    }
      else if(this.mailid.value=="anu@gmail.com" && this.password.value=="123")
       {
            this.router.navigate(['department']);
          
          //  localStorage.setItem('email',this.mailid.value)
          sessionStorage.setItem('email',this.mailid.value)
       }
       else
       {
         this.err="Invalid username or password!!";

       }
   }
  ngOnInit() {
  }

}
