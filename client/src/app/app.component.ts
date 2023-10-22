import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Service } from './models/service.interfaces';
import { Pagination } from './models/pagination.interface';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit{
  title = 'Cita Apps';
  services: Service[] = [];
  constructor(private http: HttpClient) {}
  ngOnInit(): void {
    this.http.get<Pagination<Service[]>>('https://localhost:5001/api/Service/GetServices/?pageSize=10').subscribe({
      next: response => this.services= response.data,
      error: error => console.log(error),
      complete : () => {
        console.log('request competed')
        console.log('extra statment')
      }
    });

  }
}
