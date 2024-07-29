import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';
import { PartMasterComponent } from './part-master.component';
import { PartMasterService } from '../../core/services/part-master.service';

@NgModule({
  declarations: [
    PartMasterComponent
  ],
  imports: [
    CommonModule,
    FormsModule
  ],
  providers: [
    PartMasterService
  ]
})
export class PartMasterModule { }
