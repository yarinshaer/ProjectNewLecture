import { Component, OnInit } from '@angular/core';
import { combineLatest } from 'rxjs';
import { Languages, Lecture } from '../lecture';
import { CustomerApiService } from '../services/share/lectureapi.service'

@Component({
  selector: 'app-getlecture',
  templateUrl: './getlecture.component.html',
  styleUrls: ['./getlecture.component.css']
})
export class GetlectureComponent implements OnInit {

  lecture: Lecture[] = [];
  allLecture: Lecture[] = [];

  languages: Languages[] = [];
  values = '';

  constructor(private customerApi: CustomerApiService) {
  }


  ngOnInit(): void {
    console.log(this.values)
    this.getAllCustomers();
  }

  getAllCustomers() {
     this.customerApi.getAllCustomers().subscribe(
    response => {
    let lec = response;

    this.customerApi.getAllLenguages().subscribe(
    response1 => {
      response1.forEach(ele => { ele.isSelected = false; })

    this.languages = response1;

    for (var i = 0; i < lec.length; i++) {
      for (var k = 0; k < lec[i].languages.length; k++) {
        for (var j = 0; j < this.languages.length; j++) {
          if (lec[i].languages[k] === this.languages[j].Id) {
            lec[i].languagesName.push(this.languages[j].Name)
          }
        }
      }
    }
    this.lecture = lec;
    this.allLecture = lec;
    console.log(this.lecture.filter(x => x.languagesName.includes("NodeJS")))
    },
   error => {
   console.log(error);
  });

    },
    error => {
    console.log(error);
    });
  }

  onKey(event: KeyboardEvent) {
    this.values = (event.target as HTMLInputElement).value;
    this.lecture = this.allLecture.filter(x => x.languagesName.includes(this.values.toLocaleLowerCase()))
    if (this.values == null || this.values.length == 0) {
      this.getAllCustomers();
    }
  }

  filterLec() {
    if (this.allAreFalse(this.languages)) {
      this.lecture = this.allLecture;
    } else {
      this.lecture = [];
      this.languages.forEach(element => {
        if (element.isSelected) {
          this.allLecture.forEach(lec => {
            if (lec.languagesName.includes(element.Name)) {
              if(this.lecture.indexOf(lec) === -1) {
                this.lecture.push(lec);
            }
            }
          });
        }
      });
    }
  }

  allAreFalse(arr: any) {
    return arr.every((element: any) => element.isSelected === false);
  }

}


