import { Component } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { PlaneDTO } from 'src/app/models/plane.dto';
import { SearchService } from 'src/app/shared/services/search.service';
import { SessionStorageService } from 'src/app/shared/services/session-storage.service';

@Component({
  selector: 'app-search',
  templateUrl: './search.component.html',
  styleUrls: ['./search.component.css']
})
export class SearchComponent {
  form = this.fb.group({
    planeId: [null, Validators.required],
  });

  private subscriptions$ = new Subscription();

  constructor(
    private searchService: SearchService,
    private sessionStorage: SessionStorageService,
    private router: Router,
    private fb: FormBuilder,
  ) {}

  ngOnDestroy(): void {
    this.subscriptions$.unsubscribe();
  }

  search(): void {
    if (this.form.valid) {
      this.subscriptions$.add(
        this.searchService.search(this.form.value).subscribe((data: PlaneDTO) => {
          this.sessionStorage.savePlane(data);
          this.router.navigate(['/app/dashboard']);
          }
        )
      );
    }
  }
}
