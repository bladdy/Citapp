import { HttpClient, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Service } from '../shared/models/service.interfaces';
import { Pagination } from '../shared/models/pagination.interface';
import { Category } from '../shared/models/category.interface';
import { CitaAppParams } from '../shared/models/citappParams';

@Injectable({
  providedIn: 'root'
})
export class ShopService {
  baseUrl = 'https://localhost:5001/api/';
  constructor(private http: HttpClient) {}
  getServices( citaAppParams: CitaAppParams){
    let params = new HttpParams();
    if (citaAppParams.categoryId > 0) params = params.append('categoryId',citaAppParams.categoryId)
    params = params.append('sort',citaAppParams.sort);
    params = params.append('pageIndex',citaAppParams.pageNumber);
    params = params.append('pageSize',citaAppParams.pageSize);
    if (citaAppParams.search) params = params.append('search',citaAppParams.search);

    return this.http.get<Pagination<Service[]>>(this.baseUrl + 'Service/GetServices',{params});
  }
  getService(id : number){
    return this.http.get<Service>(this.baseUrl + 'Service/GetServices/' + id);
  }
  getCategory(){
    return this.http.get<Category[]>(this.baseUrl + 'Service/GetCategories/');
  }

}
