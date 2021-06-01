using FluentValidation;
using FluentValidation.Results;
using System.Collections.Generic;
using System.Linq;

namespace Churras.Project.Shared.Domain.Classes
{
    public class Command<T> where T : class
    {
        private readonly IEnumerable<IValidator<T>> _validators;
        public List<ValidationFailure> Notifications { get; }
        
        private bool IsValid = true;
        public bool CommandIsValid {get{ return IsValid; } }
        
        public Command(IEnumerable<IValidator<T>> validators)
        {
            _validators = validators;
            Notifications = new List<ValidationFailure>();
        }

        public void Validate(T request)
        {
            var failures = _validators
              .Select(v => v.Validate(request))
              .SelectMany(x => x.Errors)
              .Where(f => f != null)
              .ToList();
            if (failures.Any())
            {
                Notifications.AddRange(failures);
                IsValid = false;
            }
        }

        public ValidationFailure CreateEventFailure(string mensagem, string field = "")
        {
            return new ValidationFailure(field, mensagem);
        }
    }
}
