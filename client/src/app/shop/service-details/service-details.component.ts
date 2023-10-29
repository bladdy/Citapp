import { Component, OnInit } from '@angular/core';
import { ShopService } from '../shop.service';
import { Service } from 'src/app/shared/models/service.interfaces';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-service-details',
  templateUrl: './service-details.component.html',
  styleUrls: ['./service-details.component.scss']
})
export class ServiceDetailsComponent implements OnInit{
  service?: Service;

  constructor(private shop: ShopService,private activateRoute: ActivatedRoute) {

  }
  ngOnInit(): void {
    this.loadService();
  }
  loadService(){
    const id = this.activateRoute.snapshot.paramMap.get('id')
    if (id) this.shop.getService(+id).subscribe({
      next : service => this.service =service,
      error: error => console.log(error)

    })
  }

}
