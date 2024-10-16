using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    internal class Candidato {
        public string Nome { get; set; }
        public int Votos { get; private set; }
        private int Porcentagem;


        public Candidato(string nome) {
            Nome = nome;
            Votos = 0;
        }


        public void ComputarVoto() {
            Votos++;
        }

        public void CalPorcento(int eleitores) {
            Porcentagem = Votos * 100 / eleitores;
        }

        public override string ToString() {
            return Nome + " " + Votos;
            ;
        }


    }
}
