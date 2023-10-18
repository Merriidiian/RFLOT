import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';

import { EmptyLayoutComponent } from './empty-layout/empty-layout.component';
import { InnerLayoutComponent } from './inner-layout/inner-layout.component';
import { MaterialModule } from '../material.module';

@NgModule({
  imports: [
    CommonModule,
    RouterModule,
    MaterialModule,
  ],
  declarations: [
    EmptyLayoutComponent,
    InnerLayoutComponent,
  ],
  exports: [
    EmptyLayoutComponent,
    InnerLayoutComponent,
  ],
})
export class LayoutsModule {}