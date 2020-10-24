import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
//     classname in usertitle.pipe.ts
import{UserTitlePipe} from './usertitle.pipe'

import{FormsModule} from '@angular/forms'
import{ProductFilterPipe} from './productfilter.pipe'

@NgModule({
  declarations: [
    AppComponent,
    UserTitlePipe,
    ProductFilterPipe
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
