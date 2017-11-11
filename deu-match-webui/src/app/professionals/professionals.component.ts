import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http';
import { FormGroup, FormControl, Validators, FormBuilder } from '@angular/forms';

import { ProfessionalService } from '../common/_services/professional.service';

@Component({
  selector: 'app-professionals',
  templateUrl: './professionals.template.html',
  styleUrls: ['./professionals.style.css']
})
export class ProfessionalsComponent implements OnInit {

  private professionals = [];
  private isLoading = true;

  private professional = {};
  private isEditing = false;

  private addProfessionalForm: FormGroup;
  private name = new FormControl('', Validators.required);
  private lastName = new FormControl('', Validators.required);
  private rg = new FormControl('', Validators.required);
  private cpf = new FormControl('', Validators.required);
  private maritalStatus = new FormControl('', Validators.required);
  private sex = new FormControl('', Validators.required);
  private address = new FormControl('', Validators.required);
  private city = new FormControl('', Validators.required);
  private state = new FormControl('', Validators.required);
  private phone = new FormControl('', Validators.required);
  private facebook = new FormControl('', Validators.required);
  private email = new FormControl('', Validators.required);
  private birthday = new FormControl('', Validators.required);
  private info = new FormControl('', Validators.required);
  private infoMsg = { body: '', type: 'info'};

  constructor(private http: Http,
              private _professionalService: ProfessionalService,
              private formBuilder: FormBuilder) { }

  ngOnInit() {

    this.addProfessionalForm = this.formBuilder.group({
      name: this.name,
      lastName: this.lastName,
      rg: this.rg,
      cpf: this.cpf,
      maritalStatus: this.maritalStatus,
      sex: this.sex,
      address: this.address,
      city: this.city,
      state: this.state,
      phone: this.phone,
      facebook: this.facebook,
      email: this.email,
      birthday: this.birthday,
      info: this.info
    });

  }

  addProfessional() {
    this._professionalService.add(this.addProfessionalForm.value).subscribe(
      res => {
        const newProfessional = res;
        this.professionals.push(newProfessional);
        this.addProfessionalForm.reset();
        this.sendInfoMsg('Profissional adicionado com sucesso.', 'success');
      },
      error => console.log(error)
    );
  }

  enableEditing(professional) {
    this.isEditing = true;
    this.professional = professional;
  }

  cancelEditing() {
    this.isEditing = false;
    this.professional = {};
    this.sendInfoMsg('Edição cancelada.', 'warning');
  }

  editProfessional(professional) {
    this._professionalService.update(professional).subscribe(
      res => {
        this.isEditing = false;
        this.professional = professional;
        this.sendInfoMsg('Profissional editado com sucesso.', 'success');
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
