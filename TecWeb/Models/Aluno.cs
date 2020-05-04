using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TecWeb.Models {
    public class Aluno {
        public int IdAluno { get; set; }
        public string Nome { get; set; }
        public int RA { get; set; }
        public DateTime DataNascimento { get; set; }

        public Aluno(int idAluno, string nome, int rA, DateTime dataNascimento) {
            IdAluno = idAluno;
            Nome = nome;
            RA = rA;
            DataNascimento = dataNascimento;
        }
        public static List<Aluno> listarAluno() {
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
            return Alunos;
        }

        public static List<Aluno> listarAlunoPelaDisciplina(int idDisciplina) {
            SqlConnection minhaConexao = new SqlConnection(ConfigurationManager.ConnectionStrings["minhaConexao"].ConnectionString);
            minhaConexao.Open();

            string select = "select * from Aluno inner join AlunoDisciplina " +
                "on Aluno.IdAluno = AlunoDisciplina.IdAluno " +
                "where AlunoDisciplina.IdDisciplina = " + idDisciplina;
            SqlCommand selectCommand = new SqlCommand(select, minhaConexao);
            SqlDataReader sqlRead = selectCommand.ExecuteReader();


            List<Aluno> Alunos = new List<Aluno>();
            while (sqlRead.Read()) {
                Alunos.Add(new Aluno(int.Parse(sqlRead["IdAluno"].ToString()),
                                     sqlRead["Nome"].ToString(),
                                     int.Parse(sqlRead["RA"].ToString()),
                                     Convert.ToDateTime(sqlRead["DataNascimento"].ToString())));
            }
            return Alunos;
        }
    }
}