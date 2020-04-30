using System;
using System.Collections.Generic;
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
    }
}