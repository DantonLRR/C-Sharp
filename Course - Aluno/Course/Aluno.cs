using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course {
    internal class Aluno {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public string notaFinal() {
            //media 60 pontos
            double total = Nota1 + Nota2 + Nota3;
            if (total > 60) {
                return "Nota Final = " + total + " Aprovado";

            }
            else {
                return "Nota Final = " + total + " Reprovado, faltaram: " + (60.00 - total) +" Pontos";
            }
        }
    }
}
