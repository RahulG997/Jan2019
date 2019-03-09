import { Component, OnInit } from '@angular/core';
import {Observable} from 'rxjs';
import { Employee } from'../employee';
import {EmployeeService} from '../employee.service';
import 'rxjs/add/operator/toPromise';
import {Router} from '@angular/router';
import { applySourceSpanToStatementIfNeeded } from '@angular/compiler/src/output/output_ast';

@Component({
  selector: 'app-employ',
  templateUrl: './employ.component.html',
  styleUrls: ['./employ.component.css']
})
export class EmployComponent implements OnInit {

  employ : Observable<Employee>;
  eno : number;
empno : number;
employee : Employee;
  constructor(private employeeService : EmployeeService) { 
    this.empno=parseInt(localStorage.getItem("empId"));
    this.employ = employeeService.searchEmployee(this.empno);  
    alert("Constructor ");
    //this.employee = new Employee();
  }
 

  ngOnInit() { 
    this.employeeService.searchEmployee(this.eno).subscribe(res => this.employee = res);
  }

}