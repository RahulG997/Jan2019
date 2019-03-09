import { TestBed, inject } from '@angular/core/testing';

import { LeavehistoryService } from './leavehistory.service';
import { HttpModule } from '@angular/http';

describe('LeavehistoryService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({ 
      imports: [
        HttpModule
      ],
      providers: [LeavehistoryService]
    });
  });

  it('should be created', inject([LeavehistoryService], (service: LeavehistoryService) => {
    expect(service).toBeTruthy();
  }));
});
