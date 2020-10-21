import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LoginreactiveformComponent } from './loginreactiveform.component';

describe('LoginreactiveformComponent', () => {
  let component: LoginreactiveformComponent;
  let fixture: ComponentFixture<LoginreactiveformComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ LoginreactiveformComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LoginreactiveformComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
