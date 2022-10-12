import { Component, OnDestroy, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { AuthenticationService } from 'src/app/services/authentication.service';
import { ILogin } from './login-model';




@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit, OnDestroy {

  loginObj = {} as ILogin;
  subscription!: Subscription;
  returnurl!: string | null;
  constructor(private _authenticationservice: AuthenticationService,
    private route: Router,
    private activatedRoute: ActivatedRoute) { }

  ngOnInit(): void {
    // this.loginUser = {
    //   userName: 'srk.sbce@gmail.com',
    //   password: 'Rama@123'
    // }
    this.returnurl = this.activatedRoute.snapshot.queryParamMap.get("returnurl");
  }
  public login(f: NgForm) {
    //this.subscription = this._authenticationservice.postData("Accounts/LoginUser", this.loginObj).subscribe({
    this.subscription = this._authenticationservice.postData("Accounts/LoginUser", this.loginObj).subscribe({
      next: (data: any) => {
        console.log(data);
        if (data.successCode = 200) {
          localStorage.setItem("token", data.data)
          if (this.returnurl)
            this.route.navigate([this.returnurl]);
          else
            this.route.navigate(["/dashboard"]);

          alert(data.message);
          this.loginObj = {} as ILogin;
          f.resetForm();
          //this.route.navigate(["/admin"]);
        }
        else {
          console.log(data.message);
        }

      },
      //error: reason => console.log(reason)

      error: reason => console.log(reason)

    });


  }
  ngOnDestroy(): void {
    if (this.subscription)
      this.subscription.unsubscribe();
  }

}