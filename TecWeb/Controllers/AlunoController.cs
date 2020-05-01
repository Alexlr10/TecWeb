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
            SqlConnection minhaConexao = new SqlConnection(ConfigurationManager.ConnectionStrings["minhaConexao"].ConnectionString);
            minhaConexao.Open();

            string select = "SELECT * FROM Aluno";
            SqlCommand selectCommand = new SqlCommand(select, minhaConexao);
            SqlDataReader sqlRead = selectCommand.ExecuteReader();


            List<Aluno> Alunos = new List<Aluno>();

            while (sqlRead.Read()) {
                Alunos.Add(new Aluno(int.Parse(sqlRead["IdAluno"].ToString()),
                                     sqlRead["Nome"].ToString(),
                                     int.Parse(sqlRead["RA"].ToString()),
                                     Convert.ToDateTime(sqlRead["DataNascimento"].ToString())));
            }

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