import { Component, OnInit } from '@angular/core';
import { Shipper } from '../models/shipper';

import { ShipperService } from '../services/shipper.service';


@Component({
  selector: 'app-shipper-list',
  templateUrl: './shipper-list.component.html',
  styleUrls: ['./shipper-list.component.scss']
})
export class ShipperListComponent implements OnInit {
  public listShippers: Array<Shipper> = [];
  constructor(private shipperService: ShipperService) { }

  ngOnInit(): void {
    this.obtenerShipper();
  }

  obtenerShipper() {
    return this.shipperService.obtenerShipper().subscribe(res => {
      this.listShippers = res;
      console.log(this.listShippers);
    })
  }
}
