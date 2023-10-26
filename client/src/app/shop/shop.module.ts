import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ShopComponent } from './shop.component';
import { ServiceItemComponent } from './service-item/service-item.component';
import { SharedModule } from '../shared/shared.module';



@NgModule({
  declarations: [
    ShopComponent,
    ServiceItemComponent
  ],
  imports: [
    CommonModule,
    SharedModule
  ],
  exports:[
    ShopComponent
  ],
  bootstrap:[]
})
export class ShopModule { }
