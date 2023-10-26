import { Component, ElementRef, OnInit, ViewChild } from '@angular/core';
import { ShopService } from './shop.service';
import { Service } from '../shared/models/service.interfaces';
import { Category } from '../shared/models/category.interface';
import { CitaAppParams } from '../shared/models/citappParams';

@Component({
  selector: 'app-shop',
  templateUrl: './shop.component.html',
  styleUrls: ['./shop.component.scss']
})
export class ShopComponent implements OnInit{
  @ViewChild('search') searchTerm?: ElementRef;
  services: Service[] = [];
  categories: Category[] = [];
  citaAppParams = new CitaAppParams();
  sortOptions = [
    {name: 'Alphabetical', value: 'mane'},
    {name: 'Price: Low to High', value: 'priceAsc'},
    {name: 'Price: High to Low', value: 'priceDesc'},
  ];
  totalCount = 0;

  constructor(private shopService: ShopService) {

  }
  ngOnInit(): void {
    this.getCategories();
    this.getServices();
  }

  getServices(){
    this.shopService.getServices(this.citaAppParams).subscribe({
      next: response => {
        this.services= response.data;
        this.citaAppParams.pageNumber = response.pageIndex;
        this.citaAppParams.pageSize = response.pageSize;
        this.totalCount = response.count;
      },
      error: error => console.log(error),
    });
  }
  getCategories(){
    this.shopService.getCategory().subscribe({
      next: response => this.categories = [{id: 0, name: 'All', iconUrl: ''}, ...response],
      error: error => console.log(error),
    });
  }
  onCategorySelected(categoryId:number){
    this.citaAppParams.categoryId = categoryId;
    this.citaAppParams.pageNumber = 1;
    this.getServices();
  }
  onSortSelected(event:any){
    this.citaAppParams.sort = event.target.value;
    this.getServices();
  }
  onPageChanged(event:any){
    if (this.citaAppParams.pageNumber !== event) {
      this.citaAppParams.pageNumber = event
      this.getServices();
    }
  }
  onSearch(){
    this.citaAppParams.search = this.searchTerm?.nativeElement.value;
    this.getServices();
  }
  onReset(){

    if (this.searchTerm) this.searchTerm.nativeElement.value = '';
    this.citaAppParams = new CitaAppParams();
    this.getServices();
  }
}
