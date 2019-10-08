import { Component } from '@angular/core';
import { DepartmentService} from './department.service'
import { department } from './department';
import {CreatedepartmentComponent} from './createdepartment/createdepartment.component'

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  departmentlistfinal= new department()
  updatediv=false;
  indexposition:number;
  department4:department[]
  title = 'angularassesment';
  constructor(private dept:DepartmentService){

  this.department4=this.dept.getdepartrment();
  }
  deleteEmployee(index:number)
  {
    this.dept.delete(index);
   }
   edit(index:number){
  this.updatediv=true;
  this.departmentlistfinal=this.department4[index];
  this.dept.update(this.departmentlistfinal,this.indexposition); 
   }
  
}
