import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http';
import { FormGroup, FormControl, Validators, FormBuilder } from '@angular/forms';

import { UserService } from '../common/_services/user.service';

@Component({
  selector: 'app-users',
  templateUrl: './users.template.html',
  styleUrls: ['./users.style.css']
})
export class UsersComponent implements OnInit {

  private users = [];
  private isLoading = true;

  private user = {};
  private isEditing = false;

  private addUserForm: FormGroup;
  private nome = new FormControl('', Validators.required);
  private email = new FormControl('', Validators.required);
  private password = new FormControl('', Validators.required);
  private confirmPassword = new FormControl('', Validators.required);
  private infoMsg = { body: '', type: 'info'};

  constructor(private http: Http,
              private _userService: UserService,
              private formBuilder: FormBuilder) { }

  ngOnInit() {
    this.addUserForm = this.formBuilder.group({
      nome: this.nome,
      email: this.email,
      password: this.password,
      confirmPassword: this.confirmPassword
    });

  }

  addUser() {
    this._userService.add(this.addUserForm.value).subscribe(
      res => {
        const newUser = res;
        this.users.push(newUser);
        this.addUserForm.reset();
        this.sendInfoMsg('Empresa adicionada com sucesso.', 'success');
      },
      error => console.log(error)
    );
  }

  enableEditing(user) {
    this.isEditing = true;
    this.user = user;
  }

  cancelEditing() {
    this.isEditing = false;
    this.user = {};
    this.sendInfoMsg('Edição cancelada.', 'warning');
  }

  editUser(user) {
    this._userService.update(user).subscribe(
      res => {
        this.isEditing = false;
        this.user = user;
        this.sendInfoMsg('Empresa editada com sucesso.', 'success');
      },
      error => console.log(error)
    );
  }

  sendInfoMsg(body, type, time = 3000) {
    this.infoMsg.body = body;
    this.infoMsg.type = type;
    window.setTimeout(() => this.infoMsg.body = '', time);
  }

}
