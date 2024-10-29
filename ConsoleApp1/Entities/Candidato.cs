using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    internal class Candidato(string nome)
    {
        private string Nome { get; set; } = nome;
        public int Votos { get; private set; }
        protected int Porcentagem;
        
        public void ComputarVoto() {
            Votos++;
        }

        public void CalPorcento(int eleitores) {
            Porcentagem = Votos * 100 / eleitores;
        }

        public override string ToString() {
            return Nome + " " + Votos;
        }
    }
}
