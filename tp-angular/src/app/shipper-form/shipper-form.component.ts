import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Shipper } from '../models/shipper';

import { ShipperService } from '../services/shipper.service';

@Component({
  selector: 'app-shipper-form',
  templateUrl: './shipper-form.component.html',
  styleUrls: ['./shipper-form.component.scss']
})
export class ShipperFormComponent implements OnInit {

  shippersForm: FormGroup;

  constructor(private readonly fb: FormBuilder, private shipperService: ShipperService) { }

  ngOnInit(): void {
    this.shippersForm = this.fb.group({
      id: ['', [Validators.required, Validators.max(99999)]],
      companyName: ['', [Validators.required, Validators.maxLength(40)]],
      phone: ['', [Validators.required, Validators.maxLength(24)]]
    });
  }

  onSubmit(): void {
    console.log(this.shippersForm.value);
  }

  get f() {
    return this.shippersForm.controls;
  }

  guardarShipper(): void {
    var shipper = new Shipper();
    shipper.id = this.shippersForm.get('id').value;
    shipper.companyName = this.shippersForm.get('companyName').value;
    shipper.phone = this.shippersForm.get('phone').value;

    this.shipperService.crearShipper(shipper).subscribe(res => {
      this.shippersForm.reset();
      console.log("Se guardo correctamente");
    });
  }

  cancelarFormulario(): void {
    this.shippersForm.reset();
  }
}
