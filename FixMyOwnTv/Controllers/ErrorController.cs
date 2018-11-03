using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FixMyOwnTv.Controllers
{
    public class ErrorController : Controller
    {

        public ViewResult Global()
        {
            return View("");
        }
        public ViewResult NotFound()
        {
            return View("NotFound");
        }
        public ViewResult Down()
        {
            return View("Down");
        }
    }
}
