import { Component, OnDestroy, OnInit } from '@angular/core';
import { Subscription } from 'rxjs';
import { HttpService } from 'src/app/services/http.service';
import { IPosts } from '../posts-model';

@Component({
  selector: 'app-posts',
  templateUrl: './posts.component.html',
  styleUrls: ['./posts.component.css']
})
export class PostsComponent implements OnInit, OnDestroy {

  posts = [] as IPosts[];
  subscription!: Subscription;

  constructor(private http: HttpService) { }

  ngOnInit(): void {
    this.loadPosts();
  }

  
  loadPosts() {
    this.subscription = this.http.getData("https://jsonplaceholder.typicode.com/posts").subscribe({
      next: (data) => {
        this.posts = data as IPosts[];
      },
      error: (reason) => console.log(reason),
      complete: () => console.log("Completed")
    });
  }


  ngOnDestroy(): void {
    if (this.subscription)
      this.subscription.unsubscribe();
  }
}
