import { Component, OnInit } from '@angular/core';
import {DepartmentService } from '../department.service'
import {department} from '../department'
@Component({
  selector: 'app-createdepartment',
  templateUrl: './createdepartment.component.html',
  styleUrls: ['./createdepartment.component.scss']
})
export class CreatedepartmentComponent implements OnInit {
department2= new department()

  constructor(private dept:DepartmentService) { }

  ngOnInit() {
  }
  saveDepartment(){
    this.dept.save(this.department2);
  }
 
}
