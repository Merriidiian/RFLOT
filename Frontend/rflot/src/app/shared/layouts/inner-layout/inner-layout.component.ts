import { Component } from '@angular/core';
import { Router } from '@angular/router';

import { SessionStorageService } from '../../services/session-storage.service';
import { PlaneDTO } from 'src/app/models/plane.dto';

@Component({
  selector: 'app-inner-layout',
  templateUrl: './inner-layout.component.html',
  styleUrls: ['./inner-layout.component.css'],
})
export class InnerLayoutComponent {
  plane: PlaneDTO | null = null;

  constructor(
    private sessionStorage: SessionStorageService,
    private router: Router
  ) {
    this.plane = this.sessionStorage.getPlane();
  }

  exit(): void {
    this.sessionStorage.clearPlane();
    this.router.navigate(['/auth/search']);
  }
}