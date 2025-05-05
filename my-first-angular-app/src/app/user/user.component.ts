import { Component } from '@angular/core';

@Component({
  selector: 'app-user',
  imports: [],
  templateUrl: './user.component.html',
  styleUrl: './user.component.css'
})
export class UserComponent {
  user = {
    firstname : "Goulwend",
    lastname : "Delaunay",
    email : "mail@mail.vom",
    id : 0
  };
}
