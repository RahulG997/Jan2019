import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'app';

  a : number;
  
  getDefault() {
    this.a=0;
  }

  getNewVal() {
    this.a=12;
  }
  
  msg="Prasanna taking Angular Training";

  a1 = {
    name: "Garima"
  };


  v1=12.5;
  v2=11.4;

  Stud = ["Shrisom", "Eldo", "Himanshu"];

  status=null;
  city="Chennai";

   arr1={a:12,b:13};
   arr2={a:12,b:13};

  getStatus() : boolean {
    return true;
  }

  getRes() {
    throw "hello";
  }

  typError() {
    throw new TypeError("This is Custom Error");
  }
}
