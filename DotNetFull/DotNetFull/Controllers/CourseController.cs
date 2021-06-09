using DotNetFull.Models;
using DotNetFull.Models.DB;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace DotNetFull.Controllers
{
    public class CourseController : Controller
    {    //course/index
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour > 12 ? "Good Afternoon " : "Good morning ";
            return View("MyView");
        }
        //course/list
        public ViewResult List()
        {
           var liste =  Repository.Students.Where(x => x.WillAttend == true);
            return View(liste);
        }
        [HttpGet]
        public ViewResult Apply()
        {
            return View();
        }
        [Route("/course/Apply2")]
        [HttpPost]
        public ViewResult Apply2(Student student)
        {
            if (ModelState.IsValid)
            {
                CoreDBContext _db = new CoreDBContext();


                //Repository.AddStudent(student);
                //return View("Thanks", student);
                return View();

            }
            else
            {
                return View();
            }
            //Model binding
            //Student bilgisini veri tabanına kaydet
         
        }
        public ViewResult About()
        {
            return View();
        }
        public ViewResult Uzay()
        {
            return View();
        }
    }
}
