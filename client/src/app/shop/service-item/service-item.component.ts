import { Component, Input } from '@angular/core';
import { Service } from 'src/app/shared/models/service.interfaces';

@Component({
  selector: 'app-service-item',
  templateUrl: './service-item.component.html',
  styleUrls: ['./service-item.component.scss']
})
export class ServiceItemComponent {
@Input() service?: Service;
/**
 *
 */
constructor() {


}
}
