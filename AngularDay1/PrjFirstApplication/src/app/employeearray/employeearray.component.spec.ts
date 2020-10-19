import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EmployeearrayComponent } from './employeearray.component';

describe('EmployeearrayComponent', () => {
  let component: EmployeearrayComponent;
  let fixture: ComponentFixture<EmployeearrayComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EmployeearrayComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EmployeearrayComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
