import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ManagerComponent } from './manager.component';
import { FormsModule } from '@angular/forms';
import { EmployeeService } from '../employee.service';
import { HttpModule } from '@angular/http';
import { of } from 'rxjs/observable/of';

describe('ManagerComponent', () => {
  let component: ManagerComponent;
  let fixture: ComponentFixture<ManagerComponent>;
  let employService : EmployeeService;

  beforeEach(async(() => { 
    localStorage.setItem("empMgrId","1");
    TestBed.configureTestingModule({ 
      imports: [
        FormsModule,HttpModule
      ],
      declarations: [ ManagerComponent ], 
      providers: [EmployeeService]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    employService = TestBed.get(EmployeeService);
    fixture = TestBed.createComponent(ManagerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should return a single user', () => {
    const userResponse =  {
      "empId":1000,
      "empFullName":"SANJANA KOLAGE",
      "empEmail":"SANJANAK@HEXAWARE.COM",
      "empMobileNo":"7768858666",
      "empDateOfJoining":"2016-05-20",
      "empDepartment":"HEXAVARSITY",
      "empMgrId":0,"empAvailLeavBal":26
    };
    let response;
    spyOn(employService, 'searchEmployee').and.returnValue( of (userResponse));

    employService.searchEmployee(2000).subscribe(res => {
      response = res;
    });

    expect(response).toEqual(userResponse);
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });
});
