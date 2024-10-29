using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    internal abstract class Program {
        private static void Main(string[] args) {

            const int eleitores = 1564540;

            var contador = eleitores;
            var contadorVotos = 0;

            var bolsonaro = new Candidato("Bolsonaro");
            var ciro = new Candidato("Ciro");
            var lula = new Candidato("Lula");
            var random = new Random();

            Console.WriteLine("ELEIÇÕES 2023 EM C#\n");
            Thread.Sleep(3000);

            while(contador > 0) {
                var votos = random.Next(0, 3);
                var votoApurados = (contadorVotos * 100) / eleitores;
                Console.Write($"\rVotos apurados: {votoApurados}%");
                contadorVotos++;
                contador--;

                switch(votos) {
                    case 0:
                        bolsonaro.ComputarVoto();                        
                        break;
                    case 1:
                        ciro.ComputarVoto();
                        break;
                    case 2:
                        lula.ComputarVoto();                        
                        break; 
                }
            }

            Console.WriteLine("\n\nO candidato vencedor das eleições CSharp 2025 é: \n");
            Thread.Sleep(3000);
            Console.Write(Funcao.Vencedor(bolsonaro, ciro, lula));
            Console.WriteLine("\n");


        }
    }
}
