using FluentValidation;
using Pizzaria.Models;

namespace Pizzaria.Validators;

    public class ValidatorBebida : AbstractValidator<Tb_bebida> {
        public ValidatorBebida() {

            RuleFor(a => a.Id)
                .Null().WithMessage("Campo [Id] deve ser null");

            RuleFor(a => a.Nome_bebida)
                .NotEmpty().WithMessage("Nome inválido");

            RuleFor(a => a.Valor_bebida)
                .NotEmpty().WithMessage("Valor inválido");

            RuleFor(a => a.Descricao_bebida)
                .NotEmpty().WithMessage("Campo [Descricao] não pode estar vazío");

            RuleFor(a => a.Is_alcoolica)
                .NotNull().WithMessage("Campo [Is_alcoolica] não pode estar vazío");
        }
    }