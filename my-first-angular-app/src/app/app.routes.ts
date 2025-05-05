import { Routes } from '@angular/router';
import {CounterComponent} from './counter/counter.component';
import {HelloComponent} from './hello/hello.component';
import {HomeComponent} from './home/home.component';
import {UserComponent} from './user/user.component';
import {PhotoComponent} from './photo/photo.component';
import {TestComponent} from './test/test.component';

export const routes: Routes = [
  { path: '', redirectTo: 'home', pathMatch: 'full' },
  { path: 'counter', component: CounterComponent },
  { path: 'hello', component: HelloComponent },
  { path: 'home', component: HomeComponent },
  { path: 'user', component: UserComponent },
  { path: 'test', component: TestComponent },
  { path: 'photo', component: PhotoComponent }
];
