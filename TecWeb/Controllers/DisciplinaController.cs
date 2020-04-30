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
            List<Disciplina> disciplina = new List<Disciplina>();
               disciplina.Add( new Disciplina(1, "Tecnologia Web", "5A", "SI"));
               disciplina.Add( new Disciplina(1, "Banco de Dados 1 ", "5A", "SI"));
               disciplina.Add( new Disciplina(1, "Banco de Dados 2", "1A", "SI"));
               disciplina.Add( new Disciplina(1, "Arquitetura de Computadores", "1A", "SI"));




            return View(disciplina);
        }
    }
}