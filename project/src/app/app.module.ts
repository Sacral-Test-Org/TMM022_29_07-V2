import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { PartMasterModule } from './features/part-master/part-master.module';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    PartMasterModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
