import { Component } from '@angular/core';
import { MainNavComponent } from './main-nav/main-nav.component';
import { RouterOutlet } from '@angular/router';
import { EndingComponent } from './ending/ending.component';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
  standalone: true,
  imports: [MainNavComponent, RouterOutlet, EndingComponent]
})
export class AppComponent {
  title = 'angular-project';
}
