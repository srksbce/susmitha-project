import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminLayoutComponent } from './Layout/admin-layout/admin-layout.component';
import { AuthenticationLayoutComponent } from './Layout/authentication-layout/authentication-layout.component';
import { ADMIN_ROUTES } from './Routing/Admin-routing';
import { AUTHENTICATION_ROUTES } from './Routing/Authentication-routing';

const routes: Routes = [
  { path: '', component: AuthenticationLayoutComponent, children: AUTHENTICATION_ROUTES },
  { path: '', component: AdminLayoutComponent, children: ADMIN_ROUTES }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
