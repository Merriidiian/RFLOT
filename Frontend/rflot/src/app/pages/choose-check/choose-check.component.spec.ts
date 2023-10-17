import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ChooseCheckComponent } from './choose-check.component';

describe('ChooseCheckComponent', () => {
  let component: ChooseCheckComponent;
  let fixture: ComponentFixture<ChooseCheckComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ChooseCheckComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ChooseCheckComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
