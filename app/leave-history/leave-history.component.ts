import { Component, OnInit } from '@angular/core';
import { Leavehistory } from '../leavehistory';
import { Observable } from 'rxjs';
import { LeavehistoryService } from '../leavehistory.service';
import { LeavePendingService } from '../leave-pending.service';
import { Router } from '@angular/router';
import { LeavePending } from '../leave-pending';
import { Employee } from '../employee';
import { EmployeeService } from '../employee.service';

@Component({
  selector: 'app-leave-history',
  templateUrl: './leave-history.component.html',
  styleUrls: ['./leave-history.component.css']
})
export class LeaveHistoryComponent implements OnInit {
  
  page:number = 1;
  totalRec : number;
  // leavePending : Observable<LeavePending[]>;
  // leavePen 
  empId : number;
  empData : Observable<Employee[]>;
  leavehistory : Observable<Leavehistory[]>;
  lhistory:Leavehistory[] = [];
  applyLeave() {
    this._router.navigate(["/ApplyLeave"]);
  }
empno : number;
  constructor(private leavehistoryService : LeavePendingService, private employeeService : EmployeeService, private _router : Router) { 
    this.empno=parseInt(localStorage.getItem("empId"));
    this.leavehistory = leavehistoryService.searchLeaveHistory(this.empno);
    this.empData = employeeService.getEmployee();
    this.leavehistory.subscribe(result => { this.totalRec = result.length;})
  }

  ngOnInit() {
    this.leavehistoryService.searchLeaveHistory(this.empno).subscribe(res => {this.lhistory = res});
  }

}
