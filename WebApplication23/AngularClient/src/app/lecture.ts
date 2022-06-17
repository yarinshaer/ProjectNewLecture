import { Time } from "@angular/common";

export interface Lecture{
    Id:number,
    Name:string,
    Email:string,
    languages: number[],
    languagesName:string[]
}


export interface Languages{
    Id:number,
    Name:string,
    isSelected: boolean
}
