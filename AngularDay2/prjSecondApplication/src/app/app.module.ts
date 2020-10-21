import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { EventbindingComponent } from './eventbinding/eventbinding.component';
import{FormsModule} from '@angular/forms';
import { TwowaybindingComponent } from './twowaybinding/twowaybinding.component'

//decorator:metadata information:data about data
@NgModule({
  declarations: [  //contains list of view class components
    AppComponent, EventbindingComponent, TwowaybindingComponent
  ],
  imports: [  //imports required inbuild module 
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [], //dependency injection and service
  bootstrap: [AppComponent]
})
export class AppModule { }
