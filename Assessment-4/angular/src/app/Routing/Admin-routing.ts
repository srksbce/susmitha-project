export const ADMIN_ROUTES = [
    {

        path: 'dashboard', loadChildren: () => import("../admin/admin-dashboard/admin-dashboard.module").then(x => x.AdminDashboardModule)
    },
    { path: 'employee', loadChildren: () => import("../admin/employee/employee.module").then(x => x.EmployeeModule) },
    { path: 'department', loadChildren: () => import("../admin/department/department.module").then(x => x.DepartmentModule) }
];