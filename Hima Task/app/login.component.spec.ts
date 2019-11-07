import {TestBed, ComponentFixture, inject, async} from '@angular/core/testing';
import {LoginComponent, User} from './login.component';
import {Component, DebugElement} from "@angular/core";
import {By} from "@angular/platform-browser";


describe('Component: Login', () => {

  let component: LoginComponent;
  let fixture: ComponentFixture<LoginComponent>;
  let submitEl: DebugElement;
  let loginEl: DebugElement;
  let passwordEl: DebugElement;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [LoginComponent]
    });

    fixture = TestBed.createComponent(LoginComponent);

    component = fixture.componentInstance;

    submitEl = fixture.debugElement.query(By.css('button'));
    loginEl = fixture.debugElement.query(By.css('input[type=email]'));
    passwordEl = fixture.debugElement.query(By.css('input[type=password]'));
  });

  it('Setting enabled to false disabled the submit button', () => {
    component.enabled = false;
    fixture.detectChanges();
    expect(submitEl.nativeElement.disabled).toBeTruthy();
  });

  it('Setting enabled to true enables the submit button', () => {
    component.enabled = true;
    fixture.detectChanges();
    expect(submitEl.nativeElement.disabled).toBeFalsy();
  });

  it('Entering email and password emits loggedIn event', () => {
    let user: User;
    loginEl.nativeElement.value = "test@example.com";
    passwordEl.nativeElement.value = "123456";

    component.loggedIn.subscribe((value) => user = value);

    submitEl.triggerEventHandler('click', null);

    expect(user.email).toBe("test@example.com");
    expect(user.password).toBe("123456");
  });
});
