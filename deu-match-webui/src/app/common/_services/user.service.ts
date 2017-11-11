import { Injectable } from '@angular/core';
import { User } from '../_models/user';
import { Http, Headers, Response, RequestOptions } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';

@Injectable()
export class UserService {
  private url = 'http://localhost:5000/api/registrar/';
  private token = 'Bearer ' + JSON.parse(localStorage.getItem('currentUser')).token;
  private headers = new Headers({ 'Content-Type': 'application/json' , 'Authorization': this.token });
  private options = new RequestOptions({ headers: this.headers });

  constructor(private http: Http) {
  }

  add (user: User): Observable<User> {
    const body = JSON.stringify(user);
    return this.http.post(this.url, body, this.options)
                    .map(this.extractData)
                    .catch(this.handleError);
  }

  update(user: User) {
    const body = JSON.stringify(user);
    return this.http.put(this.url + user.id, body, this.options)
                    .map((res: Response) => res.json())
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
