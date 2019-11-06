import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MenuExComponent } from './menu-ex.component';

describe('MenuExComponent', () => {
  let component: MenuExComponent;
  let fixture: ComponentFixture<MenuExComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MenuExComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MenuExComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
