import { TestBed, inject } from '@angular/core/testing';

import { LeavePendingService } from './leave-pending.service';
import { HttpModule } from '@angular/http';

describe('LeavePendingService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [
        HttpModule
      ],
      providers: [LeavePendingService]
    });
  });

  it('should be created', inject([LeavePendingService], (service: LeavePendingService) => {
    expect(service).toBeTruthy();
  }));
});
