import { Pipe, PipeTransform } from '@angular/core';

//PipeName
//@decorator 
@Pipe({
  name: 'userTitle'
})
//creating custom pipe
export class UserTitlePipe implements PipeTransform {
    //transform is a method in pipetransform interface
  transform(name: string, gender: string): string {
    if (gender === 'male')
      return "Mr. " + name;
    else
      return "Miss." + name;
  }


}