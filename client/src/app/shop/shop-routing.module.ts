import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ShopComponent } from './shop.component';
import { ServiceDetailsComponent } from './service-details/service-details.component';

const routes: Routes = [
  {path:'', component: ShopComponent},
  {path:':id', component: ServiceDetailsComponent},
];

@NgModule({
  declarations: [],
  imports: [
    RouterModule.forChild(routes)
  ],
  exports:[
    RouterModule
  ]
})
export class ShopRoutingModule { }
