using Churras.Project.Domain.Entities.v1;
using Churras.Project.Shared.Domain.Classes;
using MediatR;
using System;

namespace Churras.Project.Domain.Commands.v1.CriarChurrasco
{
    public class CriarChurrascoCommand : IRequest<EventResponse<Churrasco>>
    {
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public string ObservacoesAdicionais { get; set; } = "";
        public double ValorSugerido { get; set; }

        public static Churrasco CriarChurrasco(CriarChurrascoCommand criarChurrascoCommand) =>
             new(criarChurrascoCommand.Data, criarChurrascoCommand.Descricao, criarChurrascoCommand.ValorSugerido, criarChurrascoCommand.ObservacoesAdicionais);
    }
}
