import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProductinfoComponent } from './productinfo.component';

describe('ProductinfoComponent', () => {
  let component: ProductinfoComponent;
  let fixture: ComponentFixture<ProductinfoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProductinfoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProductinfoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
