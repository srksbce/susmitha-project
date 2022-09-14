import { Component, OnDestroy, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { HttpService } from 'src/app/services/http.service';
import { ILogin } from '../signup/register-model';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit,OnDestroy {
  loginobj={} as ILogin;
  subscription!:Subscription;

  constructor(private _http:HttpService,private router:Router) { }
 

  ngOnInit(): void {
    this.loginobj={userName:'susmitha@gmail.com',password:'sai@123'}
  }

public login(f:NgForm){
  this.subscription=this._http.postData("Accounts/LoginUser",this.loginobj).subscribe({
    next:(data:any)=>{
      console.log(data);
    },
    error:reason=>console.log(reason)
  });
  
}
ngOnDestroy(): void {
  if(this.subscription)
this.subscription.unsubscribe();
}
}
