using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp1 {
    internal static class Funcao {

        public static string Vencedor(Candidato bolsonaro, Candidato ciro, Candidato lula) {
            string msg = "", msg2 = "", msg3 = "";

            // Vitoria do bolsonaro
            if(bolsonaro.Votos > ciro.Votos && bolsonaro.Votos > lula.Votos) {
                msg = $"1° {bolsonaro.ToString()}";

                if(ciro.Votos > lula.Votos) {
                    msg2 = $"2° {ciro.ToString()}";
                    msg3 = $"3° {lula.ToString()}";
                }
                else {
                    msg2 = $"2° {lula.ToString()}";
                    msg3 = $"3° {ciro.ToString()}";
                }
                return $"{msg}\n{msg2}\n{msg3}";
            }

            // Vitoria do Ciro
            if(ciro.Votos > bolsonaro.Votos && ciro.Votos > lula.Votos) {
                msg = $"1° {ciro.ToString()}";

                if(bolsonaro.Votos > lula.Votos) {
                    msg2 = $"2° {bolsonaro.ToString()}";
                    msg3 = $"3° {lula.ToString()}";
                }
                else {
                    msg2 = $"2° {lula.ToString()}";
                    msg3 = $"3° {bolsonaro.ToString()}";
                }
                return $"{msg}\n{msg2}\n{msg3}";
            }

            // Vitoria do Lula
            if(lula.Votos > bolsonaro.Votos && lula.Votos > ciro.Votos) {
                msg = $"1° {lula.ToString()}";

                if(bolsonaro.Votos > ciro.Votos) {
                    msg2 = $"2° {bolsonaro.ToString()}";
                    msg3 = $"3° {ciro.ToString()}";
                }
                else {
                    msg2 = $"2° {ciro.ToString()}";
                    msg3 = $"3° {bolsonaro.ToString()}";
                }
                return $"{msg}\n{msg2}\n{msg3}";
            }

            return "Erro na computação dos votos";


        }

        

    }

}

