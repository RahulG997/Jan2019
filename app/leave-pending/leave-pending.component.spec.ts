import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LeavePendingComponent } from './leave-pending.component';
import { SortdataPipe } from '../sortdata.pipe';
import { HttpModule } from '@angular/http';
import { LeavePendingService } from '../leave-pending.service';
import { EmployeeService } from '../employee.service';
import { RouterTestingModule } from '@angular/router/testing';

describe('LeavePendingComponent', () => {
  let component: LeavePendingComponent;
  let fixture: ComponentFixture<LeavePendingComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({ 
      imports: [
        HttpModule,RouterTestingModule
      ],
      declarations: [ LeavePendingComponent, SortdataPipe ], 
      providers: [LeavePendingService, EmployeeService]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LeavePendingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });
});
