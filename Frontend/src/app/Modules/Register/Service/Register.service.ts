import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class RegisterService {
  UserDirectory: string = 'Users';
constructor(private http: HttpClient) { }

addUser(users:any){
  return this.http.post(`${environment.ServiceUrl}${this.UserDirectory}/AddUpdateUser`,users);
}

}
