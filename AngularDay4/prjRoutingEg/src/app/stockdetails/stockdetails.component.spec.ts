import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { StockdetailsComponent } from './stockdetails.component';

describe('StockdetailsComponent', () => {
  let component: StockdetailsComponent;
  let fixture: ComponentFixture<StockdetailsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ StockdetailsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(StockdetailsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
