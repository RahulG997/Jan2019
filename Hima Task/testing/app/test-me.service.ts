import { Injectable } from '@angular/core';
import {TestService} from './test.service'
@Injectable()
export class TestMeService {

  constructor(private test : TestService) { }

  showInfo() {
    return "Name is "+this.test.getName() + " Taking " +this.test.getTopic();
  }
  
}
