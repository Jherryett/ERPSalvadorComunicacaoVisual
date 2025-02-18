using SalvadorComunicacaoVisual.EnderecosFuncionarios;
using System;

namespace SalvadorComunicacaoVisual.MockFuncionarios

{
    class MockFuncionario // Criei um mock para simular a entrada de dados, para testar service e repository
    {
        static void Main()
        {
            //Construtor do objeto endereco
            EnderecoFuncionario endereco = new EnderecoFuncionario();

            Console.WriteLine("_____ Iniciando teste de mock via console _____");
            Console.WriteLine("Insira os dados para cadastro do endereço do funcionário");

            Console.WriteLine("Digite o nome da rua");
            endereco.NomeRua = Console.ReadLine();

            Console.WriteLine("Digite o nome do bairro");
            endereco.NomeBairro = Console.ReadLine();

            Console.WriteLine("Digite o nome da Cidade");
            endereco.NomeCidade = Console.ReadLine();

            Console.WriteLine("Digite o complemento se necessário");
            endereco.Complemento1 = Console.ReadLine();


        }
    }
}
