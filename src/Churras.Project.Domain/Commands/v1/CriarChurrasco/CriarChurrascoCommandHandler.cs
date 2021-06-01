using Churras.Project.Domain.Contract.v1;
using Churras.Project.Domain.Entities.v1;
using Churras.Project.Shared.Domain.Classes;
using FluentValidation;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Churras.Project.Domain.Commands.v1.CriarChurrasco
{
    public class CriarChurrascoCommandHandler : Command<CriarChurrascoCommand>, IRequestHandler<CriarChurrascoCommand, EventResponse<Churrasco>>
    {
        private readonly IChurrascoServiceRepository _churrascoServiceRepository;

        public CriarChurrascoCommandHandler(
                                            IChurrascoServiceRepository churrascoServiceRepository,
                                            IEnumerable<IValidator<CriarChurrascoCommand>> validators
         ) : base(validators)
        {
            _churrascoServiceRepository = churrascoServiceRepository;
        }

        public async Task<EventResponse<Churrasco>> Handle(CriarChurrascoCommand request, CancellationToken cancellationToken)
        {
            Validate(request);

            if (!CommandIsValid)
                return EventResponse<Churrasco>.CriarRepostaComMensagem(Notifications);

            return
                 await ExisteChurrasco(request) ?
                     EventResponse<Churrasco>.CriarRepostaComMensagem(CreateEventFailure("Churasco Já existente")) :
                     await _churrascoServiceRepository.InserirChurrascoNoBanco(CriarChurrascoCommand.CriarChurrasco(request));
        }

        private async Task<bool> ExisteChurrasco(CriarChurrascoCommand request)
        {
            var churrasco = await _churrascoServiceRepository.BuscarChurrascoNoBanco(new Churrasco(request.Data, request.Descricao, request.ValorSugerido));
            return churrasco?.Data != null;
        }
    }
}
