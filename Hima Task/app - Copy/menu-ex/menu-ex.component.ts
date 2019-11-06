import { Component, OnInit } from '@angular/core';
import {MenuItem} from 'primeng/api'
import { ActivatedRoute,Router } from '@angular/router';
@Component({
  selector: 'app-menu-ex',
  templateUrl: './menu-ex.component.html',
  styleUrls: ['./menu-ex.component.css']
})
export class MenuExComponent implements OnInit {

  constructor() {
    
   }

  items: MenuItem[];

  ngOnInit() {
      this.items = [
          {
              label: 'Cheese CO',
              icon: 'pi pi-pw pi-file',
              items: [{
                      label: 'Program Manager', 
                      icon: 'pi pi-fw pi-plus',
                      items: [
                          {label: 'Detailed Structure', icon: 
                          'pi pi-fw pi-user-plus'
                        },
                          {label: 'Locations ', icon: 'pi pi-fw pi-filter',"routerLink": "['Details']"
                        },
                          {label: 'Terms and Conditions ', icon: 'pi pi-fw pi-user-plus'},
                          {label: 'Premium Manager ', icon: 'pi pi-fw pi-user-plus'},
                          {label: 'Submission Manager ', icon: 'pi pi-fw pi-user-plus'},
                      ]
                  },
                  
              ]
          },
          {
              label: 'Program Overview',
              icon: 'pi pi-fw pi-pencil',
              items: [
                  {label: 'Summary', icon: 'pi pi-fw pi-trash'},
                  {label: 'Country Information', icon: 'pi pi-fw pi-refresh'},
                  {label: 'Program Activities', icon: 'pi pi-fw pi-trash'},
                  {label: 'Program Quit', icon: 'pi pi-fw pi-refresh'},
                  {label: 'Document Manager', icon: 'pi pi-fw pi-trash'},
                  
              ]
          },
          {
              label: 'Help',
              icon: 'pi pi-fw pi-question',
              items: [
                  {
                      label: 'Contents',
                      icon: 'pi pi-pi pi-bars'
                  },
                  {
                      label: 'Search', 
                      icon: 'pi pi-pi pi-search', 
                      items: [
                          {
                              label: 'Text', 
                              items: [
                                  {
                                      label: 'Workspace'
                                  }
                              ]
                          },
                          {
                              label: 'User',
                              icon: 'pi pi-fw pi-file',
                          }
                  ]}
              ]
          },
          {
              label: 'Actions',
              icon: 'pi pi-fw pi-cog',
              items: [
                  {
                      label: 'Edit',
                      icon: 'pi pi-fw pi-pencil',
                      items: [
                          {label: 'Save', icon: 'pi pi-fw pi-save'},
                          {label: 'Update', icon: 'pi pi-fw pi-save'},
                      ]
                  },
                  {
                      label: 'Other',
                      icon: 'pi pi-fw pi-tags',
                      items: [
                          {label: 'Delete', icon: 'pi pi-fw pi-minus'}
                      ]
                  }
              ]
          }
      ];
  }

}
