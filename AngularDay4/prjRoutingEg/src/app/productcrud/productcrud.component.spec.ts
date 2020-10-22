import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProductcrudComponent } from './productcrud.component';

describe('ProductcrudComponent', () => {
  let component: ProductcrudComponent;
  let fixture: ComponentFixture<ProductcrudComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProductcrudComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProductcrudComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
