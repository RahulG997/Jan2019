import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { EmployeeComponent } from './employee.component';
import { FormsModule } from '@angular/forms';
// import { of } from 'rxjs';
import { of } from 'rxjs/observable/of';
import { FilterdataPipe } from '../filterdata.pipe';
import { HttpModule } from '@angular/http';
import { HttpClientTestingModule } from '@angular/common/http/testing';
import { EmployeeService } from '../employee.service';
import { RouterTestingModule } from '@angular/router/testing';

const userServiceStub = {
  getEmployee() {
    console.log('came inside the stub');
    const emps = [
      {
      "empId":1000,
      "empFullName":"SANJANA KOLAGE",
      "empEmail":"SANJANAK@HEXAWARE.COM",
      "empMobileNo":"7768858666",
      "empDateOfJoining":"2016-05-20",
      "empDepartment":"HEXAVARSITY",
      "empMgrId":0,
      "empAvailLeavBal":26
      },
      {
        "empId":2000,
        "empFullName":"BHASKAR GURANA",
        "empEmail":"BHASKARG@HEXAWARE.COM",
        "empMobileNo":"8555001572",
        "empDateOfJoining":"2018-10-20",
        "empDepartment":"HEXAVARSITY",
        "empMgrId":1000,
        "empAvailLeavBal":8
      }
    ];
    return of( emps );
  }
};

describe('EmployeeComponent', () => {
  let component: EmployeeComponent;
  let fixture: ComponentFixture<EmployeeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({ 
      imports: [
        FormsModule,HttpModule,RouterTestingModule,HttpClientTestingModule
      ],
      declarations: [ EmployeeComponent,FilterdataPipe ], 
      // providers: [EmployeeService]
      providers: [{provide: EmployeeService, 
        useValue: userServiceStub}]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EmployeeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it(`the name employee Id to be '1000'`, async(()=>{
    const fixture = TestBed.createComponent(EmployeeComponent);
    const app = fixture.debugElement.componentInstance;
    app.ngOnInit();
    expect(app.employees[0].empId).toEqual(1000);
  }));

  it(`the name employee to be 'SANJANA KOLAGE'`, async(()=>{
    const fixture = TestBed.createComponent(EmployeeComponent);
    const app = fixture.debugElement.componentInstance;
    app.ngOnInit();
    expect(app.employees[0].empFullName).toEqual('SANJANA KOLAGE');
  }));

  it(`the Email employee to be 'SANJANAK@HEXAWARE.COM'`, async(()=>{
    const fixture = TestBed.createComponent(EmployeeComponent);
    const app = fixture.debugElement.componentInstance;
    app.ngOnInit();
    expect(app.employees[0].empEmail).toEqual('SANJANAK@HEXAWARE.COM');
  }));

  it(`the MobileNo employee to be '7768858666'`, async(()=>{
    const fixture = TestBed.createComponent(EmployeeComponent);
    const app = fixture.debugElement.componentInstance;
    app.ngOnInit();
    expect(app.employees[0].empMobileNo).toEqual('7768858666');
  }));

  it(`the DateOfJoining employee to be '2016-05-20'`, async(()=>{
    const fixture = TestBed.createComponent(EmployeeComponent);
    const app = fixture.debugElement.componentInstance;
    app.ngOnInit();
    expect(app.employees[0].empDateOfJoining).toEqual('2016-05-20');
  }));

  it(`the Department employee to be 'HEXAVARSITY'`, async(()=>{
    const fixture = TestBed.createComponent(EmployeeComponent);
    const app = fixture.debugElement.componentInstance;
    app.ngOnInit();
    expect(app.employees[0].empDepartment).toEqual('HEXAVARSITY');
  }));

  it(`the ManagerId employee to be '0'`, async(()=>{
    const fixture = TestBed.createComponent(EmployeeComponent);
    const app = fixture.debugElement.componentInstance;
    app.ngOnInit();
    expect(app.employees[0].empMgrId).toEqual(0);
  }));

  
  it(`the Available Leave Bal employee to be '26'`, async(()=>{
    const fixture = TestBed.createComponent(EmployeeComponent);
    const app = fixture.debugElement.componentInstance;
    app.ngOnInit();
    expect(app.employees[0].empAvailLeavBal).toEqual(26);
  }));

  
  it('should render one employee record', async(() => {
    const fixture = TestBed.createComponent(EmployeeComponent);
    fixture.detectChanges();
    fixture.whenStable().then(() => {
      fixture.detectChanges();
      const compiled = fixture.debugElement.nativeElement;
      expect(compiled.querySelectorAll('.employees tr').length).toBe(2);
    });
  }));
  it('should be created', () => {
    expect(component).toBeTruthy();
  });
});
