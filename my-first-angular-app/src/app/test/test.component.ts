import {Component, inject, OnInit} from '@angular/core';
import {HttpClient} from '@angular/common/http';
import {DomSanitizer} from '@angular/platform-browser';

@Component({
  selector: 'app-test',
  imports: [],
  templateUrl: './test.component.html',
  styleUrl: './test.component.css'
})
export class TestComponent implements OnInit {
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
