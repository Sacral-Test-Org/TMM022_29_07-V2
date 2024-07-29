import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PartMasterComponent } from './features/part-master/part-master.component';

const routes: Routes = [
  { path: 'part-master', component: PartMasterComponent },
  { path: '', redirectTo: '/part-master', pathMatch: 'full' },
  // Add more routes here as needed
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
