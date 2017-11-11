import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

import { AuthenticationService } from '../common/_services/authentication.service';

@Component({
    templateUrl: './login.component.html',
    styleUrls: [ './login.style.css' ]
})

export class LoginComponent implements OnInit {
    model: any = {};
    loading = false;
    error = '';

    constructor(
        private router: Router,
        private _authenticationService: AuthenticationService) { }

    ngOnInit() {
        // reset login status
        this._authenticationService.logout();
    }

    login() {
        this.loading = true;
        this._authenticationService.login(this.model.email, this.model.password)
            .subscribe(result => {
                if (result === true) {
                    this.router.navigate(['/']);
                } else {
                    this.error = 'E-mail ou senha estão incorretos';
                    this.loading = false;
                }
            });
    }
}
