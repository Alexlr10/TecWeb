using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TecWeb.Models {
    public class Disciplina {
        public int IdDisciplina { get; set; }
        public int IdAluno { get; set; }
        public string Nome { get; set; }
        public string Semestre { get; set; }
        public string Curso { get; set; }
        public List<Aluno> Alunos { get; set; }

        public Disciplina(int idDisciplina, int idAluno, string nome, string semestre, string curso) {
            IdDisciplina = idDisciplina;
            IdAluno = idAluno;
            Nome = nome;
            Semestre = semestre;
            Curso = curso;
            Alunos = Aluno.listarAlunoPelaDisciplina(idDisciplina);
        }

        public Disciplina(int idDisciplina, string nome, string semestre, string curso) {
            IdDisciplina = idDisciplina;
            Nome = nome;
            Semestre = semestre;
            Curso = curso;
            Alunos = Aluno.listarAlunoPelaDisciplina(idDisciplina);
        }

        public static List<Disciplina> listarDisciplinaPeloAluno(int idAluno) {

            List<Disciplina> disciplina = new List<Disciplina>();

            SqlConnection minhaConexao = new SqlConnection(ConfigurationManager.ConnectionStrings["minhaConexao"].ConnectionString);
            minhaConexao.Open();

            string select = "SELECT * from Disciplina inner join AlunoDisciplina " +
                "on Disciplina.IdDisciplina = AlunoDisciplina.IdDisciplina where AlunoDisciplina.IdAluno = " + idAluno;
            SqlCommand selectCommand = new SqlCommand(select, minhaConexao);
            SqlDataReader sqlRead = selectCommand.ExecuteReader();

            
            while (sqlRead.Read()) {
                disciplina.Add(new Disciplina(int.Parse(sqlRead["IdDisciplina"].ToString()),
                                     idAluno,
                                     sqlRead["Nome"].ToString(),
                                     sqlRead["Semestre"].ToString(),
                                     sqlRead["Curso"].ToString()));
            }

            return disciplina;

        }

        public static List<Disciplina> listarDisciplina() {

            List<Disciplina> disciplina = new List<Disciplina>();

            SqlConnection minhaConexao = new SqlConnection(ConfigurationManager.ConnectionStrings["minhaConexao"].ConnectionString);
            minhaConexao.Open();

            string select = "SELECT * from Disciplina ";
            SqlCommand selectCommand = new SqlCommand(select, minhaConexao);
            SqlDataReader sqlRead = selectCommand.ExecuteReader();


            while (sqlRead.Read()) {
                disciplina.Add(new Disciplina(int.Parse(sqlRead["IdDisciplina"].ToString()),
                                     sqlRead["Nome"].ToString(),
                                     sqlRead["Semestre"].ToString(),
                                     sqlRead["Curso"].ToString()));
            }

            return disciplina;

        }

        public static string novaDisciplina(string nome, string semestre, string curso) {

          

            SqlConnection minhaConexao = new SqlConnection(ConfigurationManager.ConnectionStrings["minhaConexao"].ConnectionString);
            minhaConexao.Open();

            string insert = string.Format("INSERT INTO Disciplina (Nome, Semestre, Curso) VALUES ('{0}','{1}','{2}')", nome, semestre, curso);
            SqlCommand selectCommand = new SqlCommand(insert, minhaConexao);
            selectCommand.ExecuteNonQuery();

            return "Sucesso";

        }


    }
}