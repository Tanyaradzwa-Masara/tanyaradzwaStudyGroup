using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace tanyaradzwaStudyGroup.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Students()
        {
            List<Models.StudentList> Students = new List<Models.StudentList>
{
    new Models.StudentList { StudentNumber = "U23557509", Name = "Tanyaradzwa", Surname = "Masara", Email_Address = "U23557509@tuks.co.za" },
    new Models.StudentList { StudentNumber = "U24557510", Name = "Kudzai", Surname = "Chiwenga", Email_Address = "U24557510@tuks.co.za" },
    new Models.StudentList { StudentNumber = "U21557511", Name = "Sipho", Surname = "Ndlovu", Email_Address = "U21557511@tuks.co.za" },
    new Models.StudentList { StudentNumber = "U01557512", Name = "Aisha", Surname = "Patel", Email_Address = "U01557512@tuks.co.za" },
    new Models.StudentList { StudentNumber = "U22557513", Name = "Johan", Surname = "Van Rensburg", Email_Address = "U22557513@tuks.co.za" }
};

            return View(Students);

        }
    }
}