import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { CommonModule } from './common/common.module';
import { HomeModule } from './home/home.module';
import { AppRoutingModule } from './app-routing.module';
import { LoginModule } from './login/login.module';
import { ProfessionalsModule } from './professionals/professionals.module';
import { ReportModule } from './report/report.module';
import { UsersModule } from './users/users.module';
import { NoContentModule } from './no-content/no-content.module';

@NgModule({
  declarations: [
    AppComponent
  ],
  bootstrap: [AppComponent],
  imports: [
    CommonModule,
    AppRoutingModule,
    HomeModule,
    ProfessionalsModule,
    LoginModule,
    ReportModule,
    UsersModule,
    NoContentModule
  ],
  providers: [
  ]
})
export class AppModule { }
