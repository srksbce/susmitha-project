using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCprojet.Models;
using MVCprojet.ViewModels;

namespace MVCprojet.Controllers
{
    public class HomeController : Controller
    {
        TrainDataEntities context=new TrainDataEntities();
        public ActionResult Index()
        {
            context.Configuration.ProxyCreationEnabled = false;
            context.Configuration.LazyLoadingEnabled = false;

            List<Employee1> employees = context.Employee1.Include("Department").ToList();
            //LINQ EXPRESSION
            Employee1 emp = (from a in context.Employee1 where a.EmpId == 1 select a).SingleOrDefault(); 
            emp = context.Employee1.Where(x => x.EmpId == 1).SingleOrDefault();
            //LAMBDA EXPRESSION

            string EmpName = (from a in context.Employee1 where a.EmpId == 1 select a.EmpName).SingleOrDefault();
            EmpName = context.Employee1.Where(x => x.EmpId == 1).Select(x => x.EmpName).SingleOrDefault();

            List<Employee1> list = (from a in context.Employee1 where a.DeptId == 1 select a).ToList();
            list = context.Employee1.Where(x => x.DeptId == 1).ToList();

            //employees = context.Employees.OrderByDescending(x => x.EmpSalary).ToList();

            //LIST OF EMPLOYEES

            var empList = (from a in context.Employee1
                           join b in context.Departments on a.DeptId equals b.DepId
                           select new DeptEmp
                           {
                               DeptId = a.DeptId,
                               DeptName = b.DeptName,
                               DeptLocation = b.DeptLocation,
                               EmpId = a.EmpId,
                               EmpName = a.EmpName,
                               EmpSalary= (decimal)a.EmpSalary
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
        //Add a Employee
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]  
            public ActionResult Create(Employee1 emp)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }

            emp.EmpId =0;//for database
            context.Employee1.Add(emp); //adds data in memory
            context.SaveChanges();      //update/insert in the database
            return RedirectToAction("Index");
       

        }
        //Show details
        public ActionResult Details(int id)
        {
            var emp = context.Employee1.Where(x => x.EmpId == id).SingleOrDefault();
            return View(emp);
        }
        [HttpGet]//editing the details
        public ActionResult Edit(int id)
        {
            var emp = context.Employee1.Where(x => x.EmpId == id).SingleOrDefault();
            return View(emp);
        }
        [HttpPost]
        public ActionResult Edit(Employee1 emp)
        {
            //to modify in the database
            context.Entry(emp).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();  //update back to the database
            return RedirectToAction("Index");
        }
        //deleting the emp
        public ActionResult Delete(int id)
        {
            var emp = context.Employee1.Where(x => x.EmpId == id).SingleOrDefault();
            context.Employee1.Remove(emp);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}