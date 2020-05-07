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
        [HttpGet]
        public ActionResult Index(int idAluno, string nomeAluno) {
            //List<Disciplina> disciplina = new List<Disciplina>();

            ViewBag.idAluno = idAluno;
            ViewBag.nomeAluno = nomeAluno;


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
            
            List<Disciplina> disciplina = Disciplina.listarDisciplinaPeloAluno(idAluno);
            return View(disciplina);
        }

        [HttpPost]
        public ActionResult Index(int idAluno, int idDisciplina, string alunoNome) {
            string resultad = Disciplina.excluirVinculoDisciplinaAluno(idAluno, idDisciplina);
            @ViewBag.nomeAluno = alunoNome;
            List<Disciplina> disciplina = Disciplina.listarDisciplinaPeloAluno(idAluno);
            return View(disciplina);
        }

        public ActionResult buscarDisciplinas(String term) {

            return Json(Disciplina.buscaDisciplinas(term), JsonRequestBehavior.AllowGet);
        }

       public ActionResult disciplinas() {
            List<Disciplina> disciplina = Disciplina.listarDisciplina();
            return View(disciplina);
        }  

        public ActionResult novaDisciplina() {

            return View();
        }

        [HttpPost]
        public ActionResult novaDisciplina(string Nome, string Semestre, string Curso) {
            string sucesso = Disciplina.novaDisciplina(Nome, Semestre, Curso);
            ViewBag.sucesso = sucesso;

            return View();
        }
    }
}