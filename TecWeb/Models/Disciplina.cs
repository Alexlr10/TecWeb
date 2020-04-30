using System;
using System.Collections.Generic;
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
    }
}