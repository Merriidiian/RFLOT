import { Component } from '@angular/core';

@Component({
  template: `
    <main class="empty-layout">
      <router-outlet></router-outlet>
    </main>
  `,
  styles: [
    `
      .empty-layout {
        height: 100vh;
        width: 100vw;
        display: flex;
        align-items: center;
        justify-content: center;
      }
    `
  ]
})
export class EmptyLayoutComponent {}
