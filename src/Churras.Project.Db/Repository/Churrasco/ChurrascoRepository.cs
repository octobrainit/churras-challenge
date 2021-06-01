using Churras.Project.Db.Core;
using Churras.Project.Domain.Contract.v1;
using Churras.Project.Shared.Domain.Classes;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Churras.Project.Db.Repository.Churrasco
{
    public class ChurrascoRepository : IChurrascoServiceRepository
    {
        private readonly DatabaseConfiguration _configuration;

        public ChurrascoRepository(DatabaseConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<EventResponse<Domain.Entities.v1.Churrasco>> AlterarChurrascoNoBanco(Domain.Entities.v1.Churrasco churrasco)
        {
            return EventResponse<Domain.Entities.v1.Churrasco>.CriarRepostaSemMensagem();
        }

        public async Task<EventResponse<Domain.Entities.v1.Churrasco>> BuscarChurrascoNoBanco(Domain.Entities.v1.Churrasco churrasco)
        {
            return EventResponse<Domain.Entities.v1.Churrasco>.CriarRepostaSemMensagem();
        }

        public async Task<EventResponse<IEnumerable<Domain.Entities.v1.Churrasco>>> BuscarChurrascosNoBanco()
        {
            return EventResponse<IEnumerable<Domain.Entities.v1.Churrasco>>.CriarRepostaSemMensagem();
        }

        public async Task<EventResponse<Domain.Entities.v1.Churrasco>> InserirChurrascoNoBanco(Domain.Entities.v1.Churrasco churrasco)
        {
            return EventResponse<Domain.Entities.v1.Churrasco>.CriarRepostaSemMensagem();
        }
    }
}
