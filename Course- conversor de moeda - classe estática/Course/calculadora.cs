using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course {
    internal class calculadora {
       static double IOF = 0.06;
        public static double ConversorDeMoeda(double cotacao, double quantidade) {
            double totalSemIOF = quantidade * cotacao;//620

            double porcentagemAcrecimoIOF = totalSemIOF * IOF;

            double total = totalSemIOF + porcentagemAcrecimoIOF;
            return total;
        }
    }
}
