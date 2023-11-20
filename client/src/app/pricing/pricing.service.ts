import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Plan } from '../shared/models/pricing.interface';

@Injectable({
  providedIn: 'root'
})
export class PricingService {
  baseUrl = 'https://localhost:5001/api/';
  constructor(private http: HttpClient) { }

  getPlans() {
    return this.http.get<Plan[]>(this.baseUrl + 'Settings/GetPlans/');
  }
}
