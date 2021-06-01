using Churras.Project.Shared.Domain.Classes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Churras.Project.Domain.Entities.v1
{
    public class Churrasco : Entity
    {
        public Churrasco(DateTime data, string descricao, double valorSugerido ,string observacoesAdicionais = "")
        {
            Data = data;
            Descricao = descricao;
            ValorSugerido = valorSugerido;
            ObservacoesAdicionais = observacoesAdicionais;
            Pessoas = new List<Pessoa>();
        }
        
        public DateTime Data { get; private set; }
        public string Descricao { get; private set; }
        public string ObservacoesAdicionais { get; private set; }
        public double ValorSugerido { get; private set; }
        public List<Pessoa> Pessoas { get; set; }

        public void AddPessoa(Pessoa pessoa)
        {
            if (!ChecharSePessoaExiste(pessoa.Nome))
                Pessoas.Add(pessoa);
        }

        public bool ChecharSePessoaExiste(string nome) => 
            Pessoas.Any(item => item.Nome.Contains(nome, StringComparison.OrdinalIgnoreCase));
    }
}
