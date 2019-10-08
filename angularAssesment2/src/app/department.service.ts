import { Injectable } from '@angular/core';
import { department}  from './department';
import {HttpClient} from '@angular/common/http'



@Injectable({
  providedIn: 'root'
})
export class DepartmentService {
 departmentlist:department[]=[


{department:1,name:'Engineering',groupName:'Research and Development',MoifiedDate:new Date('06/01/2002')},
{department:2,name:'Tool Design',groupName:'Research and Development',MoifiedDate:new Date('06/01/2005')},
{department:3,name:'marketing',groupName:'sales and marketing',MoifiedDate:new Date('06/01/2008')},


 ];
  constructor() {
   }
   getdepartrment(){
    return this.departmentlist;
  }
  delete(index :number)
  {
    this.departmentlist.splice(index,1);
  }
  save(depart){
    this.departmentlist.push(depart)
  }
  update(depart,index:number){
  this.departmentlist[index]=depart
  }
}
