import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { ShopComponent } from './shop/shop.component';
import { ServiceDetailsComponent } from './shop/service-details/service-details.component';
import { PricingComponent } from './pricing/pricing.component';

const routes: Routes = [
  {path:'', component: HomeComponent},
  {path:'shop',loadChildren:() => import('./shop/shop.module').then(m => m.ShopModule) },
  {path:'pricing',component: PricingComponent },
  {path:'account', loadChildren:() => import('./account/account.module').then(m => m.AccountModule) },
//{path:'account', loadComponent:() => import('./account/account.module').then(m => m.AccountModule) },
  {path: '**', redirectTo: '', pathMatch: 'full'},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
