import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { LeaveHistoryComponent } from './leave-history.component';
import { NgxPaginationModule } from 'ngx-pagination';
import { LeavePendingService } from '../leave-pending.service';
import { HttpModule } from '@angular/http';
import { EmployeeService } from '../employee.service';
import { RouterTestingModule } from '@angular/router/testing';


describe('LeaveHistoryComponent', () => {
  let component: LeaveHistoryComponent;
  let fixture: ComponentFixture<LeaveHistoryComponent>;

  beforeEach(async(() => { 
    localStorage.setItem("empId","1");
    TestBed.configureTestingModule({ 
      schemas: [ CUSTOM_ELEMENTS_SCHEMA ],
      imports : [NgxPaginationModule,HttpModule, RouterTestingModule],
      declarations: [ LeaveHistoryComponent ], 
      providers : [LeavePendingService,EmployeeService]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LeaveHistoryComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });
});
