using FluentValidation;

namespace Churras.Project.Domain.Commands.v1.CriarChurrasco
{
    public class CriarChurrascoCommandValidator : AbstractValidator<CriarChurrascoCommand>
    {
        public CriarChurrascoCommandValidator()
        {
            RuleFor(x => x.Data).NotNull();
            RuleFor(x => x.Descricao).NotNull().NotEmpty();
            RuleFor(x => x.ValorSugerido).NotNull();
        }
    }
}
