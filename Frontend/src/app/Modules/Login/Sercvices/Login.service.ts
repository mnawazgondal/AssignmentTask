
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class LoginService {
Directory:string ="users";
constructor(private http:HttpClient) { }

login(data:any){
  return this.http.post<any>(`${environment.ServiceUrl}${this.Directory}/Login`,data);
}
}
