import { AuthorsService } from './../authors.service';
import { Component } from '@angular/core';

@Component({
  selector: 'app-author',
  template: `
              <h1> {{title}} </h1>
              <ul>
                <li *ngFor="let author of authors">
                  {{author}}
                </li>
              </ul>
              `
})
export class AuthorComponent {
  title = "3 Authors";
  authors;

  constructor(service: AuthorsService){
    this.authors = service.getAuthor();
  }
}
