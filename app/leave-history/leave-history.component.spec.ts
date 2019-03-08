import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { LeaveHistoryComponent } from './leave-history.component';
import { NgxPaginationModule } from 'ngx-pagination';
import { LeavePendingService } from '../leave-pending.service';
import { HttpModule } from '@angular/http';
import { of } from 'rxjs/observable/of';
import { EmployeeService } from '../employee.service';
import { RouterTestingModule } from '@angular/router/testing';

const leaveServiceStub = {
  searchLeaveHistory(empid) {
    console.log('came inside the stub');
    const emps = [
      {
      "leaId":1,
      "leaEmpId":1000,
      "leaNumberOfDays":2,
      "leaStartDate":"2019-03-04",
      "leaEndDate":"2019-03-05",
      "leaLeaveType":"EL",
      "leaStatus":"PENDING",
      "leaReason":"sick",
      "leaAppliedOn":"2019-02-05",
      "leaManagerComment":null
      },
      {
        "leaId":7,
        "leaEmpId":1000,
        "leaNumberOfDays":10,
        "leaStartDate":"2019-08-10",
        "leaEndDate":"2019-08-19",
        "leaLeaveType":"EL",
        "leaStatus":"APPROVED",
        "leaReason":"Sick",
        "leaAppliedOn":"2019-02-06",
        "leaManagerComment":null
      }
    ];
    return of( emps );
  }
};

describe('LeaveHistoryComponent', () => {
  let component: LeaveHistoryComponent;
  let fixture: ComponentFixture<LeaveHistoryComponent>;

  beforeEach(async(() => { 
    localStorage.setItem("empId","1");
    TestBed.configureTestingModule({ 
      schemas: [ CUSTOM_ELEMENTS_SCHEMA ],
      imports : [NgxPaginationModule,HttpModule, RouterTestingModule],
      declarations: [ LeaveHistoryComponent ], 
      // providers : [LeavePendingService,EmployeeService]
      providers: [{provide: LeavePendingService, 
        useValue: leaveServiceStub},EmployeeService]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LeaveHistoryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should render one employee record', async(() => {
    const fixture = TestBed.createComponent(LeaveHistoryComponent);
    fixture.detectChanges();
    fixture.whenStable().then(() => {
      fixture.detectChanges();
      const compiled = fixture.debugElement.nativeElement;
      expect(compiled.querySelectorAll('.employees tr').length).toBe(3);
    });
  }));

  
  it(`the employee id to be '1000'`, async(()=>{
    const fixture = TestBed.createComponent(LeaveHistoryComponent);
    const app = fixture.debugElement.componentInstance;
    app.ngOnInit();
    expect(app.lhistory[0].leaEmpId).toEqual(1000);
  }));

   
  it(`the employee leave id to be '1'`, async(()=>{
    const fixture = TestBed.createComponent(LeaveHistoryComponent);
    const app = fixture.debugElement.componentInstance;
    app.ngOnInit();
    expect(app.lhistory[0].leaId).toEqual(1);
  }));

  it(`the employee leaNumberOfDays id to be '2'`, async(()=>{
    const fixture = TestBed.createComponent(LeaveHistoryComponent);
    const app = fixture.debugElement.componentInstance;
    app.ngOnInit();
    expect(app.lhistory[0].leaNumberOfDays).toEqual(2);
  }));

  
  it(`the employee leaStartDate  to be '2019-03-04'`, async(()=>{
    const fixture = TestBed.createComponent(LeaveHistoryComponent);
    const app = fixture.debugElement.componentInstance;
    app.ngOnInit();
    expect(app.lhistory[0].leaStartDate).toEqual("2019-03-04");
  }));

  it(`the employee leaEndDate to be '2019-03-05'`, async(()=>{
    const fixture = TestBed.createComponent(LeaveHistoryComponent);
    const app = fixture.debugElement.componentInstance;
    app.ngOnInit();
    expect(app.lhistory[0].leaEndDate).toEqual("2019-03-05");
  }));

  it(`the employee leaLeaveType to be 'EL'`, async(()=>{
    const fixture = TestBed.createComponent(LeaveHistoryComponent);
    const app = fixture.debugElement.componentInstance;
    app.ngOnInit();
    expect(app.lhistory[0].leaLeaveType).toEqual("EL");
  }));

  it(`the employee leaStatus to be 'PENDING'`, async(()=>{
    const fixture = TestBed.createComponent(LeaveHistoryComponent);
    const app = fixture.debugElement.componentInstance;
    app.ngOnInit();
    expect(app.lhistory[0].leaStatus).toEqual("PENDING");
  }));

  it(`the employee leaReason to be 'sick'`, async(()=>{
    const fixture = TestBed.createComponent(LeaveHistoryComponent);
    const app = fixture.debugElement.componentInstance;
    app.ngOnInit();
    expect(app.lhistory[0].leaReason).toEqual("sick");
  }));

  it(`the employee leaAppliedOn to be '2019-02-05'`, async(()=>{
    const fixture = TestBed.createComponent(LeaveHistoryComponent);
    const app = fixture.debugElement.componentInstance;
    app.ngOnInit();
    expect(app.lhistory[0].leaAppliedOn).toEqual("2019-02-05");
  }));

  it(`the employee leaManagerComment to be 'null'`, async(()=>{
    const fixture = TestBed.createComponent(LeaveHistoryComponent);
    const app = fixture.debugElement.componentInstance;
    app.ngOnInit();
    expect(app.lhistory[0].leaManagerComment).toEqual(null);
  }));

  it('should be created', () => {
    expect(component).toBeTruthy();
  });
});
