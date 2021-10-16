import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'

import { environment } from 'src/environments/environment';
import { Shipper } from 'src/app/models/shipper';
import { Observable } from 'rxjs';
//import { Observable } from 'rxjs/internal/Observable';

@Injectable({
  providedIn: 'root'
})

export class ShipperService {

  endpoint: string = '/Shippers';

  constructor(private http: HttpClient) { }

  public crearShipper(shipperRequest: Shipper): Observable<any> {
    let url = environment.apiShippers + this.endpoint;
    return this.http.post(url, shipperRequest);
  }

  public obtenerShipper(): Observable<Array<Shipper>> {
    let url = environment.apiShippers + this.endpoint;
    return this.http.get<Array<Shipper>>(url);
  }
}
