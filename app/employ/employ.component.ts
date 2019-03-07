import { Component, OnInit } from '@angular/core';
import {Observable} from 'rxjs';
import { Employee } from'../employee';
import {EmployeeService} from '../employee.service';
import {Router} from '@angular/router';

@Component({
  selector: 'app-employ',
  templateUrl: './employ.component.html',
  styleUrls: ['./employ.component.css']
})
export class EmployComponent implements OnInit {

  employ : Observable<Employee>;
empno : number;
employee:Employee;
  constructor(private employeeService : EmployeeService) { 
    this.empno=parseInt(localStorage.getItem("empId"));
    this.employ = employeeService.searchEmployee(this.empno);
  }

  ngOnInit() { 
    this.employeeService.searchEmployee(this.empno).subscribe(c => this.employee = c); 
 //   alert(this.employee.empId);
  }

}