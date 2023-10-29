import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PaginationModule } from 'ngx-bootstrap/pagination';
import { PagingHearderComponent } from './paging-hearder/paging-hearder.component';
import { PagerComponent } from './pager/pager.component';
import { RouterModule } from '@angular/router';




@NgModule({
  declarations: [
    PagingHearderComponent,
    PagerComponent
  ],
  imports: [
    CommonModule,
    PaginationModule.forRoot(),
    RouterModule
  ],
  exports:[
    PaginationModule,
    PagingHearderComponent,
    PagerComponent
  ]
})
export class SharedModule { }
