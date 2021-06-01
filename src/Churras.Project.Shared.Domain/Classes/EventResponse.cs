using System.Collections.Generic;
using System.Linq;

namespace Churras.Project.Shared.Domain.Classes
{
    public class EventResponse<T> where T : class
    {
        public EventResponse(T data = null)
        {
            Mensagens = new List<FluentValidation.Results.ValidationFailure>();
            Data = data;
        }

        public T Data { get; set; }
        public List<FluentValidation.Results.ValidationFailure> Mensagens { get; private set; }
        public void AddicionarMensagem(FluentValidation.Results.ValidationFailure mensagem) => Mensagens.Add(mensagem);
        public void AddicionarMensagem(IEnumerable<FluentValidation.Results.ValidationFailure> mensagem) => Mensagens.AddRange(mensagem);
        public bool Sucesso { get { return !Mensagens.Any(); } }

        public static EventResponse<T> CriarRepostaComMensagem(FluentValidation.Results.ValidationFailure mensagem)
        {
            var response = new EventResponse<T>(null);
            response.AddicionarMensagem(mensagem);
            return response;
        }

        public static EventResponse<T> CriarRepostaSemMensagem()
        {
            var response = new EventResponse<T>(null);
            return response;
        }

        public static EventResponse<T> CriarRepostaComMensagem(IEnumerable<FluentValidation.Results.ValidationFailure> mensagem)
        {
            var response = new EventResponse<T>(null);
            response.AddicionarMensagem(mensagem);
            return response;
        }
    }
}
