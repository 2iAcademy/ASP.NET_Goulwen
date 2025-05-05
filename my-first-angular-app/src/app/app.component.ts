import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import {HelloComponent} from './hello/hello.component';
import {CounterComponent} from './counter/counter.component';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, HelloComponent, CounterComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  title = 'my-first-angular-app';
}
