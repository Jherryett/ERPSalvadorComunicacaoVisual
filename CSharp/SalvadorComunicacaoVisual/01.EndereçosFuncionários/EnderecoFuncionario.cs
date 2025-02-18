
namespace SalvadorComunicacaoVisual.EnderecosFuncionarios
{
    public class EnderecoFuncionario

    {
        public string? IdEnderecoFuncionario { get; set; }
        public string? NomeRua { get; set; }
        public string? NomeBairro { get; set; }
        public string? NomeCidade { get; set; }
        public string? NomeEstado { get; set; }
        public string? Complemento1 { get; set; }
        public string? Complemento2 { get; set; }
        public DateTime DataCadastro { get; set; }

        public EnderecoFuncionario() { }
        public EnderecoFuncionario(string id, string nomeRua, string nomeBairro, string nomeCidade, string nomeEstado, string complemento1, string complemento2, DateTime dataCadastro)

        {
            IdEnderecoFuncionario = id;
            NomeRua = nomeRua;
            NomeBairro = nomeBairro;
            NomeCidade = nomeCidade;
            NomeEstado = nomeEstado;
            Complemento1 = complemento1;
            Complemento2 = complemento2;
            DataCadastro = dataCadastro;
        }

    }

}

