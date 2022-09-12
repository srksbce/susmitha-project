import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-services',
  templateUrl: './services.component.html',
  styleUrls: ['./services.component.css']
})
export class ServicesComponent implements OnInit {
  employees: { empNumber: number; empName: string}[] | undefined;
  optionValue: number | undefined;
  constructor() { }

  ngOnInit(): void {
    this.employees = [
      { empNumber: 1, empName: 'Sai'},
      { empNumber: 2, empName: 'susmitha'},
      { empNumber: 3, empName: 'chaitu'}
    ];
    }
     
  public service(){};
  public selectTab(val: number) {
    this.optionValue = val;
  }
}
