import { Injectable } from '@angular/core';
import { Professional } from '../_models/professional';
import { Http, Headers, Response, RequestOptions } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';

@Injectable()
export class PositionService {
  private url = 'http://localhost:5000/api/vagas/processar/';
  private token = 'Bearer ' + JSON.parse(localStorage.getItem('currentUser')).token;
  private headers = new Headers({ 'Content-Type': 'application/json' , 'Authorization': this.token });
  private options = new RequestOptions({ headers: this.headers });

  constructor(private http: Http) {
  }

  search (params: any): Observable<any> {
    const body = JSON.stringify(params);
    return this.http.post(this.url, body, this.options)
                    .map(this.extractData)
                    .catch(this.handleError);
  }

  private extractData(res: Response) {
    const body = res.json();
    return body.data || { };
  }

  private handleError (error: any) {
    const errMsg = (error.message) ? error.message : error.status ? `${error.status} - ${error.statusText}` : 'Server error';
    console.error(errMsg); // log to console instead
    return Observable.throw(errMsg);
  }

}
