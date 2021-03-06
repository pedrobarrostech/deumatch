import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';

import { ReportComponent } from './report.component';
import { AuthGuard } from '../common/_guards/auth.guard';

@NgModule({
  imports: [
    RouterModule.forChild([
      { path: 'buscar', component: ReportComponent , canActivate: [AuthGuard] }
    ])
  ]
})
export class ReportRoutingModule { }
