import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { UserExpense } from '../models/Userexpense';
import { pipe, map } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class UserexpenceService {

  constructor(private readonly http: HttpClient) { }

  //API call to backend to fetch list of UserExpences
  public GetListOfUserExpenses(): Observable<UserExpense[]>{
   return this.http.get<UserExpense[]>('https://localhost:7085/api/UserExpense');
  }

  //API call to add expense to list
  public AddExpenseToList(body: UserExpense){
    this.http.post<any>('https://localhost:7085/api/UserExpense', body, {
      headers: new HttpHeaders({
        'Content-Type': 'application/json'
      })
    }).subscribe()
  }

  //API call to edit expense in list
  EditExpense(body: UserExpense){
    return this.http.put<UserExpense>(`https://localhost:7085/api/UserExpense`, body, {
      headers: new HttpHeaders({
        'Content-Type': 'application/json'
      })
    }).subscribe();
  }          
           

}
