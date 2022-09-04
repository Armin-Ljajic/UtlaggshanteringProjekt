import { Component, OnInit } from '@angular/core';
import { map } from 'rxjs';
import { UserExpense } from 'src/app/models/Userexpense';
import { UserexpenceService } from 'src/app/services/userexpence.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  constructor(private readonly userExpenceService: UserexpenceService) { }
  expenses: any[] = []
  
  toggleEdit(expense: UserExpense){
    expense.editable = true;
  }

  closeEdit(expense: UserExpense){
    expense.editable = false;
    window.location.reload();
  }

  GetListOfUserExpenses(): void{
    this.userExpenceService.GetListOfUserExpenses()
    .subscribe({
      next: (response) => {
        this.expenses.push(response);
        console.log(this.expenses);
      },
      error:(error) => {
        console.log(error);
      }
    })

  }

  EditExpense(body: UserExpense){
    this.userExpenceService.EditExpense(body);
    body.editable = false;
    window.location.reload();
  }

  ngOnInit(): void {
    this.GetListOfUserExpenses()
  }

}
