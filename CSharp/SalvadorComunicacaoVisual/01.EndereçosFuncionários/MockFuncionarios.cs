using SalvadorComunicacaoVisual.EnderecosFuncionarios;
using SalvadorComunicacaoVisual.ServicesEnderecosFuncionarios;
using System;

namespace SalvadorComunicacaoVisual.MockFuncionarios

{
    class MockFuncionario // Criei um mock para simular a entrada de dados, para testar service e repository
    {
        static void Main()
        {
            //Construtor do objeto endereco
            EnderecoFuncionario endereco = new EnderecoFuncionario();
            ServiceEnderecoFuncionario service = new ServiceEnderecoFuncionario();


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

            string erro = service.Validar(endereco);

            if (erro != null)
            {
                Console.WriteLine($"Erro: {erro} Tente novamente.");
            }
            else
            {
                Console.WriteLine("Endereço validado com sucesso!");
                Console.WriteLine("Iniciando processo de inserção no banco de dados");
            }


        }
    }
}
