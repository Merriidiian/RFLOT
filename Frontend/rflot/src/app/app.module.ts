import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule } from '@angular/router';
import { ReactiveFormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { DashboardComponent } from './pages/dashboard/dashboard.component';
import { ErrorComponent } from './pages/error/error.component';
import { SearchComponent } from './pages/search/search.component';
import { ChooseCheckComponent } from './pages/choose-check/choose-check.component';

import { LayoutsModule } from './shared/layouts/layouts.module';
import { MaterialModule } from './shared/material.module';

@NgModule({
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    HttpClientModule,
    ReactiveFormsModule,
    RouterModule,
    LayoutsModule,
    MaterialModule,
  ],
  declarations: [
    AppComponent,
    DashboardComponent,
    ErrorComponent,
    SearchComponent,
    ChooseCheckComponent
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
