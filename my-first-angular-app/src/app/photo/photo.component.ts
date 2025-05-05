import {Component, inject} from '@angular/core';
import {HttpClient, provideHttpClient} from '@angular/common/http';
import {DomSanitizer} from '@angular/platform-browser';
import {CommonModule} from '@angular/common';

@Component({
  selector: 'app-photo',
  standalone: true,
  imports: [CommonModule],
  providers: [],
  templateUrl: './photo.component.html',
  styleUrl: './photo.component.css'
})

export class PhotoComponent {
  TESTURL = "https://http.dog/101.jpg"
  private http = inject(HttpClient);
  private sanitizer = inject(DomSanitizer);
  imgUrl : any

  ngOnInit () {
    this.http.get(this.TESTURL, {responseType : 'blob'}).subscribe(blob => {
      const objectUrl = URL.createObjectURL(blob);
      this.imgUrl = this.sanitizer.bypassSecurityTrustUrl(objectUrl);
    })
  }
}
