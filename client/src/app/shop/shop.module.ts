import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ShopComponent } from './shop.component';
import { ServiceItemComponent } from './service-item/service-item.component';
import { SharedModule } from '../shared/shared.module';
import { ServiceDetailsComponent } from './service-details/service-details.component';
import { ShopRoutingModule } from './shop-routing.module';



@NgModule({
  declarations: [
    ShopComponent,
    ServiceItemComponent,
    ServiceDetailsComponent
  ],
  imports: [
    CommonModule,
    SharedModule,
    ShopRoutingModule
  ],

  bootstrap:[]
})
export class ShopModule { }
