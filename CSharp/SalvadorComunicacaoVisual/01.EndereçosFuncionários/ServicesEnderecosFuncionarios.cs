using System;
using SalvadorComunicacaoVisual.EnderecosFuncionarios;
using SalvadorComunicacaoVisual.MockFuncionarios;

namespace SalvadorComunicacaoVisual.ServicesEnderecosFuncionarios
{
    public class ServiceEnderecoFuncionario
    {
        public string Validar(EnderecoFuncionario endereco)
        {
            if (string.IsNullOrWhiteSpace(endereco.NomeRua))
                return "O nome da rua não pode ficar em branco";

            if (string.IsNullOrWhiteSpace(endereco.NomeBairro))
                return "O nome do bairro não pode ficar em branco";

            if (string.IsNullOrWhiteSpace(endereco.NomeCidade))
                return "O nome da cidade não pode ficar em branco";

            return null;

        }

    }
}
