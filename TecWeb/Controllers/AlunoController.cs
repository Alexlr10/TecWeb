using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TecWeb.Models;

namespace TecWeb.Controllers {
    public class AlunoController : Controller {
        // GET: Aluno
        public ActionResult Index() {
           
            List<Aluno> Alunos = Aluno.listarAluno();

            //Alunos.Add(new Aluno(1, "Manuel", 123456, Convert.ToDateTime("12/12/2015")));
            //Alunos.Add(new Aluno(2, "Pedro", 14234123, Convert.ToDateTime("12/12/2010")));
            //Alunos.Add(new Aluno(3, "Miguel", 51234123, Convert.ToDateTime("12/12/2008")));
            //Alunos.Add(new Aluno(4, "Lucas", 12341234, Convert.ToDateTime("12/12/1990")));
            //Alunos.Add(new Aluno(5, "Vitor", 543545, Convert.ToDateTime("12/12/2020")));
            //Alunos.Add(new Aluno(6, "Rafael", 1235143, Convert.ToDateTime("12/12/2005")));


            return View(Alunos);
        }
    }
}