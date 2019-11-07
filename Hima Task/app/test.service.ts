import { Injectable } from '@angular/core';

@Injectable()
export class TestService {

  getName() {
    return "Prasanna";
  }
  getTopic() {
    return "Angular 4";
  }
  constructor() { }

}
