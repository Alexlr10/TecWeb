using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TecWeb.Models;

namespace TecWeb.Controllers {
    public class DisciplinaController : Controller {
        // GET: Disciplina
        public ActionResult Index(int idAluno, string nomeAluno) {
            //List<Disciplina> disciplina = new List<Disciplina>();

            ViewBag.idAluno = idAluno;
            ViewBag.nomeAluno = nomeAluno;

            List<Disciplina> disciplina = Disciplina.listarDisciplina(idAluno);

            //disciplina.Add(new Disciplina(1, 1, "Tecnologia Web", "5A", "SI"));
            //disciplina.Add(new Disciplina(1, 2, "Banco de Dados 1 ", "5A", "SI"));
            //disciplina.Add(new Disciplina(1, 3, "Banco de Dados 2", "1A", "SI"));

            //disciplina.Add(new Disciplina(2, 1, "Arquitetura de Computadores", "1A", "SI"));
            //disciplina.Add(new Disciplina(2, 2, "Arquitetura de Computadores", "1A", "SI"));
            //disciplina.Add(new Disciplina(2, 3, "Arquitetura de Computadores", "1A", "SI"));
            //disciplina.Add(new Disciplina(2, 4, "Arquitetura de Computadores", "1A", "SI"));

            //disciplina.Add(new Disciplina(3, 5, "Arquitetura de Computadores", "1A", "SI"));
            //disciplina.Add(new Disciplina(3, 6, "Arquitetura de Computadores", "1A", "SI"));

            //disciplina.Add(new Disciplina(4, 5, "Arquitetura de Computadores", "1A", "SI"));
            //disciplina.Add(new Disciplina(4, 6, "Arquitetura de Computadores", "1A", "SI"));

            //List<Disciplina> DisciplinasDeAluno = disciplina.Where(x => x.IdAluno == idAluno).ToList();


            return View(disciplina);
        }
    }
}