import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'PrjSecondApplication';

  people:any[]=[
    {"name":"Sai","age":22,"dept":"HR"},
    {"name":"Ezhil","age":27,"dept":"Sales"},
    {"name":"Ravi","age":25,"dept":"HR"},
    {"name":"Ammu","age":23,"dept":"Fianance"},
    {"name":"Banu","age":24,"dept":"Development"},
    {"name":"Linu","age":24,"dept":"Sales"}

  ];
}
