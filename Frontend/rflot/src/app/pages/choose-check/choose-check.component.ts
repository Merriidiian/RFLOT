import { Component, OnInit } from '@angular/core';
import { PlaneDTO } from 'src/app/models/plane.dto';
import { SessionStorageService } from 'src/app/shared/services/session-storage.service';

const ELEMENT_DATA = [
  { name: 'Hydrogen' },
  { name: 'Helium' },
  { name: 'Lithium' },
  { name: 'Beryllium' },
  { name: 'Boron' },
  { name: 'Carbon' },
  { name: 'Nitrogen' },
  { name: 'Oxygen' },
  { name: 'Fluorine' },
  { name: 'Neon' },
];

@Component({
  selector: 'app-choose-check',
  templateUrl: './choose-check.component.html',
  styleUrls: ['./choose-check.component.css'],
})
export class ChooseCheckComponent implements OnInit {
  displayedColumns: string[] = [
    'planeId',
    'dataBegin',
    'dataEnd',
    'type',
  ];

  dataSource: PlaneDTO[] = [];

  constructor(private sessionStorage: SessionStorageService) {}

  ngOnInit(): void {
    this.dataSource = this.sessionStorage.getPlane() || [];
  }
}
