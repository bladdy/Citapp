import { Component, OnInit } from '@angular/core';
import { PricingService } from './pricing.service';
import { Plan } from '../shared/models/pricing.interface';

@Component({
  selector: 'app-pricing',
  templateUrl: './pricing.component.html',
  styleUrls: ['./pricing.component.scss']
})
export class PricingComponent implements OnInit{

  plans: Plan[] = [];
  constructor(private pricingService: PricingService) {
  }
  ngOnInit(): void {
    this.getPricings();
  }
  getPricings(){
    this.pricingService.getPlans().subscribe({
      next: response => {
        this.plans = response
      },
      error: error => console.log(error)
    });
  }
}
