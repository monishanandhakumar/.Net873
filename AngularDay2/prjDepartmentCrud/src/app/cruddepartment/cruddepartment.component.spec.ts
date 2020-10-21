import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CruddepartmentComponent } from './cruddepartment.component';

describe('CruddepartmentComponent', () => {
  let component: CruddepartmentComponent;
  let fixture: ComponentFixture<CruddepartmentComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CruddepartmentComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CruddepartmentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
