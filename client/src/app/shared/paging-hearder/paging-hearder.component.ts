import { Component,Input } from '@angular/core';

@Component({
  selector: 'app-paging-hearder',
  templateUrl: './paging-hearder.component.html',
  styleUrls: ['./paging-hearder.component.scss']
})
export class PagingHearderComponent {
  @Input() pageNumber?: number;
  @Input() pageSize?: number;
  @Input() totalCount?: number;
}
