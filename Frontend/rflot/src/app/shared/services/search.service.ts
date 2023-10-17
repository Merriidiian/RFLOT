import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { Observable } from 'rxjs';

import { SearchDTO } from 'src/app/models/search.dto';
import { PlaneDTO } from 'src/app/models/plane.dto';

@Injectable({
  providedIn: 'root',
})
export class SearchService {
  constructor(private http: HttpClient) {}

  search(body: SearchDTO): Observable<PlaneDTO> {
    return this.http.post<PlaneDTO>('/api/search', body);
  }
}