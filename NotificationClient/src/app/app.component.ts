import { Component, Input } from '@angular/core';
import { stringify } from '@angular/core/src/util';
import {HttpClient} from '@angular/common/http';
import {NotificationDto} from './notificationDto';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],


})
export class AppComponent {
  title = 'NotificationClient';

  @Input()
  data: NotificationDto = new NotificationDto();

  constructor(private http: HttpClient) { }

  onClick(user: NotificationDto) {

    this.http.post('http://localhost:63721/api/notify', user);
  }

}
