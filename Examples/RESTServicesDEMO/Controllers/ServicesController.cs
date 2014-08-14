using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RESTServicesDEMO.Controllers
{
    public class ServicesController : Controller
    {
        public class Demo1Class
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public List<int> SomeList { get; set; }
        }

        //public JsonResult Demo1(int? Param1,string Param2)
        //{
        //    Demo1Class Obj = new Demo1Class();
        //    Obj.Name = Param2;
        //    Obj.Surname = Param2;
        //    Obj.SomeList = new List<int>();
        //    Obj.SomeList.Add(Param1.GetValueOrDefault());
        //    return Json(Obj, JsonRequestBehavior.AllowGet);
        //}

        public JsonResult Demo1(int? Param1,string Param2)
        {
            List<int> SomeList = new List<int>();
	        SomeList.Add(Param1.GetValueOrDefault());
            return Json(new{Name=Param2,Surname=Param2,SomeList=SomeList}, JsonRequestBehavior.AllowGet);
        }

        public class Demo2Class
        {
            public string name { get; set; }
            public string surname { get; set; }
            public int age { get; set; }
            public List<int> values { get; set; }
        }
        public JsonResult Demo2(int? id, Demo2Class client)
        {
            // Some server side logic
            return Json(new { result=true }, JsonRequestBehavior.AllowGet);
        }
        [HttpPost]
        public JsonResult Demo2Post(int? id, Demo2Class client)
        {
            // Some server side logic
            return Json(new { result = true });
        }


    }
}
