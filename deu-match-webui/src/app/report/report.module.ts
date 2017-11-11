import { NgModule } from '@angular/core';
import { ReportComponent } from './report.component';
import { ReportRoutingModule } from './report-routing.module';
import { CommonModule } from '../common/common.module';
import { RatingModule } from 'primeng/primeng';

@NgModule({
  imports: [
    ReportRoutingModule,
    CommonModule,
    RatingModule
  ],
  declarations: [
    ReportComponent
  ]
})
export class ReportModule { }
