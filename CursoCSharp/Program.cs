using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.Api;
using CursoCSharp.TopicosAvancados;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar },
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar },
                {"Inferência - Fundamentos", Inferencia.Executar },
                {"Interpolação - Fundamentos", Interpolacao.Executar },
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar },
                {"Lendo Dados - Fundamentos", LendoDados.Executar },
                {"Formatando Número - Fundamentos", FormatandoNumero.Executar },
                {"Conversões - Fundamentos", Conversoes.Executar },
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar },
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar },
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar },
                {"Operador de Atribuição - Fundamentos", OperadoresAtribuicao.Executar },
                {"Operadores Unários - Fundamentos", OperadoresUnarios.Executar },
                {"Operador Ternário - Fundamentos", OperadorTernario.Executar },

                // Estruturas de Controle
                {"Estrutura If - Estruturas de Controle", EstruturaIf.Executar },
                {"Estrutura If/Else - Estruturas de Controle", EstruturaIfElse.Executar },
                {"Estrutura If/Else/If - Estruturas de Controle", EstruturaIfElseIf.Executar },
                {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar },
                {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar },
                {"Estrutura DoWhile - Estruturas de Controle", EstruturaDoWhile.Executar },
                {"Estrutura For - Estruturas de Controle", EstruturaFor.Executar },
                {"Estrutura ForEach - Estruturas de Controle", EstruturaForEach.Executar },
                {"Usando Break - Estruturas de Controle", UsandoBreak.Executar },
                {"Usando Continue - Estruturas de Controle", UsandoContinue.Executar },
                
                // Classes e Métodos
                {"Membros - Classes e Metodos", Membros.Executar },
                {"Construtores - Classes e Metodos", Construtores.Executar },
                {"Métodos Com Retorno - Classes e Metodos", MetodosComRetorno.Executar },
                {"Métodos Estáticos - Classes e Metodos", MetodosEstaticos.Executar },
                {"Atributos Estáticos - Classes e Metodos", AtributosEstaticos.Executar },
                {"Desafio Atributo - Classes e Metodos", DesafioAtributo.Executar },
                {"Params - Classes e Metodos", Params.Executar },
                {"Parametros Nomeados - Classes e Metodos", ParametrosNomeados.Executar },
                {"Get Set - Classes e Metodos", GetSet.Executar },
                {"Props - Classes e Metodos", Props.Executar },
                {"Readonly - Classes e Metodos", Readonly.Executar },
                {"Enum - Classes e Metodos", ExemploEnum.Executar },
                {"Struct - Classes e Metodos", ExemploStruct.Executar },
                {"Struct Vs Classe - Classes e Metodos", StructVsClasse.Executar },
                {"Valor Vs Referencia - Classes e Metodos", ValorsVsReferencia.Executar },
                {"Parametros Por Referencia - Classes e Metodos", ParametrosPorReferencia.Executar },
                {"Parametro com Valor Padrao - Classes e Metodos", ParametroPadrao.Executar },
                
                // Coleções
                {"Array - Coleções", Colecoes.Array.Executar },
                {"List - Coleções", ColecoesList.Executar },
                {"ArrayList - Coleções", ColecoesArrayList.Executar },
                {"Set - Coleções", ColecoesSet.Executar },
                {"Queue - Coleções", ColecoesQueue.Executar },
                {"Igualdade - Coleções", Igualdade.Executar },
                {"Stack - Coleções", ColecoesStack.Executar },
                {"Dictionary - Coleções", ColecoesDictionary.Executar },
                
                // OO
                {"Herança - OO", Heranca.Executar },
                {"Construtor This - OO", ConstrutorThis.Executar },
                {"Encapsulamento - OO", OO.Encapsulamento.Executar },
                {"Polimorfismo - OO", Polimorfismo.Executar },
                {"Abstract - OO", Abstract.Executar },
                {"Interface - OO", Interface.Executar },
                {"Sealed - OO", Sealed.Executar },

                // Métodos & Funções
                {"Exemplo Lambda - Métodos & Funções", ExemploLambda.Executar },
                {"Lambdas Como Delegates - Métodos & Funções", LambdasDelegate.Executar },
                {"Usando Delegates - Métodos & Funções", UsandoDelegates.Executar },
                {"Delegates Como Função Anonima - Métodos & Funções", DelegateFuncAnonima.Executar },
                {"Delegates Como Parametros - Métodos & Funções", DelegatesComoParametros.Executar },
                {"Métodos de Extensão - Métodos & Funções", MetodosDeExtensao.Executar },
                
                // Exceções
                {"Primeira Exceção - Exceções", PrimeiraExcecao.Executar },
                {"Exceções Personalizadas - Exceções", ExcecoesPersonalizadas.Executar },
                
                // Api 
                {"Primeiro Arquivo - Usando Api", PrimeiroArquivo.Executar },
                {"Lendo Arquivos - Usando Api", LendoArquivos.Executar },
                {"Exemplo FileInfo - Usando Api", ExemploFileInfo.Executar },
                {"Diretorios - Usando Api", Diretorios.Executar },
                {"Exemplo DirectoryInfo - Usando Api", ExemploDirectoryInfo.Executar },
                {"Exemplo Path - Usando Api", ExemploPath.Executar },
                {"Exemplo DateTime - Usando Api", ExemploDateTime.Executar },
                {"Exemplo TimeSpan - Usando Api", ExemploTimeSpan.Executar },
                
                // Tópicos Avançados
                {"LINQ #01 - Tópicos Avançados", LINQ1.Executar },
                {"LINQ #02 - Tópicos Avançados", LINQ2.Executar },
                {"Nullables - Tópicos Avançados", Nullables.Executar },
                {"Dynamics - Tópicos Avançados", Dynamics.Executar },
            });

            central.SelecionarEExecutar();
        }
    }
}