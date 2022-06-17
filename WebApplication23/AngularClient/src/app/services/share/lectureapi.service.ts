import { Injectable } from '@angular/core';
import {HttpClient,HttpHeaders} from '@angular/common/http'
import { Observable, Subject } from 'rxjs';
import {Lecture,Languages} from '../../lecture'
import { CustomPromisify } from 'util';


@Injectable({
  providedIn: 'root'
})
export class CustomerApiService {
 

  private apiUrl= 'http://localhost:50418/';
  constructor( private http:HttpClient) { }
  getAllCustomers():Observable<Lecture[]>
  {
    return this.http.get<Lecture[]>(this.apiUrl+'/GetListLectures')
  }

  getAllLenguages():Observable<Languages[]>
  {
    return this.http.get<Languages[]>(this.apiUrl+'/GetListLenguages')
  }

}
