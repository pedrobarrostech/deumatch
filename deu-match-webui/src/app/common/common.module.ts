import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { RouterModule } from '@angular/router';

import { ProfessionalService } from '../common/_services/professional.service';
import { UserService } from '../common/_services/user.service';
import { PositionService } from '../common/_services/position.service';
import { AuthGuard } from '../common/_guards/auth.guard';
import { AuthenticationService } from '../common/_services/authentication.service';

const MODULES = [
  HttpModule,
  RouterModule,
  BrowserModule,
  FormsModule,
  ReactiveFormsModule
];

const PIPES = [
  // put pipes here
];

const COMPONENTS = [
  // put shared components here
];

const SERVICES = [
  ProfessionalService,
  PositionService,
  AuthGuard,
  UserService,
  AuthenticationService
];

@NgModule({
  imports: [
    ...MODULES
  ],
  declarations: [
    ...PIPES,
    ...COMPONENTS
  ],
  providers: [
    ...SERVICES
  ],
  exports: [
    ...MODULES,
    ...PIPES,
    ...COMPONENTS
  ]
})
export class CommonModule { }
