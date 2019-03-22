import { AppPage } from './app.po';
import { browser,by, logging, element } from 'protractor';



// describe('Protractor Demo App', function() {
//   it('should add one and two', function() {
//     browser.get('http://juliemr.github.io/protractor-demo/');
//     element(by.model('first')).sendKeys(1);
//     element(by.model('second')).sendKeys(2);
//     element(by.id('gobutton')).click();
//     expect(element(by.binding('latest')).getText()).toEqual('3');
//   });
// });

// describe('Protractor Demo App', function() {
//   it('should add one and two', function() {
//     browser.get('http://juliemr.github.io/protractor-demo/');
//     element(by.model('first')).sendKeys(3);
//     element(by.model('second')).sendKeys(2);
//     element(by.xpath(".//option[@value= 'SUBTRACTION']")).click();
//     element(by.id('gobutton')).click();
//     expect(element(by.binding('latest')).getText()).toEqual('1');
//   });
// });

// describe('Protractor Demo App', function() {
//   it('should multiply one and two', function() {
//     browser.get('http://juliemr.github.io/protractor-demo/');
//     element(by.model('first')).sendKeys(5);
//     element(by.model('second')).sendKeys(5);
//     element(by.model('operator')).click();
//     element(by.xpath(".//option[@value= 'MULTIPLICATION']")).click();
//     element(by.id('gobutton')).click();
//     expect(element(by.binding('latest')).getText()).toEqual('25');
//   });
// });

// describe('Protractor Demo App', function() {
//   it('should divide ten by two', function() {
//     browser.get('http://juliemr.github.io/protractor-demo/');
//     element(by.model('first')).sendKeys(10);
//     element(by.model('second')).sendKeys(2);
//     element(by.model('operator')).click();
//     element(by.xpath(".//option[@value= 'DIVISION']")).click();
//     element(by.id('gobutton')).click();
//     expect(element(by.binding('latest')).getText()).toEqual('5');
//   });
// });

// describe('Protractor Demo App', function() {
//   it('should multiply one and two', function() {
//     browser.get('http://juliemr.github.io/protractor-demo/');
//     element(by.model('first')).sendKeys(10);
//     element(by.model('second')).sendKeys(3);
//     element(by.model('operator')).click();
//     element(by.xpath(".//option[@value= 'MODULO']")).click();
//     element(by.id('gobutton')).click();
//     expect(element(by.binding('latest')).getText()).toEqual('1');
//   });
// });

// describe('Protractor Demo App', function() {
//   it('should have a title', function() {
//     browser.get('http://juliemr.github.io/protractor-demo/');
//     expect(browser.getTitle()).toEqual('Super Calculator');
//   });
// });

// describe('Protractor Demo App', function() {
//   it('should have Google title title', function() {
//     browser.ignoreSynchronization = true;
//     browser.get('https://www.google.com/');
//     expect(browser.getTitle()).toEqual('Google');
//   });
// });

// describe('Protractor Demo App', function() {
//   it('should Click on Search Button Google title title', function() {
//     browser.ignoreSynchronization = true;
//     browser.get('https://www.google.com/');
//     element(by.name('q')).sendKeys("Sahil");
//     element(by.name('btnK')).click();
//   });
// });

// describe('Protractor Demo App', function() { 
 
//   it('should login', function() {
//     // browser.ignoreSynchronization = true;
//     browser.get('http://localhost:4200');
//     element(by.name('username')).sendKeys("2000");
//     browser.sleep(5000).then(function() {
//       console.log('waited 5 seconds');
//     });
//     element(by.name('password')).sendKeys("123");
//     browser.sleep(5000).then(function() {
//       console.log('waited 5 seconds');
//     });
//     element(by.name('submit')).click();
//     browser.sleep(5000).then(function() {
//       console.log('waited 5 seconds');
//     });
//   });
// });


describe('Protractor Demo App', function() { 
  
   
  // it('should ApplyLeave', function() { 
    
     
  //     // browser.ignoreSynchronization = true;
  //     browser.get('http://localhost:4200/dashboard/applyLeave');
  //   });

   xit('should login', function() { 
   
    
     // browser.ignoreSynchronization = true;

     browser.get('http://localhost:4200/login');
     element(by.name('username')).sendKeys("2000");
     browser.sleep(5000).then(function() {
       console.log('waited 5 seconds');
     });
     element(by.name('password')).sendKeys("123");
     browser.sleep(5000).then(function() {
       console.log('waited 5 seconds');
     });
     element(by.name('submit')).click();
     browser.sleep(5000).then(function() {
       console.log('waited 5 seconds');
     });  
    //  element(by.cssContainingText("a","Apply Leave")).getAttribute('href')
   });

   
 });

 describe('Protractor Demo App', function() { 
  
   
  // it('should ApplyLeave', function() { 
    
     
  //     // browser.ignoreSynchronization = true;
  //     browser.get('http://localhost:4200/dashboard/applyLeave');
  //   });

  it('should ApplyLeave for Not For past Date ', function() { 
    
     
      browser.ignoreSynchronization = true;
      browser.get('http://localhost:4200');
 
      browser.sleep(1000).then(function() {
        console.log('waited 2 seconds');
      });  
      element(by.id('row3')).click();
      browser.sleep(1000).then(function() {
        console.log('waited 2 seconds');
      });  

      element(by.name('password')).sendKeys("123");
      browser.sleep(2000).then(function() {
        console.log('waited 2 seconds');
      });
      element(by.name('submit')).click();
      browser.sleep(2000).then(function() {
        console.log('waited 2 seconds');
      });  
      element(by.id('applyLeave')).click();
      browser.sleep(2000).then(function() {
       console.log('waited 2 seconds');
     });  
 
     element(by.id('leaStDate')).sendKeys("03/07/2019");
     browser.sleep(2000).then(function() {
      console.log('waited 2 seconds');
      });  
      element(by.id('leaEndDate')).sendKeys("03/07/2019");
      browser.sleep(2000).then(function() {
       console.log('waited 2 seconds');
       });  
       element(by.id('leaReas')).sendKeys("Sick");
       browser.sleep(2000).then(function() {
        console.log('waited 2 seconds');
        });  
        element(by.id('leaType')).sendKeys("EL");
        browser.sleep(2000).then(function() {
         console.log('waited 2 seconds');
         });  
 
         element(by.name('Apply')).click();
 
         browser.sleep(2000).then(function() {
           console.log('waited 2 seconds');
           });  
 
         expect(element(by.name('result')).getText()).toEqual('start date is less than current date');
     
  });


  it('should ApplyLeave for StatDate For Saturday ', function() { 
    
     
      browser.ignoreSynchronization = true;
      browser.get('http://localhost:4200');
 
      browser.sleep(1000).then(function() {
        console.log('waited 2 seconds');
      });  
      element(by.id('row3')).click();
      browser.sleep(1000).then(function() {
        console.log('waited 2 seconds');
      });  

      element(by.name('password')).sendKeys("123");
      browser.sleep(2000).then(function() {
        console.log('waited 2 seconds');
      });
      element(by.name('submit')).click();
      browser.sleep(2000).then(function() {
        console.log('waited 2 seconds');
      });  
      element(by.id('applyLeave')).click();
      browser.sleep(2000).then(function() {
       console.log('waited 2 seconds');
     });  
 
     element(by.id('leaStDate')).sendKeys("03/03/2019");
     browser.sleep(2000).then(function() {
      console.log('waited 2 seconds');
      });  
      element(by.id('leaEndDate')).sendKeys("03/05/2019");
      browser.sleep(2000).then(function() {
       console.log('waited 2 seconds');
       });  
       element(by.id('leaReas')).sendKeys("Sick");
       browser.sleep(2000).then(function() {
        console.log('waited 2 seconds');
        });  
        element(by.id('leaType')).sendKeys("EL");
        browser.sleep(2000).then(function() {
         console.log('waited 2 seconds');
         });  
 
         element(by.name('Apply')).click();
 
         browser.sleep(2000).then(function() {
           console.log('waited 2 seconds');
           });  
 
         expect(element(by.name('result')).getText()).toEqual('StartDate cannot be Saturday or sunday...');
     
  });

  it('should ApplyLeave Check For Saturday ', function() { 
    
     
      browser.ignoreSynchronization = true;
      browser.get('http://localhost:4200');
 
      browser.sleep(1000).then(function() {
        console.log('waited 2 seconds');
      });  
      element(by.id('row2')).click();
      browser.sleep(1000).then(function() {
        console.log('waited 2 seconds');
      });  

      element(by.name('password')).sendKeys("123");
      browser.sleep(2000).then(function() {
        console.log('waited 2 seconds');
      });
      element(by.name('submit')).click();
      browser.sleep(2000).then(function() {
        console.log('waited 2 seconds');
      });  
      element(by.id('applyLeave')).click();
      browser.sleep(2000).then(function() {
       console.log('waited 2 seconds');
     });  
 
     element(by.id('leaStDate')).sendKeys("04/06/2019");
     browser.sleep(2000).then(function() {
      console.log('waited 2 seconds');
      });  
      element(by.id('leaEndDate')).sendKeys("04/06/2019");
      browser.sleep(2000).then(function() {
       console.log('waited 2 seconds');
       });  
       element(by.id('leaReas')).sendKeys("Sick");
       browser.sleep(2000).then(function() {
        console.log('waited 2 seconds');
        });  
        element(by.id('leaType')).sendKeys("EL");
        browser.sleep(2000).then(function() {
         console.log('waited 2 seconds');
         });  
 
         element(by.name('Apply')).click();
 
         browser.sleep(2000).then(function() {
           console.log('waited 2 seconds');
           });  
 
         expect(element(by.name('result')).getText()).toEqual('StartDate cannot be Saturday or sunday...');
     
  });


  it('should ApplyLeave for StatDate-EndDate ', function() { 
    
     
      browser.ignoreSynchronization = true;
      browser.get('http://localhost:4200');
 
      browser.sleep(1000).then(function() {
        console.log('waited 2 seconds');
      });  
      element(by.id('row2')).click();
      browser.sleep(1000).then(function() {
        console.log('waited 2 seconds');
      });  

      element(by.name('password')).sendKeys("123");
      browser.sleep(2000).then(function() {
        console.log('waited 2 seconds');
      });
      element(by.name('submit')).click();
      browser.sleep(2000).then(function() {
        console.log('waited 2 seconds');
      });  
      element(by.id('applyLeave')).click();
      browser.sleep(2000).then(function() {
       console.log('waited 2 seconds');
     });  
 
     element(by.id('leaStDate')).sendKeys("04/05/2019");
     browser.sleep(2000).then(function() {
      console.log('waited 2 seconds');
      });  
      element(by.id('leaEndDate')).sendKeys("04/01/2019");
      browser.sleep(2000).then(function() {
       console.log('waited 2 seconds');
       });  
       element(by.id('leaReas')).sendKeys("Sick");
       browser.sleep(2000).then(function() {
        console.log('waited 2 seconds');
        });  
        element(by.id('leaType')).sendKeys("EL");
        browser.sleep(2000).then(function() {
         console.log('waited 2 seconds');
         });  
 
         element(by.name('Apply')).click();
 
         browser.sleep(2000).then(function() {
           console.log('waited 2 seconds');
           });  
 
         expect(element(by.name('result')).getText()).toEqual('EndDate must be greater than StartDate..');
     
  });

   xit('should ApplyLeave ', function() { 
   
    
     browser.ignoreSynchronization = true;
     browser.get('http://localhost:4200/login');
     element(by.name('username')).sendKeys("2000");
    // localStorage.setItem("empId","2000");
     browser.sleep(5000).then(function() {
       console.log('waited 2 seconds');
     });
     element(by.name('password')).sendKeys("123");
     browser.sleep(5000).then(function() {
       console.log('waited 2 seconds');
     });
     element(by.name('submit')).click();
     browser.sleep(5000).then(function() {
       console.log('waited 2 seconds');
     });  
     element(by.id('applyLeave')).click();
     browser.sleep(5000).then(function() {
      console.log('waited 2 seconds');
    });  

    element(by.id('leaStDate')).sendKeys("04/05/2019");
    browser.sleep(5000).then(function() {
     console.log('waited 2 seconds');
     });  
     element(by.id('leaEndDate')).sendKeys("04/01/2019");
     browser.sleep(5000).then(function() {
      console.log('waited 2 seconds');
      });  
      element(by.id('leaReas')).sendKeys("Sick");
      browser.sleep(5000).then(function() {
       console.log('waited 2 seconds');
       });  
       element(by.id('leaType')).sendKeys("EL");
       browser.sleep(5000).then(function() {
        console.log('waited 2 seconds');
        });  

        element(by.name('Apply')).click();

        browser.sleep(5000).then(function() {
          console.log('waited 2 seconds');
          });  

        expect(element(by.name('result')).getText()).toEqual('5');

        // expect(element(by.binding('msg')).getText()).toEqual('Hello');

   });

   
 });

describe('workspace-project App', () => {
  let page: AppPage;

  beforeEach(() => {
    page = new AppPage();
  });

  it('should display welcome message', () => {
    page.navigateTo();
    expect(page.getTitleText()).toEqual('Welcome to ProDemo!');
  });

  afterEach(async () => {
    // Assert that there are no errors emitted from the browser
    const logs = await browser.manage().logs().get(logging.Type.BROWSER);
    expect(logs).not.toContain(jasmine.objectContaining({
      level: logging.Level.SEVERE,
    } as logging.Entry));
  });
});
