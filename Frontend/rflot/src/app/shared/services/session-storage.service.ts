import { Injectable } from '@angular/core';

import { PlaneDTO } from 'src/app/models/plane.dto';

@Injectable({
  providedIn: 'root',
})
export class SessionStorageService {
  savePlane(plane: PlaneDTO): void {
    sessionStorage.setItem('plane', JSON.stringify(plane));
  }

  getPlane(): PlaneDTO[] | null {
    const plane = sessionStorage.getItem('plane');
    if (plane) {
      try {
        return JSON.parse(plane);
      } catch (e) {
        console.log(e);
        return null;
      }
    }
    return null;
  }

  clearPlane(): void {
    sessionStorage.clear();
  }
}
