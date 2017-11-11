import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';

import { ProfessionalsComponent } from './professionals.component';
import { AuthGuard } from '../common/_guards/auth.guard';

@NgModule({
  imports: [
    RouterModule.forChild([
      { path: 'profissional', component: ProfessionalsComponent , canActivate: [AuthGuard] }
    ])
  ]
})
export class ProfessionalsRoutingModule { }
