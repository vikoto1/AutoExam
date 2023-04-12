using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoExam.Models;

namespace AutoExam.Controllers
{
    public class CategoryBController : Controller
    {
       
        public ActionResult Load()
        {

            using (var ctx = new DBCategoryB())
            {
               var list2 = (from result in ctx.Questions.Include("Answer.TrueAnswer")
                            orderby Guid.NewGuid()
                            select result).Take(45);

               return View(list2.ToList());
            }

        }

        public ActionResult DrivingSchool()
        {
            return View();
        }

       

        public ActionResult ExpiryTime()
        {
            return View();
        }


        [HttpPost]
        public ActionResult LoadData(List<Question> selected)
        {
           
            return View(selected);

        }
    }
}

