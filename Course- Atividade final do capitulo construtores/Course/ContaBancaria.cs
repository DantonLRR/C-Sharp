using System.Globalization;


namespace Course {
    internal class ContaBancaria {
        public int NumeroDaConta { get; private set; }
       public string NomeTitularDaConta { get; set; }
        public double Saldo { get; private set; }
       private int taxaDeSaque = 5;

        public ContaBancaria(int numeroDaConta, string nomeTitularDaConta) {
            NumeroDaConta = numeroDaConta;
            NomeTitularDaConta = nomeTitularDaConta;
        }
        public ContaBancaria(int numeroDaConta, string nomeTitularDaConta, double saldo):this(numeroDaConta,nomeTitularDaConta)  {
            Deposito(saldo);
        }
        public void Deposito(double valor) {
            Saldo += valor;

        }

        public void Saque(double valor) {
            Saldo -= valor + taxaDeSaque;
        }
        public override string ToString() {
            return "Conta: " + NumeroDaConta + ", Titular: " + NomeTitularDaConta + ", Saldo atual: " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
