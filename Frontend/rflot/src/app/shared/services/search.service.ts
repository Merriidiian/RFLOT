import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';

import { Observable } from 'rxjs';

import { SearchDTO } from 'src/app/models/search.dto';
import { PlaneDTO } from 'src/app/models/plane.dto';

@Injectable({
  providedIn: 'root',
})
export class SearchService {
  constructor(private http: HttpClient) {}

  search(body: SearchDTO): Observable<PlaneDTO> {
    // let queryParams = new HttpParams();
    // queryParams = queryParams.append("planeId", body.id);
    // queryParams = queryParams.append("data", body.data);
    // return this.http.get<PlaneDTO>('/api/search', {params : queryParams});
    return this.http.get<PlaneDTO>('aeroflot/api/v1/rfid-report/get-zones?planeId=70DF1512&data=2023-10-04');
  }
}