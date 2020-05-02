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

        public Disciplina(int idDisciplina, int idAluno, string nome, string semestre, string curso) {
            IdDisciplina = idDisciplina;
            IdAluno = idAluno;
            Nome = nome;
            Semestre = semestre;
            Curso = curso;
        }

        public static List<Disciplina> listarDisciplina(int idAluno) {

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
    }
}