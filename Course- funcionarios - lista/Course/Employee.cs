using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course {
    internal class Employee {
        public int ID { get; private set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Employee(int id, string nome, double salario) {
            ID = id;
            Nome = nome;
            Salario = salario;
        }

        public void increaseSalary(double porcentagem) {
            double valorAumento = Salario * porcentagem / 100;
            Salario += valorAumento;
        }

        public override string ToString() {
            return ID+", "+ Nome +", "+ Salario.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
