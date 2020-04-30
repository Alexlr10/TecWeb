using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TecWeb.Models;

namespace TecWeb.Controllers
{
    public class AlunoController : Controller
    {
        // GET: Aluno
        public ActionResult Index()
        {
            Aluno aluno = new Aluno(1, "Manuel", 123456, Convert.ToDateTime("12/12/2015"));
            return View(aluno);
        }
    }
}