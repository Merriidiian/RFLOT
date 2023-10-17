import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { Observable } from 'rxjs';

import { SearchDTO } from 'src/app/models/search.dto';
import { BadEquipsDTO } from 'src/app/models/plane.dto';

@Injectable({
  providedIn: 'root',
})
export class SearchService {
  constructor(private http: HttpClient) {}

  search(body: SearchDTO): Observable<BadEquipsDTO> {
    return this.http.post<BadEquipsDTO>('/api/search', body);
  }
}