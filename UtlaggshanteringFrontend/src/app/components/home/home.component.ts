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

  //Inject service into constructor
  constructor(private readonly userExpenceService: UserexpenceService) { }

  //Create empty array
  expenses: any[] = []

  //Regex pattern
  numberPattern = /^\d+$/;

  //Value for pagination
  cp: number = 1;
  
  //Method for changing boolean
  toggleEdit(expense: UserExpense){
    expense.editable = true;
    console.log(expense.editable)
  }

  //Method for changing boolean
  closeEdit(expense: UserExpense){
    expense.editable = false;
    window.location.reload();
  }

  // Fetches list of EserExpences
  GetListOfUserExpenses(): void{
    this.userExpenceService.GetListOfUserExpenses()
    .subscribe({
      next: (response) => {
        //Adds response to expenses array
        this.expenses.push(response);
      },
      error:(error) => {
        //Console log error
        console.log(error);
      }
    })

  }


  //Method for updating expense
  EditExpense(body: UserExpense){
    this.userExpenceService.EditExpense(body);
    body.editable = false;
    window.location.reload();
  }

  ngOnInit(): void {
    //Call method to on init to load in list of expenses
    this.GetListOfUserExpenses()
  }

}
