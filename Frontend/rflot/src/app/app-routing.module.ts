import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AppComponent } from './app.component';
import { SearchComponent } from './pages/search/search.component';
import { EmptyLayoutComponent } from './shared/layouts/empty-layout/empty-layout.component';
import { InnerLayoutComponent } from './shared/layouts/inner-layout/inner-layout.component';
import { DashboardComponent } from './pages/dashboard/dashboard.component';

const routes: Routes = [
  {
    path: '',
    redirectTo: 'app/search',
    pathMatch: 'full',
  },
  {
    path: '',
    component: AppComponent,
    children: [
      {
        path: 'search',
        component: EmptyLayoutComponent,
        children: [{ path: '', component: SearchComponent }],
      },
      {
        path: 'app',
        component: InnerLayoutComponent,
        children: [{ path: 'dashboard', component: DashboardComponent }],
      },
    ]
  },
  {
    path: '**',
    redirectTo: `error/404`,
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
