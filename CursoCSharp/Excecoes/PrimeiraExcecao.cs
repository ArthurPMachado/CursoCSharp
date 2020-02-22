using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Excecoes {
    public class Conta {
        private double Saldo;

        public Conta(double saldo) {
            Saldo = saldo;
        }

        public void Sacar(double valor) {
            if(valor > Saldo) {
                throw new ArgumentException("Saldo insuficiente.");
            }

            Saldo -= valor;
        }
    }

    class PrimeiraExcecao {
        public static void Executar() {
            var conta = new Conta(1_223.45);

            try {
                // int.Parse("abc");

                conta.Sacar(1_600);
                Console.WriteLine("Retirada com sucesso!");
            } catch(Exception excecao) {
                Console.WriteLine(excecao.GetType().Name);
                Console.WriteLine(excecao.Message);
            } finally {
                Console.WriteLine("Obrigado!");
            }
        }
    }
}
