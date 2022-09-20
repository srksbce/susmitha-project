using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web.Mvc;
using MVCnew.Models;
using MVCnew.ViewModels;

namespace MVCnew.Controllers
{
    public class HomeController : Controller
    {
        TrainDataEntities context=new TrainDataEntities();
        public ActionResult Index()
        {
            //context.Configuration.LazyLoadingEnabled= false;
            context.Configuration.ProxyCreationEnabled = false;
            List<Employee1> employees = context.Employee1.Include("Department").ToList();
            
            
            //LinQ expression
            Employee1 emp = (from a in context.Employee1 where a.EmpId == 1 select a).SingleOrDefault();
            //Lambda expression
            emp = context.Employee1.Where(x => x.EmpId == 1).SingleOrDefault();
            
            string EmpName = (from a in context.Employee1 where a.EmpId == 1 select a.EmpName).SingleOrDefault();
            EmpName = context.Employee1.Where(x => x.EmpId == 1).Select(x => x.EmpName).SingleOrDefault();
            
            //showing list of employees
            List<Employee1> list = (from a in context.Employee1 where a.DeptId == 1 select a).ToList();
            list=context.Employee1.Where(x => x.DeptId == 1).ToList();


            employees=context.Employee1.OrderByDescending(x=> x.EmpSalary).ToList();

            var empList = (from a in context.Employee1
                           join b in context.Departments on a.DeptId equals b.DeptId
                           select new DeptEmp
                           { DeptId = a.DeptId,
                             DeptName = b.DeptName,
                             EmpId=a.EmpId,
                             EmpName=a.EmpName,
                             EmpSalary=a.EmpSalary


                           }).ToList();

            return View(employees);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}