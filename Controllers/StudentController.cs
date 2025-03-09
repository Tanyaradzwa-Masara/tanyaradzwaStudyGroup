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
    new Models.StudentList { StudentNumber = "U23557509", Name = "Tanyaradzwa", Surname = "Masara", Email_Address = "U23557509@tuks.co.za",myLink="~/HTML/Tanyaradzwa.html"},
    new Models.StudentList { StudentNumber = "U04949872", Name = "Mia", Surname = "Hand", Email_Address = "U04949872@tuks.co.za", myLink="~/HTML/Mia.html" },
    new Models.StudentList { StudentNumber = "U24892859", Name = "Karen", Surname = "Kumbula", Email_Address = "U24892859@tuks.co.za", myLink="~/HTML/Karen.html" },
    new Models.StudentList { StudentNumber = "U24666492", Name = "Palesa", Surname = "Mokgolobotho", Email_Address = "U24666492@tuks.co.za", myLink="~/HTML/Palesa.html" },
    new Models.StudentList { StudentNumber = "U23546094", Name = "Mutarisi", Surname = "Chibaya", Email_Address = "U23546094@tuks.co.za", myLink="~/HTML/Mutarisi.html" }
};

            return View(Students);

        }
     
    }
}