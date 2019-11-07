import { TestBed, inject } from '@angular/core/testing';

import { TestService } from './test.service';

describe('TestService', () => {
let obj=new TestService();

  beforeEach(() => {
    //let obj=new TestService();
    TestBed.configureTestingModule({
      providers: [TestService]
    });
  
  });

  it('should be created', inject([TestService], (service: TestService) => {
    expect(service).toBeTruthy();
  }));

  it('should getName() return Prasanna', () => {
    expect(obj.getName()).toEqual("Prasanna");
  });
  it('should getToipic() return Angular 4', () => {
    expect(obj.getTopic()).toEqual("Angular 4");
  });

});
