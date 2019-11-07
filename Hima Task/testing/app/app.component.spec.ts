import { TestBed, async } from '@angular/core/testing';
import { AppComponent } from './app.component';
import { AuthService } from './AuthService';


describe('AppComponent', () => {
  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [
        AppComponent
      ],
    }).compileComponents();
  }));
  
  it('should create the app', async(() => {
    const fixture = TestBed.createComponent(AppComponent);
    const app = fixture.debugElement.componentInstance;
    expect(app).toBeTruthy();
  }));
  it(`should have as title 'app'`, async(() => {
    const fixture = TestBed.createComponent(AppComponent);
    const app = fixture.debugElement.componentInstance;
    expect(app.title).toEqual('app');
  }));

  it('should render title in a h1 tag', async(() => {
    const fixture = TestBed.createComponent(AppComponent);
    fixture.detectChanges(); 
    const compiled = fixture.debugElement.nativeElement;
    expect(compiled.querySelector('h1').textContent).toContain('Welcome to app!');
  }));

  it(`Should getStatus return true`, async(() => {
    const fixture = TestBed.createComponent(AppComponent);
    const app = fixture.debugElement.componentInstance;
    expect(app.getStatus()).toBe(true);
  }));

  it(`Should arr1 and arr2 both same`, async(() => {
    const fixture = TestBed.createComponent(AppComponent);
    const app = fixture.debugElement.componentInstance;
    expect(app.arr1).toEqual(app.arr2);
  }));

  it(`Should match with Regular expression`, async(() => {
    const fixture = TestBed.createComponent(AppComponent);
    const app = fixture.debugElement.componentInstance;
    expect(app.msg).toMatch(/Prasanna/);
    expect(app.msg).toMatch("Angular"); 
    expect(app.msg).not.toMatch(/Ram/);
  }));

  it(`Should Variable to be Defined`, async(() => {
    const fixture = TestBed.createComponent(AppComponent);
    const app = fixture.debugElement.componentInstance;
    expect(app.a1.name).toBeDefined();
  }));

  it(`Should Variable to be UnDefined`, async(() => {
    const fixture = TestBed.createComponent(AppComponent);
    const app = fixture.debugElement.componentInstance;
    expect(app.a1.gender).not.toBeDefined();
  }));

/*  it(`Should Status to be null`, async(() => {
    const fixture = TestBed.createComponent(AppComponent);
    const app = fixture.debugElement.componentInstance;
    expect(app.Status).toBeNull();
  })); */

  it(`Should City to be Not Null`, async(() => {
    const fixture = TestBed.createComponent(AppComponent);
    const app = fixture.debugElement.componentInstance;
    expect(app.City).not.toBeNull();
  }));

  it(`Should Stud Should Contain`, async(() => {
    const fixture = TestBed.createComponent(AppComponent);
    const app = fixture.debugElement.componentInstance;
    expect(app.Stud).toContain("Himanshu");
    expect(app.Stud).not.toContain("Prasanna");
  }));

  it(`Should v1 less than v2`, async(() => {
    const fixture = TestBed.createComponent(AppComponent);
    const app = fixture.debugElement.componentInstance;
    expect(app.v1).toBeGreaterThan(app.v2);
  }));


  it(`Should throw Error Message`, async(() => {
    const fixture = TestBed.createComponent(AppComponent);
    const app = fixture.debugElement.componentInstance;
    
    expect(app.getRes).toThrow("hello");
  })); 

  it(`Should throw Custom Error Message`, async(() => {
    const fixture = TestBed.createComponent(AppComponent);
    const app = fixture.debugElement.componentInstance;
    expect(app.typError).toThrowError("This is Custom Error");
    expect(app.typError).toThrowError(/Custom/);
    expect(app.typError).toThrowError(TypeError);
    expect(app.typError).toThrowError(TypeError,"This is Custom Error");
  }));

  describe('Service: Auth', () => {
    let service: AuthService;
  
    beforeEach(() => {  
      service = new AuthService();
    });
  
    afterEach(() => { 
      service = null;
      localStorage.removeItem('token');
    });

    it('should return true from isAuthenticated when there is a token', () => { 
      localStorage.setItem('token', '1234'); 
      expect(service.isAuthenticated()).toBeTruthy(); 
    });

    it('Should Returns Service Method (Hexaware) ', () => {
      
      expect(service.getName()).toEqual("Hexaware");
    });

  
  });
  

});
