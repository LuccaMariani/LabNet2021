import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ShipperFormComponent } from './shipper-form.component';

describe('ShipperFormComponent', () => {
  let component: ShipperFormComponent;
  let fixture: ComponentFixture<ShipperFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ShipperFormComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ShipperFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
