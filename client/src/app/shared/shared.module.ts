import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PaginationModule } from 'ngx-bootstrap/pagination';
import { PagingHearderComponent } from './paging-hearder/paging-hearder.component';
import { PagerComponent } from './pager/pager.component';
import { ReactiveFormsModule } from '@angular/forms';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { CarouselModule } from 'ngx-bootstrap/carousel';





@NgModule({
  declarations: [
    PagingHearderComponent,
    PagerComponent
  ],
  imports: [
    CommonModule,
    PaginationModule.forRoot(),
    CarouselModule.forRoot(),
    ReactiveFormsModule,
    BsDropdownModule.forRoot()

  ],
  exports:[
    PaginationModule,
    PagingHearderComponent,
    PagerComponent,
    ReactiveFormsModule,
    BsDropdownModule,
    CarouselModule
  ]
})
export class SharedModule { }
