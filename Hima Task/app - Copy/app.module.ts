import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { InputTextModule } from 'primeng/inputtext';
import { ButtonModule } from 'primeng/button';
import { TableModule } from 'primeng/table';
import { DialogModule } from 'primeng/dialog';
import { AppComponent } from './app.component';
import {MenuItem} from 'primeng/api';
import {PanelMenuModule} from 'primeng/panelmenu';
import { MenuExComponent } from './menu-ex/menu-ex.component';
import { RouterModule, Routes } from '@angular/router';
import { DetailsComponent } from './details/details.component';
import { DemoComponent } from './demo/demo.component';
import { TestComponent } from './test/test.component';
import { DashBoardComponent } from './dash-board/dash-board.component';
const appRoutes: Routes = [
    { path: 'Demo', component: DemoComponent },
    { path: 'Details', component: DetailsComponent },
    { path: '', component: DashBoardComponent },
  ];
@NgModule({
    declarations: [
        AppComponent,
        MenuExComponent,
        DetailsComponent,
        DemoComponent,
        TestComponent,
        DashBoardComponent
    ],
    imports: [
        BrowserModule,
        BrowserAnimationsModule,
        FormsModule,
        TableModule,
        HttpClientModule,
        InputTextModule,
        DialogModule,
        ButtonModule,
        PanelMenuModule,
        RouterModule.forRoot(appRoutes),
    ],
    providers: [],
    bootstrap: [AppComponent]
})
export class AppModule { }
