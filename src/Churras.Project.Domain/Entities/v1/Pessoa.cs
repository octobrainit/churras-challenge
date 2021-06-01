using Churras.Project.Shared.Domain.Classes;

namespace Churras.Project.Domain.Entities.v1
{
    public class Pessoa : Entity
    {
        public Pessoa(string nome, double valorContribuicao)
        {
            Nome = nome;
            ValorContribuicao = valorContribuicao;
        }
        public string Nome { get; private set; }
        public double ValorContribuicao { get; private set; }
    }
}
