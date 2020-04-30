using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TecWeb.Models;

namespace TecWeb.Controllers
{
    public class DisciplinaController : Controller
    {
        // GET: Disciplina
        public ActionResult Index()
        {
            Disciplina disciplina = new Disciplina(1, "TecWeb", "IA", "SI");
            return View(disciplina);
        }
    }
}