import { Component, OnInit } from '@angular/core';
import { UserExpense } from 'src/app/models/Userexpense';
import { UserexpenceService } from 'src/app/services/userexpence.service';

@Component({
  selector: 'app-add-expense',
  templateUrl: './add-expense.component.html',
  styleUrls: ['./add-expense.component.css']
})
export class AddExpenseComponent implements OnInit {

  //Inject service into constructor
  constructor(private readonly userExpenseService: UserexpenceService) { }

  //Object of UserExpense created
  userExpense: UserExpense = {}
  
  //Regex pattern
  numberPattern = /^\d+$/;

  //Adds expense to list
  AddExpense(){
    this.userExpenseService.AddExpenseToList(this.userExpense)
    window.location.reload();
  }

  ngOnInit(): void {
  }

}
