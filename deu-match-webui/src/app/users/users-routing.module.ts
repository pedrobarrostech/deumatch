import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';

import { UsersComponent } from './users.component';
import { AuthGuard } from '../common/_guards/auth.guard';

@NgModule({
  imports: [
    RouterModule.forChild([
      { path: 'cadastrar', component: UsersComponent }
    ])
  ]
})
export class UsersRoutingModule { }
