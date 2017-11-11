import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http';
import { FormGroup, FormControl, Validators, FormBuilder } from '@angular/forms';

import { PositionService } from '../common/_services/position.service';

@Component({
  selector: 'app-report',
  templateUrl: './report.template.html',
  styleUrls: ['./report.style.css']
})
export class ReportComponent implements OnInit {

  private professionals = [];
  private isLoading = true;

  private professional = {};
  private isEditing = false;
  private empresaId;
  private ratingConstrucao: number;
  private ratingInovacao: number;
  private ratingVelocidade: number;
  private skills: string;
  private searchProfessionalForm: FormGroup;
  private nome = new FormControl('');
  private infoMsg = { body: '', type: 'info'};

  constructor(private http: Http,
              private _positionService: PositionService,
              private formBuilder: FormBuilder) { }
  ngOnInit() {
    this.searchProfessionalForm = this.formBuilder.group({
      nome: this.nome,
      ratingConstrucao: this.ratingConstrucao,
      ratingInovacao: this.ratingInovacao,
      ratingVelocidade: this.ratingVelocidade,
      skills: this.skills
    });

  }

  sliptSkills(params) {
   return params.skills.split(',').map(skill => ({ nome: skill }));
  }

  search() {
    const params = this.searchProfessionalForm.value;
    const skills = this.sliptSkills(this.searchProfessionalForm.value);
    params.skills = skills;
    this._positionService.search(params).subscribe(
      res => {
        this.professionals = res;
        this.isLoading = false;
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
