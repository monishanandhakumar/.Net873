import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TemplatedformComponent } from './templatedform.component';

describe('TemplatedformComponent', () => {
  let component: TemplatedformComponent;
  let fixture: ComponentFixture<TemplatedformComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TemplatedformComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TemplatedformComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
