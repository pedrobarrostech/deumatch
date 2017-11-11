import { NgModule } from '@angular/core';
import { ProfessionalsComponent } from './professionals.component';
import { ProfessionalsRoutingModule } from './professionals-routing.module';
import { CommonModule } from '../common/common.module';

@NgModule({
  imports: [
    ProfessionalsRoutingModule,
    CommonModule
  ],
  declarations: [
    ProfessionalsComponent
  ]
})
export class ProfessionalsModule { }
