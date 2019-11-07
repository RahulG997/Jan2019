import { TestBed, inject } from '@angular/core/testing';
import { TestMeService } from './test-me.service';
import {TestService} from './test.service';

describe('TestMeService', () => {
  let obj: TestMeService;

  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [TestMeService,TestService]
    });
    spyOn(TestService.prototype, 'getName').and.returnValue("Prasanna");
    spyOn(TestService.prototype, 'getTopic').and.returnValue('Angular 4');
  
    obj=TestBed.get(TestMeService);
  });

  
  it('should be created', inject([TestMeService], (service: TestMeService) => {
    expect(service).toBeTruthy();
  }));

  it('Should Display (Testing showInfo())',() => {
    expect(obj.showInfo()).toEqual("Name is Prasanna Taking Angular 4");
  });
});
