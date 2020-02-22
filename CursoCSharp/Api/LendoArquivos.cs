using System;
using System.IO;

namespace CursoCSharp.Api {
    class LendoArquivos {
        public static void Executar() {
            var path = @"~/lendo_arquivos.txt".ParseHome();

            if(!File.Exists(path)) { 
                using(StreamWriter stream = File.AppendText(path)) {
                    stream.WriteLine("Produto;Preco;Qtde");
                    stream.WriteLine("Caneta Bic Preta;3.59;89");
                    stream.WriteLine("Borracha Branca;2.20;37");
                }
            }

            try {
                using(StreamReader stream = new StreamReader(path)) {
                    var texto = stream.ReadToEnd();
                    Console.WriteLine(texto);
                }
            } catch(Exception excecao) {
                Console.WriteLine(excecao.Message);
            }
        }
    }
}
