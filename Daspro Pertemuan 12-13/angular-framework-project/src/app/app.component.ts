import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  mataKuliah = 'Pemrograman Framework';

  onChangeMataKuliah(){
    this.mataKuliah = 'Pemrograman Visual';
  }
}
