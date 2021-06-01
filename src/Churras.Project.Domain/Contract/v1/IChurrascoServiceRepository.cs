using Churras.Project.Domain.Entities.v1;
using Churras.Project.Shared.Domain.Classes;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Churras.Project.Domain.Contract.v1
{
    public interface IChurrascoServiceRepository
    {
        Task<EventResponse<Churrasco>> InserirChurrascoNoBanco(Churrasco churrasco);
        Task<EventResponse<Churrasco>> AlterarChurrascoNoBanco(Churrasco churrasco);
        Task<EventResponse<Churrasco>> BuscarChurrascoNoBanco(Churrasco churrasco);
        Task<EventResponse<IEnumerable<Churrasco>>> BuscarChurrascosNoBanco();
    }
}
