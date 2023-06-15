import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class HomeService {
  Directory:string ="Users";
constructor(private http:HttpClient) { }

getBalance(userId:number){
  debugger

  var auth_token =localStorage.getItem('token');

  const headers = new HttpHeaders().set('Authorization', `Bearer ${auth_token}`);
  return this.http.get<any>(`${environment.ServiceUrl}${this.Directory}/balance?userId=${userId}`,{ headers: headers });
}

}
