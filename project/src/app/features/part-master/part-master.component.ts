import { Component, OnInit } from '@angular/core';
import { PartMasterService } from 'src/app/core/services/part-master.service';

@Component({
  selector: 'app-part-master',
  templateUrl: './part-master.component.html',
  styleUrls: ['./part-master.component.scss']
})
export class PartMasterComponent implements OnInit {
  mainWindow: any;
  partMasterWindow: any;
  title: string = 'T K A P - [IS]';
  currentFormName: string = 'PART_MASTER';
  currentDate: string;
  saveButton: boolean = false;
  groupIdField: boolean = true;
  partNoField: boolean = true;
  partStatusField: boolean = true;
  partDescField: boolean = true;
  lineIdField: boolean = true;
  unitIdField: boolean = true;

  constructor(private partMasterService: PartMasterService) {}

  ngOnInit(): void {
    this.initializeWindow();
    this.setInitialFocus();
  }

  initializeWindow(): void {
    this.mainWindow = window;
    this.mainWindow.moveTo(0, 0);
    this.mainWindow.resizeTo(screen.width, screen.height);
    this.partMasterWindow = document.getElementById('partMasterWindow');
    this.partMasterWindow.style.display = 'block';
    this.currentDate = this.partMasterService.getCurrentDate();
    this.saveButton = false;
    this.groupIdField = true;
    this.partNoField = true;
    this.partStatusField = true;
    this.partDescField = true;
    this.lineIdField = true;
    this.unitIdField = true;
  }

  setInitialFocus(): void {
    const unitIdElement = document.getElementById('unitIdField');
    if (unitIdElement) {
      unitIdElement.focus();
    }
  }
}